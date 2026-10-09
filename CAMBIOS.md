# Registro de nombres y cambios

Este documento resume la reorganización de la interfaz y los nombres utilizados en el proyecto **Sistema de Biblioteca**.

## Estructura actual

| Ubicación | Elemento | Tipo | Función |
|---|---|---|---|
| `Program.cs` | `Program` | Punto de entrada | Inicializa la aplicación y controla el flujo entre el acceso y la ventana principal. |
| `Vistas/Autenticacion/FrmLogin.cs` | `FrmLogin` | Formulario | Solicita el correo y la contraseña del usuario. |
| `Vistas/Autenticacion/Contacto/FrmContacto.cs` | `FrmContacto` | Formulario | Muestra la información de contacto de los desarrolladores. |
| `Vistas/Inicio/FrmInicio.cs` | `FrmInicio` | Formulario | Contiene la ventana principal y el menú lateral. |
| `Vistas/Inicio/Paginas/UcLibros.cs` | `UcLibros` | Control de usuario | Contenedor de la navegación interna de libros. |
| `Vistas/Inicio/Paginas/UcCatalogoLibros.cs` | `UcCatalogoLibros` | Control de usuario | Vista destinada a la gestión o consulta de libros. |
| `Vistas/Inicio/Paginas/UcEditoriales.cs` | `UcEditoriales` | Control de usuario | Vista destinada a la gestión de editoriales. |
| `Vistas/Inicio/Paginas/UcCategorias.cs` | `UcCategorias` | Control de usuario | Vista destinada a la gestión de categorías. |
| `Vistas/Inicio/Paginas/UcAutores.cs` | `UcAutores` | Control de usuario | Vista destinada a la gestión de autores. |
| `Vistas/Inicio/Paginas/UcAyuda.cs` | `UcAyuda` | Control de usuario | Vista de ayuda del sistema. |
| `Vistas/Inicio/Paginas/UcPrestamos.cs` | `UcPrestamos` | Control de usuario | Vista destinada a la gestión o consulta de préstamos. |

Cada formulario o control tiene sus archivos complementarios `.Designer.cs` y `.resx` cuando corresponde.

## Renombrado de carpetas

| Nombre anterior | Nombre actual | Motivo |
|---|---|---|
| `Views` | `Vistas` | Usar español y describir la capa visual. |
| `Views/auth` | `Vistas/Autenticacion` | Identificar la sección de acceso. |
| `Views/auth/Contacto` | `Vistas/Autenticacion/Contacto` | Mantener el contacto dentro de autenticación. |
| `Views/home` | `Vistas/Inicio` | Describir la ventana principal en español. |
| `Views/home/pages` | `Vistas/Inicio/Paginas` | Agrupar las vistas internas de la ventana principal. |

## Renombrado de formularios y controles

### Formularios y controles principales

| Nombre anterior | Nombre actual | Tipo |
|---|---|---|
| `Form1` | `FrmLogin` | Formulario de inicio de sesión |
| `Inicio` | `FrmInicio` | Formulario principal |
| `UcLibros` | `UcLibros` | Control de usuario |
| `UcPrestamos` | `UcPrestamos` | Control de usuario |
| `FrmContacto` | `FrmContacto` | Formulario de contacto |

### Controles de `FrmLogin`

| Nombre anterior | Nombre actual | Función |
|---|---|---|
| `pnlFondoDegradado` | `pnlFondo` | Panel de fondo del formulario. |
| `materialCard1` | `cardLogin` | Tarjeta que contiene el acceso. |
| `materialLabel1` | `lblTituloLogin` | Título del formulario. |
| `txtcorreo` | `txtCorreo` | Campo del correo electrónico. |
| `txtcontraseña` | `txtContrasena` | Campo de la contraseña. |
| `materialButton1` | `btnIngresar` | Botón para validar el acceso. |
| `pictureBox1` | `picLogo` | Imagen del logotipo. |
| `linkLabel1` | `lnkContacto` | Enlace al formulario de contacto. |

### Controles de `FrmInicio`

| Nombre anterior | Nombre actual | Función |
|---|---|---|
| `pnlSidebar` | `pnlBarraLateral` | Panel del menú lateral. |
| `lblMenuTitulo` | `lblTituloMenu` | Título del menú. |
| `lblMenuSubtitulo` | `lblSubtituloMenu` | Descripción del menú. |
| `btnHome` | `btnLibros` | Abre la sección de libros. |
| `btnHelp` | `btnAyuda` | Abre la vista de ayuda. |
| `btnCerrarSesion` | `btnCerrarSesion` | Cierra la sesión actual. |
| `pnlContenido` | `pnlContenido` | Contenedor de las vistas internas. |

### Controles de `UcLibros`

| Nombre actual | Función |
|---|---|
| `pnlNavegacionLibros` | Barra de navegación interna de libros. |
| `btnEditoriales` | Abre la vista de editoriales. |
| `btnCategorias` | Abre la vista de categorías. |
| `btnLibros` | Abre la vista de libros. |
| `btnAutores` | Abre la vista de autores. |
| `pnlContenidoLibros` | Contenedor de las vistas internas de libros. |

## Namespaces actuales

- `Sistema_Biblioteca`
- `Sistema_Biblioteca.Vistas.Autenticacion`
- `Sistema_Biblioteca.Vistas.Autenticacion.Contacto`
- `Sistema_Biblioteca.Vistas.Inicio`
- `Sistema_Biblioteca.Vistas.Inicio.Paginas`

## Prefijos utilizados

| Prefijo | Aplicación | Ejemplo |
|---|---|---|
| `Frm` | Formularios | `FrmLogin` |
| `Uc` | Controles de usuario | `UcLibros` |
| `pnl` | Paneles | `pnlContenido` |
| `lbl` | Etiquetas | `lblTituloMenu` |
| `txt` | Campos de texto | `txtCorreo` |
| `btn` | Botones | `btnIngresar` |
| `lnk` | Enlaces | `lnkContacto` |
| `pic` | Imágenes | `picLogo` |
| `card` | Tarjetas visuales | `cardLogin` |

## Ajustes de código

- Se actualizaron los namespaces para reflejar la nueva estructura de carpetas.
- Se actualizaron los `using` y las referencias entre formularios y controles.
- Se actualizaron los constructores para coincidir con los nombres de las clases.
- Se actualizaron los eventos asociados a los controles renombrados.
- Se simplificaron los comentarios para describir brevemente la función del código.
- Se verificó la compilación de la solución después de los cambios.

## Estado de verificación

La solución compila correctamente con el objetivo `net10.0-windows`.
