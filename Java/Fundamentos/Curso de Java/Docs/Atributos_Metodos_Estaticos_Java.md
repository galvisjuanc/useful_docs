<h2 align="left"> Atributos y métodos estáticos en clases utilitarias de Java </h2>

<p align="left"> Un atributo estático pertenece directamente a la clase y no a un objeto individual, por lo que su valor es compartido entre todas las instancias. Lo mismo aplica para los métodos estáticos, los cuales se invocan directamente desde la clase sin crear objetos. </p>

<h3> ¿Cuándo y por qué usar métodos estáticos en clases utilitarias? </h3>

<p align="left">Se usan cuando la funcionalidad no depende del estado de un objeto en particular.

* Ejemplo: métodos para capturar información mediante consola, cálculos matemáticos, o validaciones generales.

Facilitan evitar la duplicación de código, mejorando la legibilidad y mantenimiento. </p>

<h3> ¿Cómo crear una clase utilitaria con métodos estáticos? </h3>

<p align="left">

1. Crear un paquete dedicado a utilidades, por ejemplo, util.
2. Definir una clase, como ScannerUtils, que agrupe funciones para uso común.
3. Implementar un atributo estático para gestionar el escáner y que sea compartido por todos los métodos. 

        public static Scanner scanner = new Scanner(System.in);


4. Crear métodos estáticos para capturar diferentes tipos de datos:

    4.1  Capturar texto: muestra un mensaje y devuelve un String con lo que el usuario escribe.

    4.2 Capturar número entero: obtiene un int, asegurándose de limpiar el salto de línea al final.

    4.3 Capturar número decimal: igual proceso pero utilizando double.

</p>