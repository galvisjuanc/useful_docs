<h2 align="left"> Encapsulamiento en Java: Atributos privados y métodos getter y setter </h2>

<p>
El encapsulamiento es un concepto fundamental en la programación orientada a objetos (POO). Permite ocultar o proteger los detalles internos de una clase y controlar cómo se accede a su información. Este enfoque incrementa la seguridad, evita errores y facilita el mantenimiento del código.
</p>

<h3 align="left"> ¿Cómo funciona el encapsulamiento en Java? </h3>

<p align="left"> La memoria se divide esencialmente en stack y heap. El stack almacena valores de tipos de datos primitivos y referencias a objetos, pero nunca los objetos mismos. Su tamaño es fijo durante la ejecución, y si se sobrepasa, ocurre un stack overflow error.

Por otro lado, el heap es donde están los objetos propiamente dichos. Aunque su tamaño inicial se define al arrancar la aplicación, puede cambiar dinámicamente. Si el heap se llena, surge un OutOfMemoryError: Java heap space.

Hay una relación directa entre stack y heap: las referencias viven en el stack y apuntan a los objetos en el heap. Entender esto ayuda a saber por qué ocurren ciertos errores o comportamientos en programas Java.

 </p>