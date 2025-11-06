<h2 align="left"> Diferencias entre Excepciones Checked y Unchecked en Java </h2>

<h3 align="left"> ¿Cuáles son los tipos de excepciones en Java y cómo se diferencian? </h3>

<p align="left"> En Java, existen dos grandes tipos de excepciones:

* Checked exceptions: Java obliga a controlarlas explícitamente usando try-catch. Ejemplos incluyen IO Exception, FileNotFoundException y ParseException, las cuales pueden ocurrir al leer archivos inexistentes o al interpretar datos incorrectos.

* Unchecked exceptions: No es obligatorio manejarlas, pero pueden causar problemas en tiempo de ejecución si las ignoramos. Algunos ejemplos son NullPointerException, NumberFormatException, IndexOutOfBoundsException y la conocida IllegalArgumentException. </p>