<h2 align="left"> Crear endpoint POST para guardar películas en Spring Boot </h2>

<h3 align="left"> ¿Cómo funciona el método POST en una API para guardar recursos? </h3>

<p align="left"> El método POST permite recibir información y agregar nuevos recursos en la base de datos. Todo comienza dentro del controlador (MovieController), donde se define un método que: - Responde con un ResponseEntity<MovieDTO>. - Recibe como parámetro un objeto MovieDTO con la anotación @RequestBody para indicar que los datos llegan en el cuerpo de la petición. - Se anota con @PostMapping para asociar la ruta y el verbo HTTP.

Esto habilita la ruta /movies para guardar películas nuevas usando solicitudes POST con datos en formato JSON. </p>

<h3 align="left"> ¿Qué pasos hay que seguir para transformar y guardar los datos recibidos? </h3>

<p align="left"> Para persistir la información recibida es fundamental preparar todos los componentes: 

- El repositorio (CrudMovieEntity) ofrece un método save que requiere una entidad (MovieEntity), no un DTO. 
- Por ello, es necesario crear en el mapper (MovieMapper) una función toEntity, usando @InheritInverseConfiguration de MapStruct, que convierte un MovieDTO en una entidad lista para guardar. 
- El campo especial genre necesita un mapeo adicional usando qualifiedByName, ajustando de stringToGenre a genreToString según el sentido de la conversión. 
- Para asignar el estado por defecto al guardar, se establece manualmente como 'Disponible'. El campo ID no se debe definir, ya que la base de datos lo genera automáticamente.

Después de guardar la entidad, el resultado se transforma nuevamente a DTO para devolverlo al cliente. </p>

<h3 align="left"> ¿Cuál es la forma correcta de responder una creación exitosa? </h3>

<p align="left"> Es una buena práctica responder con el estado HTTP correcto cuando se crea un recurso. Aplicando Spring, puedes hacer esto así: 

- Utilizar ResponseEntity.status(HttpStatus.CREATED) para indicar que se creó algo nuevo. 
- El cuerpo de la respuesta es el DTO que representa la película efectivamente guardada. 
- No es indispensable retornar una URI específica si no está disponible: el enfoque flexible muestra cómo elegir entre soluciones y adaptarlas al flujo deseado.

. </p>