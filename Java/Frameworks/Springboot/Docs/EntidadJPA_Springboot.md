<h2 align="left"> Crear entidad con anotaciones JPA para tabla de base de datos </h2>

<h3 align="left"> ¿Qué es una entidad en Java y cómo se asocia con una tabla? </h3>

<p align="left"> Una entidad representa una tabla de la base de datos, mientras que los atributos de la clase corresponden a columnas. Utilizando las anotaciones de JPA, se define:

* Con @Entity se marca la clase para que JPA la reconozca.
* Con @Table(name = "nombre_tabla") se especifica el nombre exacto de la tabla.

Esto facilita que el código refleje fielmente la estructura de la base de datos, incluso cuando el nombre de las columnas esté en español o provenga de esquemas heredados. </p>

<h3 align="left"> ¿Cómo se estructura y anota una clase entidad en un proyecto Java? </h3>

<p align="left">El primer paso es crear un paquete entity dentro de tu carpeta de persistencia y una clase, por ejemplo, MovieEntity. Se agregan atributos que coinciden con las columnas esperadas:

* private Long id; como identificador primario.
* private String título; para el nombre de la película.
* private Integer duración; de la película, permitiendo nulos si es necesario.
* private String género; con longitud máxima configurada.
* private LocalDate fechaEstreno; para almacenar día, mes y año.
* private BigDecimal clasificación; respetando precisión y escala para decimales.
* private String estado; para indicar disponibilidad: D/N. 

Mediante anotaciones de columna (@Column) se establecen restricciones y características:

* nullable = false asegura que el campo no sea nulo.
* length o precision y scale limitan la cantidad de caracteres o decimales.
* unique = true garantiza unicidad en valores clave como el título.

La clave primaria se marca como @Id y se genera automáticamente usando @GeneratedValue(strategy = GenerationType.IDENTITY), lo que asegura que el identificador no se repita.

Los getters y setters se pueden generar automáticamente (o con la librería Lombok para mayor simpleza), permitiendo manipular los datos de manera segura y práctica.

</p>

<h3 align="left"> ¿Cómo se crea y sincroniza la tabla desde la configuración de Spring? </h3>

<p align="left"> Si la tabla aún no existe en la base de datos, Spring puede crearla automáticamente para fines de desarrollo y pruebas. En el archivo application-dev.properties, se agregan las siguientes configuraciones:

* spring.jpa.hibernate.ddl-auto=update: actualiza el esquema según sea necesario.
* spring.jpa.show-sql=true: muestra en consola las operaciones SQL que ejecuta la aplicación.
* spring.jpa.properties.hibernate.format_sql=true: formatea el SQL para facilitar la lectura.

Al reiniciar la aplicación, Spring detecta si la tabla está ausente y la crea junto con las restricciones definidas. Si ya existe, no realiza cambios adicionales. Puedes verificar la creación y contenido usando herramientas visuales de base de datos o ejecutando un select sobre la tabla.

</p>