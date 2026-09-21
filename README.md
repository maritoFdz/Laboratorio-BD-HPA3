# Laboratorio — Sistema de Productos con Base de Datos en C#

📅 Fecha: 21/09/2026

## 📋 Contenido del Repositorio

Este repositorio contiene una aplicación desarrollada en C# con Windows Forms que permite gestionar productos almacenados en una base de datos MySQL.

El sistema implementa las operaciones principales de un CRUD (**Crear, Leer, Actualizar y Eliminar**) para administrar productos. Cada producto contiene un identificador, nombre, precio, cantidad e imagen.

La aplicación utiliza una interfaz gráfica para facilitar el registro y administración de los productos. Los datos almacenados en la base de datos se muestran mediante un `DataGridView`, mientras que los formularios permiten agregar, modificar y eliminar registros.

También se implementa un sistema de validación basado en la interfaz `IValidatorCampo`. A partir de esta interfaz se crean diferentes validadores para comprobar que los campos de texto, números enteros y números decimales tengan valores correctos antes de realizar operaciones sobre la base de datos.

Otro elemento importante del proyecto es el manejo de imágenes. El usuario puede seleccionar una imagen desde el equipo mediante un `OpenFileDialog`. La imagen posteriormente se convierte a un arreglo de bytes (`byte[]`) para poder almacenarla en la base de datos.

## 🛠 Tecnologías Utilizadas

* **Lenguaje:** C#
* **Framework:** .NET 9
* **Tipo de aplicación:** Windows Forms
* **Base de datos:** MySQL
* **Conector:** `MySql.Data`
* **IDE recomendado:** Visual Studio
* **Control de versiones:** Git / GitHub
* **Conceptos aplicados:** Programación orientada a objetos, interfaces, validación de datos, CRUD, conexión a bases de datos, consultas SQL parametrizadas, manejo de imágenes y eventos de Windows Forms.

## 💻 Capturas de Pantalla y Problemas

### Interfaz Principal

* **Sistema de gestión de productos:** Se desarrolla un formulario principal que permite visualizar y administrar los productos almacenados en la base de datos.

  Al iniciar la aplicación, el método `Form1_Load()` llama a `cargarProductos()`, que obtiene los registros mediante la clase `Conexion` y los muestra en el `DataGridView`.

  El formulario configura las columnas para mostrar el ID, producto, precio, cantidad e imagen. Para las imágenes se utiliza un `DataGridViewImageColumn`, configurado para mostrar las fotografías mediante un diseño de tipo `Zoom`.

  <img width="1350" height="722" alt="Interfaz principal del sistema" src="AQUI_COLOCA_LA_CAPTURA_PRINCIPAL" />

* **Consulta y búsqueda de productos:** La aplicación cuenta con un campo de búsqueda que permite filtrar los productos. Cada vez que cambia el contenido de `txtBusqueda`, se ejecuta el evento `txtBusqueda_TextChanged()`, que llama nuevamente a `cargarProductos()` utilizando el texto ingresado como filtro.

  La consulta realizada en `Conexion.GetProductos()` utiliza los parámetros de MySQL para buscar coincidencias en los campos `id`, `nombre`, `precio` y `cantidad`.

  Esto permite consultar los registros sin tener que recargar manualmente la aplicación.

  <img width="1350" height="722" alt="Búsqueda de productos" src="AQUI_COLOCA_LA_CAPTURA_DE_BUSQUEDA" />

* **Registro de productos:** Para agregar un producto se deben introducir el nombre, precio y cantidad. También se puede seleccionar una imagen mediante el control `PictureBox`.

  El método `datosCorrectos()` utiliza una colección de validadores para comprobar cada campo antes de guardar la información.

  El nombre es validado mediante `ValidadorTexto`, el precio mediante `ValidadorDecimal` y la cantidad mediante `ValidadorEntero`.

  Una vez que los datos son considerados válidos, `CargarDatosProductos()` construye un `Dictionary<string, object>` con la información del producto. La imagen seleccionada se convierte mediante `ImageToByteArray()` a un arreglo de bytes.

  Finalmente, `Conexion.InsertSeguro()` ejecuta la operación `INSERT` en la tabla `productos`.

  <img width="1350" height="722" alt="Registro de productos" src="AQUI_COLOCA_LA_CAPTURA_DE_REGISTRO" />

