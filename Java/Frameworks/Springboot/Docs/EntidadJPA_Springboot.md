<h2 align="left"> Crear entidad con anotaciones JPA para tabla de base de datos </h2>

<h3 align="left"> ¿Qué es una entidad en Java y cómo se asocia con una tabla? </h3>

<p align="left"> Una entidad representa una tabla de la base de datos, mientras que los atributos de la clase corresponden a columnas. Utilizando las anotaciones de JPA, se define:

* Con @Entity se marca la clase para que JPA la reconozca.
* Con @Table(name = "nombre_tabla") se especifica el nombre exacto de la tabla.

Esto facilita que el código refleje fielmente la estructura de la base de datos, incluso cuando el nombre de las columnas esté en español o provenga de esquemas heredados. </p>