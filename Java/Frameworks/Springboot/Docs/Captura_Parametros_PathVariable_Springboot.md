<h2 align="left"> Captura de parámetros con @PathVariable en Spring Boot </h2>

<h3 align="left"> ¿Cómo se configuran rutas dinámicas para acceder a una sola película? </h3>

<p align="left"> Las rutas dinámicas en los controladores permiten capturar parámetros directamente desde la URL, facilitando peticiones específicas como obtener una sola película por su identificador único. Al usar @PathVariable, el ID se toma automáticamente del path y se habilita el procesamiento específico del recurso dentro del método definido en el controlador.

* @GetMapping se utiliza para definir la ruta.
* Una estructura típica sería: @GetMapping("/{id}"), donde id es el parámetro dinámico.
* La notación @RequestMapping("/movies") en el controlador estandariza el prefijo de las rutas, manteniendo el código ordenado y fácil de mantener.
* El método asociado recibe el parámetro (ejemplo: long id) directamente desde la URL. </p>