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
* Eliminar por ID o por la entidad completa.</p>