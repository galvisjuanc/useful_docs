<h2 align="left"> Gestión de memoria en Java: stack, heap y garbage collector </h2>

<h3 align="left"> ¿Cómo utiliza Java la memoria stack y heap para almacenar objetos y referencias?
 </h3>

<p align="left"> La memoria se divide esencialmente en stack y heap. El stack almacena valores de tipos de datos primitivos y referencias a objetos, pero nunca los objetos mismos. Su tamaño es fijo durante la ejecución, y si se sobrepasa, ocurre un stack overflow error.

Por otro lado, el heap es donde están los objetos propiamente dichos. Aunque su tamaño inicial se define al arrancar la aplicación, puede cambiar dinámicamente. Si el heap se llena, surge un OutOfMemoryError: Java heap space.

Hay una relación directa entre stack y heap: las referencias viven en el stack y apuntan a los objetos en el heap. Entender esto ayuda a saber por qué ocurren ciertos errores o comportamientos en programas Java.

 </p>

 <h3 align="left"> ¿Qué diferencia hay entre pasar datos primitivos y objetos en Java? </h3>

<p align="left"> Al asignar tipos primitivos, se copia el valor real, generando variables independientes. Por ejemplo:

* Si cambias el valor a una variable primitiva copiada, la otra no se afecta.

En cambio, cuando asignas variables de tipo objeto, solo se copia la referencia:

* Varias variables pueden apuntar al mismo objeto en el heap.
* Si modificas el objeto a través de cualquier variable, los demás también reflejan ese cambio.

Un experimento práctico mostró que si asignas una variable objeto a otra, ambas apuntan al mismo lugar, y cualquier cambio se ve reflejado siempre. El objeto original se vuelve inaccesible si ninguna variable lo referencia.

 </p>

  <h3 align="left"> ¿Qué sucede cuando un objeto ya no tiene referencias en Java? </h3>

<p align="left">Cuando ningún elemento en el stack apunta a un objeto en el heap, Java lo considera inalcanzable y está listo para ser eliminado. Aquí entra el Garbage Collector:

* Es un proceso automático de Java que elimina objetos no referenciados del heap.
* Se ejecuta en segundo plano y con baja prioridad.
* Java permite invocarlo manualmente, pero se recomienda dejar que la JVM decida cuándo y cómo hacerlo, ya que conoce el mejor momento.

Esta gestión automática evita muchas fugas de memoria y errores por objetos olvidados, facilitando el desarrollo en Java.

 </p>

 