* **Modificación de productos:** Para modificar un producto, primero se debe seleccionar un registro del `DataGridView`. El evento `dgvProductos_CellClick()` obtiene el ID del producto seleccionado y carga sus datos nuevamente en los campos del formulario.

  Al presionar el botón de modificar, se verifica que exista un producto seleccionado y que los datos introducidos sean válidos.

  Posteriormente, `Conexion.UpdateSeguro()` ejecuta una consulta `UPDATE` sobre la tabla `productos`, utilizando el ID seleccionado para determinar qué registro debe modificarse.

  Después de una modificación exitosa, los campos se limpian y el `DataGridView` se actualiza para mostrar la información actualizada.

  <img width="1350" height="722" alt="Modificación de productos" src="AQUI_COLOCA_LA_CAPTURA_DE_MODIFICACION" />

* **Eliminación de productos:** La aplicación permite eliminar productos seleccionados desde el `DataGridView`.

  Antes de realizar la eliminación, el programa comprueba que exista un producto seleccionado y muestra un cuadro de confirmación mediante `MessageBox.Show()`.

  Si el usuario confirma la operación, se llama al método `Conexion.EliminarProducto()`, que ejecuta una consulta `DELETE` utilizando el ID del producto como parámetro.

  Después de eliminar el registro, se limpian los campos y se vuelve a cargar la información de la base de datos.

  <img width="1350" height="722" alt="Eliminación de productos" src="AQUI_COLOCA_LA_CAPTURA_DE_ELIMINACION" />

### Conexión con la Base de Datos

La clase `Conexion` concentra las operaciones relacionadas con MySQL.

El método `ObtenerConexion()` crea una instancia de `MySqlConnection` y abre la conexión utilizando la cadena de conexión configurada para la base de datos `productosdb`.

El método `GetProductos()` realiza las consultas `SELECT` y transforma cada registro obtenido en un objeto de tipo `Producto`. Los datos de la imagen se recuperan como `byte[]`.

Para las operaciones de escritura se utilizan los métodos `InsertSeguro()`, `UpdateSeguro()` y `EliminarProducto()`.

Las consultas de inserción y actualización utilizan parámetros como `@nombre`, `@precio`, `@cantidad` y `@id`, evitando colocar directamente los valores introducidos por el usuario dentro de las consultas SQL.

La conexión y los comandos se manejan mediante bloques `using`, permitiendo liberar correctamente los recursos utilizados.

> **Nota de seguridad:** En la versión actual del proyecto, la cadena de conexión de MySQL contiene las credenciales directamente dentro del código fuente de `Conexion.cs`. Para un proyecto real, se recomienda utilizar variables de entorno, archivos de configuración protegidos o un sistema de gestión de secretos, evitando publicar contraseñas dentro del repositorio.

### Modelo de Producto

La clase `Producto` representa la información almacenada para cada producto.

Contiene las siguientes propiedades:

* `Id`: identificador numérico del producto.
* `Nombre`: nombre del producto.
* `Precio`: precio del producto utilizando el tipo `decimal`.
* `Cantidad`: cantidad disponible utilizando el tipo `int`.
* `Imagen`: arreglo de bytes que representa la imagen almacenada.

Esta clase funciona como modelo de datos utilizado para transportar la información entre la interfaz gráfica y la capa de acceso a datos.

### Sistema de Validación

El proyecto utiliza la interfaz `IValidatorCampo` para establecer una estructura común para los validadores.

La interfaz define el método:

```csharp
bool EsValido(string? valor);
```

y la propiedad:

```csharp
string MensajeError { get; }
```

A partir de esta interfaz se implementan tres clases:

* `ValidadorTexto`: comprueba que un campo de texto no esté vacío.
* `ValidadorEntero`: comprueba que el valor pueda convertirse a un número entero válido y que no sea negativo.
* `ValidadorDecimal`: comprueba que el valor pueda convertirse a un número decimal válido y que no sea negativo.

El formulario almacena estos validadores en una colección de tuplas y los ejecuta mediante el método `datosCorrectos()`.

Cuando un valor no cumple las condiciones, se utiliza `ErrorProvider` para mostrar el mensaje correspondiente junto al campo que presenta el error.

Este diseño permite separar la lógica de validación de la interfaz gráfica y facilita la reutilización de los validadores.

## 📁 Estructura de Carpetas o Directorios

