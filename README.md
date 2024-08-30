**Instrucciones de EmpoyeeManagement**

Tienes dos opciones:

**1. Entrar en la app desplegada en el siguiente enlace: http://www.crisscross.somee.com**

**2. Seguir las indicaciones para ejecutarlo de forma local, para ello nesecitaras de las siguientes herramientas:**
  a. Microsoft Visual studio
  b. Cargas de desarrollo de ASP y componentes de.NET framework 4.8
  c. Base de datos SQL de preferencia (proveida por somee.com en mi caso)
  d. Administrador de base de datos de preferencia (Workbench en mi caso)
  e. Instalar en el proyecto los paquetes de NuGet EntityFramework, JQuery y los varios paquetes de Microsoft.AspNet que podras encontrar en packages.config

- Clona el repositorio en tu dispositivo:
git clone https://github.com/Cristianzote/EmployeeManagement

- Asegurate de que la la connection string "SomeeSqlDbConnection" esté añadida en Web.config en <connectionStrings>.
Puedes usar una base de datos propia creando base de datos SQL y desde tu administrador de base de datos una tabla llamada "EMPLOYEE" con los atributos del modelo "Employee" y reemplar la connection string.

- Con esto, desde Microsoft Visual Studio podras ejecutar y depurar la aplicación haciendo clic en ejecutar (Botón con la flecha verde llena).
