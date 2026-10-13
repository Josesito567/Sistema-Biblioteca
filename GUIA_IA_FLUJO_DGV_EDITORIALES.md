# Guía para replicar el flujo del `DataGridView` de Editoriales

## Objetivo

Esta guía documenta los cambios realizados para que la vista de editoriales cargue registros desde SQL Server en el `DataGridView` `dgvEditoriales`. Está escrita para que otro modelo de IA o desarrollador pueda diagnosticar y reproducir el flujo sin asumir que la base de datos ya está preparada.

## Contexto del proyecto

- Proyecto: `Sistema_Biblioteca`
- Plataforma: .NET 10
- Interfaz: Windows Forms
- ORM: Entity Framework Core con SQL Server
- Servidor SQL configurado: `14-LAB1PC3\TECHNOTEL`
- Base de datos: `sistema_biblioteca`
- Tabla requerida: `dbo.Editoriales`

## Flujo completo de datos

El flujo funcional es:

1. `UcLibros` crea la vista `UcEditoriales` cuando se pulsa el botón de editoriales.
2. El constructor de `UcEditoriales` ejecuta `CargarEditorialesEnLaTabla()`.
3. `CargarEditorialesEnLaTabla()` llama a `EditorialesControlador.GetAll()`.
4. `GetAll()` crea un `LibraryContext` y ejecuta `context.Editoriales.ToList()`.
5. Entity Framework Core traduce la consulta a SQL contra `dbo.Editoriales`.
6. La lista de `EditorialesModelo` se asigna a `dgvEditoriales.DataSource`.
7. Windows Forms genera las columnas del `DataGridView` a partir de las propiedades del modelo.

## Archivos implicados

### `Data/LibraryContext.cs`

Define el contexto de Entity Framework y la conexión SQL Server. La configuración utilizada es equivalente a:

```text
Server=14-LAB1PC3\TECHNOTEL;
Database=sistema_biblioteca;
Trusted_Connection=True;
TrustServerCertificate=True;
```

El contexto expone el conjunto:

```csharp
public DbSet<EditorialesModelo> Editoriales { get; set; }
```

Al llamarse la propiedad `Editoriales`, EF Core usa ese nombre como nombre de tabla por convención. El esquema esperado es `dbo`.

### `Modelos/EditorialesModelo.cs`

Representa las columnas de `dbo.Editoriales`:

| Propiedad C# | Tipo C# | Columna SQL | Tipo SQL |
|---|---:|---|---|
| `id_editoriales` | `int` | `id_editoriales` | `INT IDENTITY PRIMARY KEY` |
| `nombre` | `string` | `nombre` | `VARCHAR(150)` |
| `direccion` | `string` | `direccion` | `VARCHAR(255)` |
| `ciudad` | `string` | `ciudad` | `VARCHAR(100)` |
| `telefono` | `string` | `telefono` | `VARCHAR(20)` |
| `email` | `string` | `email` | `VARCHAR(100)` |
| `estado` | `byte` | `estado` | `TINYINT` |
| `fecha_registro` | `DateTime` | `fecha_registro` | `DATETIME2` |

Es importante que `estado` sea `byte`. Inicialmente estaba declarado como `string`, pero la base de datos lo define como `TINYINT`; esa diferencia puede provocar un error al materializar los resultados aunque la tabla ya exista.

### `Controladores/EditorialesControlador.cs`

El método de lectura es estático y devuelve todos los registros:

```csharp
public static List<EditorialesModelo> GetAll()
{
	using var context = new LibraryContext();
	return context.Editoriales.ToList();
}
```

El controlador no debe consultar directamente el `DataGridView`. Su responsabilidad es obtener los datos mediante el contexto.

### `Vistas/Inicio/Paginas/UcEditoriales.cs`

El constructor carga los datos al crear el control:

```csharp
public UcEditoriales()
{
	InitializeComponent();
	CargarEditorialesEnLaTabla();
}
```

La carga se realiza así:

```csharp
private void CargarEditorialesEnLaTabla()
{
	var listaDeEditoriales = EditorialesControlador.GetAll();
	dgvEditoriales.DataSource = listaDeEditoriales;
}
```

No es necesario crear manualmente las columnas si se utiliza el enlace automático de `DataGridView` mediante `DataSource`.

## Causa de la excepción original

La excepción fue:

```text
Microsoft.Data.SqlClient.SqlException:
Invalid object name 'Editoriales'.
```

