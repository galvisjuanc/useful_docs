<h2 align="left"> Compilación de aplicación Java para producción con PostgreSQL </h2>

<h3 align="left"> ¿Cómo se crea la base de datos PostgreSQL gratis en Render? </h3>

<p align="left"> Render facilita crear una base de datos PostgreSQL dedicada en la nube.  Primero, selecciona la opción de nueva base de datos desde el dashboard de Render. Debes definir: 

* Nombre de la instancia: Por ejemplo, play_db.
* Usuario y región: Ajusta según tus preferencias, como "Fulanito" y Oregón.
* Versión: Escoge la más reciente, aquí la 16.
* Plan gratuito: Permite hasta 1GB de almacenamiento y caduca en 30 días.</p>

<h3 align="left"> ¿Cómo se crea la base de datos PostgreSQL gratis en Render? </h3>

<p align="left"> Render facilita crear una base de datos PostgreSQL dedicada en la nube.  Primero, selecciona la opción de nueva base de datos desde el dashboard de Render. Debes definir: 

* Nombre de la instancia: Por ejemplo, play_db.
* Usuario y región: Ajusta según tus preferencias, como "Fulanito" y Oregón.
* Versión: Escoge la más reciente, aquí la 16.
* Plan gratuito: Permite hasta 1GB de almacenamiento y caduca en 30 días.

Recuerda que solo se puede tener una base gratuita por cuenta. Eligiendo Render, puedes testear en producción sin costos adicionales en la etapa inicial.

</p>

<h3 align="left"> ¿Qué datos de conexión se utilizan para vincular la app con la base de datos?
 </h3>

<p align="left">Al terminar la creación, Render muestra la información de conexión:

* Usuario, contraseña y nombre de base de datos: Específicos para tu instancia.
* Puerto y URLs: Existen versiones interna y externa; normalmente se usa la externa para desarrollo.
* Formato JDBC: La cadena debe adaptarse conforme a las propiedades requeridas por tu app Java.

La cadena se añade en el archivo de propiedades de producción (por ejemplo, application-prod.properties) y se ajusta el usuario, contraseña y dirección del servidor, reemplazando el clásico localhost por el dominio de Render. </p>

<h3 align="left"> ¿Cómo se configura la app para funcionar en modo producción? </h3>

<p align="left"> En el proyecto Java:

* En el archivo de propiedades, copia la URL y credenciales de la base de datos proporcionadas por Render.
* Elimina configuraciones innecesarias que solo atrasarían la operación en producción, como logs excesivos.
* Establece los perfiles activos para distinguir entre desarrollo y producción, usando la variable spring.profiles.active=producción.
* Actualiza el archivo build.gradle para asignar la versión final de la app. </p>