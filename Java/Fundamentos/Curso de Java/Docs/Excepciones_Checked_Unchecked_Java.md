<h2 align="left"> Diferencias entre Excepciones Checked y Unchecked en Java </h2>

<h3 align="left"> ¿Cuáles son los tipos de excepciones en Java y cómo se diferencian? </h3>

<p align="left"> En Java, existen dos grandes tipos de excepciones:

* Checked exceptions: Java obliga a controlarlas explícitamente usando try-catch. Ejemplos incluyen IO Exception, FileNotFoundException y ParseException, las cuales pueden ocurrir al leer archivos inexistentes o al interpretar datos incorrectos.

* Unchecked exceptions: No es obligatorio manejarlas, pero pueden causar problemas en tiempo de ejecución si las ignoramos. Algunos ejemplos son NullPointerException, NumberFormatException, IndexOutOfBoundsException y la conocida IllegalArgumentException. </p>

<h3 align="left"> ¿Cómo se crea una excepción personalizada en Java? </h3>

<p align="left"> Para crear una excepción propia, debes:

* Crear una nueva clase, en este ejemplo llamada PeliculaExistenteException, dentro de un paquete específico para excepciones.
* Hacer que extienda de RuntimeException, informando a Java que la excepción se lanzará en tiempo de ejecución.
* Definir un constructor que reciba un mensaje útil, normalmente relacionado con el error, y pase ese mensaje a super, para usar la lógica de la clase base.

Esto facilita identificar y controlar situaciones muy concretas en tu aplicación, favoreciendo la claridad del código. </p>

<h3 align="left"> ¿Dónde y cómo lanzar la excepción personalizada? </h3>

<p align="left"> En el escenario explicado, la excepción PeliculaExistenteException se lanza cuando un usuario intenta agregar una película ya existente:

* Antes de añadir el contenido, se valida si ya hay una película con ese título usando un método de búsqueda.
* Si se encuentra una coincidencia, se usa la palabra reservada throw seguida de new PeliculaExistenteException para lanzar el error con el título encontrado.
* El flujo del código se interrumpe tras throw, evitando que el método continúe y la película se agregue otra vez. </p>