```text
EjemploSProyBD/
├── Conexion.cs
│   # Conexión con MySQL y operaciones CRUD
│
├── Form1.cs
│   # Lógica del formulario principal
│
├── Form1.Designer.cs
│   # Diseño y configuración de los controles del formulario
│
├── Form1.resx
│   # Recursos del formulario
│
├── Producto.cs
│   # Modelo de datos de los productos
│
├── IValidatorCampo.cs
│   # Interfaz para los validadores
│
├── Validadores.cs
│   # Validadores de texto, entero y decimal
│
├── Program.cs
│   # Punto de entrada de la aplicación
│
├── Icos/
│   ├── add.png
│   ├── clean-code.png
│   ├── delete.png
│   ├── image.png
│   ├── login.png
│   ├── pencil.png
│   └── search.png
│   # Iconos utilizados por la interfaz
│
├── Properties/
│   ├── Resources.resx
│   └── Resources.Designer.cs
│   # Recursos de la aplicación
│
├── EjemploSProyBD.csproj
│   # Configuración del proyecto y dependencia MySql.Data
│
├── EjemploSProyBD.sln
│   # Solución de Visual Studio
│
└── README.md
    # Documentación del proyecto
```

## 🗄️ Estructura de la Base de Datos

La aplicación trabaja con una base de datos MySQL denominada `productosdb`.

La tabla utilizada por el programa se denomina `productos` y contiene los campos necesarios para almacenar la información administrada por la aplicación:

```text
productos
├── id
├── nombre
├── precio
├── cantidad
└── imagen
```

El campo `imagen` permite almacenar la imagen del producto como información binaria, que posteriormente es convertida nuevamente a un objeto `Image` para visualizarla en Windows Forms.

## ▶️ Instrucciones de Ejecución / Uso

1. Descargar o clonar el repositorio del proyecto.

2. Abrir el archivo de solución `EjemploSProyBD.sln` mediante **Visual Studio**.

3. Verificar que se encuentre instalado:

```text
.NET 9
MySQL Server
Visual Studio con soporte para Windows Forms
```

4. Crear en MySQL la base de datos utilizada por el proyecto:

```sql
CREATE DATABASE productosdb;
```

5. Crear la tabla `productos` con los campos correspondientes al modelo utilizado por la aplicación:

```sql
CREATE TABLE productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    cantidad INT NOT NULL,
    imagen LONGBLOB
);
```

6. Configurar la conexión de la aplicación para que utilice las credenciales correspondientes a la instalación local de MySQL. Por seguridad, las credenciales no deben publicarse directamente en un repositorio público.

7. Restaurar las dependencias del proyecto. El proyecto utiliza el paquete `MySql.Data`.

8. Compilar la solución desde Visual Studio.

9. Ejecutar el proyecto. Al iniciar, la aplicación cargará automáticamente los productos almacenados en la tabla `productos`.

10. Para registrar un producto, completar los campos de nombre, precio y cantidad. Opcionalmente, seleccionar una imagen y presionar el botón de guardar.

11. Para buscar un producto, escribir el texto correspondiente en el campo de búsqueda. La lista se actualizará automáticamente.

12. Para modificar un producto, seleccionarlo desde el `DataGridView`, modificar los datos necesarios y presionar el botón de modificación.

13. Para eliminar un producto, seleccionarlo y utilizar el botón de eliminación. El sistema solicitará confirmación antes de realizar la operación.

14. El botón de limpiar permite borrar los datos introducidos en el formulario y cancelar la selección actual.

15. El botón de salir cierra la aplicación.

## 🔄 Funcionamiento General

El flujo principal de la aplicación puede resumirse de la siguiente manera:

```text
Usuario
   │
   ▼
Formulario Windows Forms
   │
   ├── Validación de datos
   │       │
   │       ▼
   │   IValidatorCampo
   │       │
   │       ├── ValidadorTexto
   │       ├── ValidadorEntero
   │       └── ValidadorDecimal
   │
   ▼
Clase Conexion
   │
   ├── SELECT ──► Consultar productos
   ├── INSERT ──► Registrar producto
   ├── UPDATE ──► Modificar producto
   └── DELETE ──► Eliminar producto
   │
   ▼
Base de Datos MySQL
   │
   ▼
Tabla productos
```

## 👤 Autor y Contexto

* **Nombre:** Mario Fernández Morales
* **Institución:** Universidad Tecnológica de Panamá (UTP)
* **Fecha de Realización:** 21/09/2026

## 📚 Referencias

* Documentación oficial de C# — Clases, interfaces y propiedades (Microsoft Learn)
* Documentación oficial de .NET — Windows Forms
* Documentación oficial de MySQL — Consultas SQL y administración de bases de datos
* Documentación de `MySql.Data` — Conexión entre C# y MySQL
* Documentación de Windows Forms — `DataGridView`, `PictureBox`, `OpenFileDialog` y `ErrorProvider`
