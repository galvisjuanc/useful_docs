<h2 align="left"> Captura de parámetros con @PathVariable en Spring Boot </h2>

<h3 align="left"> ¿Cómo se configuran rutas dinámicas para acceder a una sola película? </h3>

<p align="left"> Las rutas dinámicas en los controladores permiten capturar parámetros directamente desde la URL, facilitando peticiones específicas como obtener una sola película por su identificador único. Al usar @PathVariable, el ID se toma automáticamente del path y se habilita el procesamiento específico del recurso dentro del método definido en el controlador.

* @GetMapping se utiliza para definir la ruta.
* Una estructura típica sería: @GetMapping("/{id}"), donde id es el parámetro dinámico.
* La notación @RequestMapping("/movies") en el controlador estandariza el prefijo de las rutas, manteniendo el código ordenado y fácil de mantener.
* El método asociado recibe el parámetro (ejemplo: long id) directamente desde la URL. </p>

<h3 align="left"> ¿Para qué sirve el método getById en el repositorio y el servicio? </h3>

<p align="left"> La lógica para buscar una película utilizando su identificador implica separar responsabilidades entre controlador, servicio y repositorio, lo que permite mantener el código modular y escalable:

* El repositorio agrega un nuevo método: getById(long id), que retorna un MovieDTO.
* Dentro de la implementación, se usa el método findById de Spring, el cual ya existe y permite buscar por clave primaria. 
* Este método retorna un Optional. Si la película no existe, se puede manejar devolviendo null con orElse(null).
* El siguiente paso es mapear la entidad encontrada a un DTO usando el mapper correspondiente, facilitando la transferencia de datos al cliente.</p>

<h3 align="left"> ¿Cómo responde la API ante consultas específicas y cómo se valida la funcionalidad? </h3>

<p align="left"> Con la ruta dinámica implementada, la API puede:

* Responder a .../movies/{id} con un único recurso, permitiendo consultas como recibir sólo la información de "Interestelar" o "Avengers: Endgame".
* Integrar la prueba de los endpoints mediante herramientas como Postman o directamente desde el navegador, validando que los recursos retornados correspondan con la base de datos.
* La funcionalidad también permite volver a la lista completa simplemente consultando .../movies sin parámetros adicionales.</p>