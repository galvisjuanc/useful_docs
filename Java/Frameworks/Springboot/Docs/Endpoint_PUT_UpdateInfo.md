<h2 align="left"> Creación de endpoint PUT para actualizar películas en base de datos </h2>

<h3 align="left"> ¿Cómo controlar qué campos pueden modificarse con un endpoint PUT? </h3>

<p align="left"> Permitir la edición parcial evita errores y mantiene la integridad de los datos. Se recomienda crear un UpdateMovieDTO exclusivo para las actualizaciones, que incluya únicamente los campos editables como título, fecha de lanzamiento y calificación (rating).

* El ID y otros valores sensibles como género o duración quedan excluidos del UpdateMovieDTO.
* Usar DTOs separados promueve la seguridad y claridad en la lógica de actualización.
* Copiar la estructura de MovieDTO y modificar los campos según lo necesario facilita la implementación. </p>