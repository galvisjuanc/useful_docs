<h2 align="left"> Repositorios CRUD con Spring Data sin escribir SQL </h2>

<h3 align="left"> ¿Cómo se configuran los repositorios para CRUD en Spring Data? </h3>

<p align="left"> Spring Data permite implementar operaciones CRUD extendiendo una interfaz llamada CrudRepository. Solo necesitas indicar el nombre de la entity y el tipo de su clave primaria. Por ejemplo, utilizar CrudRepository<MovieEntity, Long> te da acceso a los métodos esenciales para manipular registros.

* Puedes crear, leer, actualizar y eliminar datos desde Java directamente.
* Spring automáticamente genera e implementa todos los métodos estándar de CRUD.
* No es necesario programar consultas SQL para operaciones sencillas.

La extensión adecuada del repositorio conserva tus entities ordenadas dentro de paquetes, siguiendo la estructura que recomienda Spring para proyectos escalables. </p>