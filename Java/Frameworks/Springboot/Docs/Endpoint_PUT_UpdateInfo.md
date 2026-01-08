<h2 align="left"> Creación de endpoint PUT para actualizar películas en base de datos </h2>

<h3 align="left"> ¿Cómo controlar qué campos pueden modificarse con un endpoint PUT? </h3>

<p align="left"> Permitir la edición parcial evita errores y mantiene la integridad de los datos. Se recomienda crear un UpdateMovieDTO exclusivo para las actualizaciones, que incluya únicamente los campos editables como título, fecha de lanzamiento y calificación (rating).

* El ID y otros valores sensibles como género o duración quedan excluidos del UpdateMovieDTO.
* Usar DTOs separados promueve la seguridad y claridad en la lógica de actualización.
* Copiar la estructura de MovieDTO y modificar los campos según lo necesario facilita la implementación. </p>

<h3 align="left"> ¿Cómo diseñar el controlador para recibir las actualizaciones? </h3>

<p align="left"> La anotación @PutMapping se utiliza para recibir el ID de la película como parte de la URL, y el cuerpo del request incluye el UpdateMovieDTO.

* El ID se captura con la anotación @PathVariable.
* El método controlador recibe ambos valores para identificar correctamente el registro y su información a modificar.
* Esta separación asegura que la actualización se realice sobre la entidad correcta y con datos controlados. </p>

<h3 align="left"> ¿Cómo validar la existencia y actualizar los datos en la base de datos? </h3>

<p align="left">Es fundamental comprobar que el registro existe antes de intentar cualquier cambio.

* Utiliza el repositorio para buscar la entidad por ID con findById.
* Si no existe, retorna null: así evitas intentos de modificar datos inexistentes. 
* Si existe, solo se asignan los nuevos valores permitidos con los métodos set correspondientes (título, release date y rating).
* Se recomienda realizar conversiones de tipos, por ejemplo, de double a BigDecimal usando BigDecimal.valueOf si es necesario.</p>