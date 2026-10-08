# Sistema de Biblioteca

Aplicación de escritorio para la gestión visual de una biblioteca escolar. Está desarrollada con **C#**, **.NET 10** y **Windows Forms**, utilizando **MaterialSkin** para la interfaz gráfica.

## Estado del proyecto

> Proyecto en desarrollo.

Actualmente incluye una ventana de acceso, una ventana principal con menú lateral, vistas para libros y préstamos, y un formulario con información de contacto.

## Características

- Ventana de inicio de sesión.
- Validación básica de correo y contraseña no vacíos.
- Mostrar u ocultar la contraseña mediante un icono.
- Ventana principal maximizada.
- Navegación mediante menú lateral.
- Vista de libros.
- Vista de préstamos.
- Formulario de contacto del equipo desarrollador.
- Tema visual basado en MaterialSkin.
- Recursos gráficos incluidos en la carpeta `resources`.

## Tecnologías

| Tecnología | Uso |
|---|---|
| C# | Lenguaje principal |
| .NET 10 | Plataforma de ejecución |
| Windows Forms | Interfaz de escritorio |
| MaterialSkin.2 2.3.1 | Componentes y estilos visuales |
| Visual Studio | Entorno recomendado |

## Requisitos

- Windows.
- Visual Studio compatible con .NET 10.
- SDK de .NET 10.
- Carga de trabajo **Desarrollo de escritorio de .NET** instalada en Visual Studio.

## Ejecución

1. Clonar el repositorio.
2. Abrir `Sistema_Biblioteca.slnx` en Visual Studio.
3. Restaurar los paquetes NuGet si Visual Studio no lo hace automáticamente.
4. Compilar la solución.
5. Ejecutar el proyecto `Sistema_Biblioteca`.

También puede compilarse desde una terminal de PowerShell ubicada en la raíz del proyecto:

```powershell
dotnet build
```

## Estructura del proyecto

```text
Sistema-Biblioteca/
├── Vistas/
│   ├── Autenticacion/
│   │   ├── FrmLogin.cs
│   │   └── Contacto/
│   │       └── FrmContacto.cs
│   └── Inicio/
│       ├── FrmInicio.cs
│       └── Paginas/
│           ├── UcLibros.cs
│           └── UcPrestamos.cs
├── resources/
│   ├── logo.png
│   ├── ojo.png
│   └── ojo cerrado.png
├── Program.cs
├── Sistema_Biblioteca.csproj
├── Sistema_Biblioteca.slnx
├── CAMBIOS.md
└── README.md
```

Los archivos `.Designer.cs` y `.resx` asociados a los formularios y controles se encuentran junto a sus archivos principales.

## Flujo de inicio

1. `Program.cs` inicializa la aplicación.
2. Se muestra `FrmLogin` como ventana modal.
3. Si el formulario devuelve `DialogResult.OK`, se abre `FrmInicio`.
4. `FrmInicio` carga inicialmente la vista `UcLibros`.
5. El menú lateral permite cambiar entre las vistas disponibles.

## Organización de nombres

El proyecto utiliza los siguientes prefijos:

- `Frm`: formularios de Windows Forms.
- `Uc`: controles de usuario.
- `pnl`: paneles.
- `lbl`: etiquetas.
- `txt`: campos de texto.
- `btn`: botones.
- `lnk`: enlaces.
- `pic`: controles de imagen.
- `card`: tarjetas visuales.

Consulta [`CAMBIOS.md`](CAMBIOS.md) para ver el detalle de los nombres anteriores y actuales.

## Próximas ampliaciones

- Conectar el proyecto a una base de datos.
- Implementar autenticación real.
- Completar la gestión de libros, autores, editoriales y préstamos.
- Incorporar persistencia y validaciones de datos.
- Añadir pruebas automatizadas.

## Licencia

No se ha definido una licencia para este proyecto.
