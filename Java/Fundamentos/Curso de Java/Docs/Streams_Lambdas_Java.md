<h2 align="left"> Streams y lambdas para filtrar listas en Java </h2>

<h3 align="left"> ¿Cómo reemplazar el for tradicional usando foreach y lambdas en Java? </h3>

<p align="left"> Muchos desarrolladores aprendieron a iterar sobre listas utilizando el clásico bucle for. Sin embargo, Java provee una opción moderna con el método foreach y las expresiones lambda, que hacen que el código sea más breve y elegante.

* El método foreach pertenece a la interfaz lista y recibe un consumer—una función lambda.
* Con una simple expresión, iteras e imprimes títulos u otros atributos de los objetos en una lista.
* La sintaxis de la lambda (elemento -> operación) encapsula rápidamente la lógica a ejecutar por cada ítem.
* Si la operación contiene una sola línea, no es necesario encerrar el cuerpo con llaves ni usar punto y coma.

Esta alternativa permite dejar atrás el for clásico sin perder claridad y ganando concisión. </p>

<h3 align="left"> ¿Qué son los streams y cómo ayudan a filtrar listas en Java? </h3>

<p align="left"> Streams funcionan como una cinta transportadora sobre una lista, permitiendo aplicar distintos procesos: filtrado, transformación u obtención de elementos.

* Puedes iniciar un stream desde una lista con contenido.stream().
* El método filter permite elegir solo los elementos que cumplen una condición dada por una función lambda.
* Para encontrar un elemento por un atributo (como el título), el filtro compara el campo deseado con el parámetro recibido.
* Si solo necesitas el primer resultado, utiliza findFirst seguido de orElse(null) para manejar casos donde no se encuentre nada.

Es posible recoger el resultado del filtro en una nueva lista usando toList. </p>

<h3 align="left"> ¿Cómo buscar películas por género y mostrar resultados usando streams? </h3>

<p align="left"> El mismo enfoque funcional aplicado para buscar por título puede emplearse para buscar por género.

* Crea un método que recibe el género a buscar y retorna una lista de todos los elementos que cumplen la condición.
* Utiliza el filtro en el stream, esta vez por el campo género, y convierte el resultado en una lista con toList.
* Permite múltiples coincidencias ya que varios elementos pueden compartir el mismo género.
* En el menú, agrega una opción que capture el género, realice la búsqueda y muestre cuántos resultados hubo.
Itera sobre la lista resultante con foreach y una lambda para imprimir la ficha técnica de cada película, agregando un salto de línea para mejor legibilidad. </p>