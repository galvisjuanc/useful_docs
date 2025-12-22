<h2 align="left"> Repositorios CRUD con Spring Data sin escribir SQL </h2>

<h3 align="left"> ¿Cómo se configuran los repositorios para CRUD en Spring Data? </h3>

<p align="left"> Spring Data permite implementar operaciones CRUD extendiendo una interfaz llamada CrudRepository. Solo necesitas indicar el nombre de la entity y el tipo de su clave primaria. Por ejemplo, utilizar CrudRepository<MovieEntity, Long> te da acceso a los métodos esenciales para manipular registros.

* Puedes crear, leer, actualizar y eliminar datos desde Java directamente.
* Spring automáticamente genera e implementa todos los métodos estándar de CRUD.
* No es necesario programar consultas SQL para operaciones sencillas.

La extensión adecuada del repositorio conserva tus entities ordenadas dentro de paquetes, siguiendo la estructura que recomienda Spring para proyectos escalables. </p>

<h3 align="left"> ¿Qué operaciones CRUD están disponibles en el repositorio? </h3>

<p align="left"> Al extender de CrudRepository, obtienes acceso inmediato a métodos útiles como:

* Guardar un registro o una lista completa.
* Buscar por clave primaria.
* Verificar la existencia de un registro por su ID. 
* Obtener todos los registros almacenados.
* Encontrar varios registros por una lista de IDs.
* Contar los registros guardados en la tabla.
* Eliminar por ID o por la entidad completa.

Esto facilita el manejo de datos y permite enfocarse en la lógica de negocio sin distraerse escribiendo SQL. </p>

<h3 align="left"> ¿Cómo se cargan datos iniciales con Data.sql en Spring? </h3>

<p align="left">Para trabajar con ejemplos reales desde el principio, es recomendable cargar datos de prueba con un archivo Data.sql:

* El archivo debe ubicarse en la raíz de la carpeta Resources y llamarse exactamente Data.sql para que Spring lo reconozca.
* Utiliza sentencias insert into para agregar registros; se recomienda utilizar on conflict do nothing para evitar errores por duplicados.
* Si alguna columna o atributo está mal escrita en el archivo o la entidad, se mostrará un error al arrancar la aplicación. Revisa los nombres cuidadosamente.

Además, debes agregar la siguiente configuración en el archivo de propiedades para asegurar que los datos siempre se carguen:

    spring.sql.init.mode=always

Así, cada vez que inicies tu aplicación, Spring revisa si los datos deben inicializarse, pero gracias a on conflict do nothing, no sobrescribe datos ni arroja errores si ya existen.</p>