<h2 align="left"> Mapas en Java para contar visualizaciones de películas </h2>

<h3 align="left"> ¿Qué es un mapa en Java y para qué sirve? </h3>

<p align="left"> Un mapa es una estructura de datos de Java que almacena pares de clave-valor. Permite asociar un valor a una clave única, lo cual simplifica la búsqueda y actualización de información. Esto resulta ideal para escenarios donde, como en este caso, se desea llevar el conteo de visualizaciones por película. </p>

<h3 align="left"> ¿Cómo se implementa un contador de visualizaciones usando HashMap? </h3>

<p align="left"> Dentro de la clase plataforma, se crea un atributo tipo map donde la clave es una película y el valor es un contador de visualizaciones de tipo Integer (no primitivo). El mapa se inicializa como new HashMap debido a su relación de herencia con Map, similar a como se usa ArrayList con List.

* Se utiliza el método getOrDefault del mapa para obtener la cantidad de visualizaciones; si la película aún no ha sido vista, retorna cero.
* Al reproducir una película, se muestra un mensaje con la cantidad actual y se incrementa el contador usando put.
* Es importante verificar si la película existe antes de intentar reproducirla y manejar el caso en que no se encuentre dentro del sistema. </p>

<h3 align="left"> ¿Qué prácticas mejoran el método reproducir y el control de visualizaciones? </h3>

<p align="left"> Para mantener un código más limpio y mantenible:

* Se recomienda crear un método auxiliar privado, por ejemplo, contarVisualizacion, que incremente el contador de visualizaciones de una película.
* Esta función puede estar condensada en una sola línea, usando visualizaciones.put y el resultado de getOrDefault, o puede separar el conteo actual en una variable para mayor claridad.
* Emplear this para llamar métodos internos, aunque es opcional, ayuda a clarificar que pertenecen al mismo objeto. </p>

<h3 align="left"> ¿Cómo se prueban las funcionalidades del mapa con ejemplos prácticos? </h3>

<p align="left"> Dentro del método principal, se adiciona una opción para reproducir películas:

* Se solicita el nombre de la película a reproducir, se busca en la plataforma y, si existe, se llama al método correspondiente.
* Al reproducir varias veces una película como "Titanic" o "Interestelar", se observa que el mensaje de visualizaciones refleja correctamente el incremento.
* El sistema notifica si el contenido ingresado no existe. </p>