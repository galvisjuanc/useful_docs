<h2 align="left"> Casting de tipos de datos en Java </h2>

<p align="left"> El casting en Java se refiere al proceso de convertir una variable de un tipo de dato a otro. Existen dos modalidades: el casting implícito, que realiza Java automáticamente cuando la conversión es segura, y el casting explícito, que indica al lenguaje que quieres forzar una conversión incluso si puede implicar pérdida de información.  

* El casting es fundamental al mezclar tipos de datos diferentes como int y double.
* Es común cuando recibimos datos como texto y necesitamos tratarlos numéricamente. </p>

<h3> ¿Cómo funciona el casting implícito en Java? </h3>

<p align="left">El casting implícito ocurre cuando Java puede garantizar que la conversión es segura, como pasar de un tipo de dato pequeño a uno más grande.

Por ejemplo, si tienes una variable de tipo int y la asignas a un long, Java lo permite sin problemas porque long puede almacenar cualquier valor entero.

    int duracion = 120;
    long duracionLong = duracion;
    System.out.println("Duración long: " + duracionLong); // Imprime: Duración long: 120
    
No es necesario indicar nada adicional, Java entiende que el valor cabe perfectamente y realiza la conversión automáticamente. </p>