El error ocurrió en `context.Editoriales.ToList()`. El código estaba intentando consultar `dbo.Editoriales`, pero la base `sistema_biblioteca` existía sin tener tablas creadas.

La comprobación se realizó en la misma instancia indicada por `LibraryContext` y confirmó:

- La base `sistema_biblioteca` existía.
- No estaban creadas las tablas esperadas.
- Después de ejecutar el script, `dbo.Editoriales` quedó creada.
- La tabla quedó con 15 registros.

Conclusión: no era un problema del `DataGridView` ni del evento de navegación. Era un problema de estructura y datos de la base de datos.

## Preparación de la base de datos

El script relevante es:

```text
Scripts/Editoriales_Tabla.sql
```

También existe:

```text
Scripts/tablas.sql
```

El script de editoriales crea la base `sistema_biblioteca`, selecciona esa base, crea `Editoriales` e inserta datos de prueba. Si la base ya existe, debe evitarse ejecutar de nuevo de forma ciega la instrucción `CREATE DATABASE`.

Comprobaciones recomendadas en SQL Server:

```sql
SELECT name
FROM sys.databases
WHERE name = 'sistema_biblioteca';
```

```sql
USE sistema_biblioteca;
GO

SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'Editoriales';
```

```sql
USE sistema_biblioteca;
GO

SELECT COUNT(*) AS Registros
FROM dbo.Editoriales;
```

El resultado esperado de la segunda consulta es:

```text
TABLE_SCHEMA | TABLE_NAME
-------------|------------
dbo          | Editoriales
```

## Procedimiento de diagnóstico para otra IA

Cuando aparezca un error equivalente, seguir este orden:

1. Leer `Data/LibraryContext.cs` y extraer servidor, base de datos y nombre del `DbSet`.
2. Leer el modelo asociado y comparar nombres y tipos con el script SQL.
3. Leer el controlador para localizar la consulta que dispara la excepción.
4. Leer el control WinForms para verificar dónde se asigna `DataSource`.
5. Consultar la existencia de la base de datos en la instancia exacta de SQL Server.
6. Consultar la existencia de la tabla en el esquema esperado, normalmente `dbo`.
7. Si falta la tabla, ejecutar el script SQL correspondiente en la instancia correcta.
8. Si existe una diferencia de esquema, corregir el script o configurar explícitamente el nombre de tabla/esquema en EF Core.
9. Comparar tipos SQL y tipos C# antes de probar de nuevo.
10. Compilar la solución y reiniciar la aplicación si estaba detenida en el depurador antes de aplicar los cambios.

## Errores que no deben confundirse

### `Invalid object name 'Editoriales'`

La conexión llegó a SQL Server, pero no encuentra la tabla en la base actual. Revisar servidor, base, esquema y ejecución del script.

### Error de conversión de `estado`

La tabla existe, pero el modelo usa un tipo incompatible. En este proyecto la solución es `byte` para la columna SQL `TINYINT`.

### El `DataGridView` aparece vacío

Comprobar, en este orden:

1. Que `GetAll()` devuelve registros.
2. Que `dbo.Editoriales` contiene datos.
3. Que `dgvEditoriales.DataSource` recibe la lista.
4. Que `CargarEditorialesEnLaTabla()` se ejecuta después de `InitializeComponent()`.
5. Que el control visible es la instancia correcta de `UcEditoriales`.

### Error de conexión

Si aparece un error de servidor o autenticación, no es un problema de la tabla. Comparar la cadena de `LibraryContext` con la instancia donde se ejecutó el script.

## Validación final

La solución se considera funcional cuando se cumplen todas estas condiciones:

- `dbo.Editoriales` existe en `sistema_biblioteca`.
- La tabla contiene registros.
- El modelo usa tipos compatibles con SQL Server.
- `EditorialesControlador.GetAll()` compila y devuelve una lista.
- `UcEditoriales` asigna esa lista a `dgvEditoriales.DataSource`.
- La solución compila correctamente.
- La aplicación se reinicia después de cambios realizados durante una sesión de depuración.

## Regla de replicación

No cambiar primero el controlador o el `DataGridView` ante un error `Invalid object name`. Primero validar la conexión y la existencia de la tabla en la base real. El código solo funcionará si el esquema SQL esperado está creado en la misma instancia a la que apunta `LibraryContext`.
