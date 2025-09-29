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

<h3> ¿Cuándo debe usarse el casting explícito y qué riesgos implica? </h3>

<p align="left">El casting explícito es necesario cuando convertimos de un tipo más grande o más preciso a uno más pequeño, como de double a int o de long a int. Aquí es posible perder información, por lo que Java solicita que el programador especifique la conversión.

Por ejemplo, convertir un número decimal (double) a entero:

    double calificacion = 4.7;
    int calificacionEntera = (int) calificacion;
    System.out.println("Calificación entera: " + calificacionEntera); // Imprime: Calificación entera: 4

Se pierde el valor decimal (.7) y la variable queda con el valor entero (4).

Al castear de long a int, hay que tener cuidado con los valores demasiado grandes. Si el valor sobrepasa la capacidad del tipo más pequeño, el resultado será un número inesperado o negativo.

 </p>

 <h3> ¿Cómo convertir un string a número en Java? ¿Qué método se utiliza? </h3>

<p align="left"> Una práctica frecuente es transformar datos tipo texto a tipo numérico. Java ofrece métodos en las clases envoltorio para lograr esto.

Por ejemplo, usando el método parseLong de la clase Long para convertir un string a long:

    String textoNumeroPremios = "25";
    long numeroPremios = Long.parseLong(textoNumeroPremios);
    System.out.println("Número de premios: " + numeroPremios); // Imprime: Número de premios: 25

Si necesitas ese valor como int, puedes hacer un casteo explícito si estás seguro de que el valor está dentro del rango permitido:

    int numeroPremiosEntero = (int) numeroPremios;
    System.out.println("Número de premios entero: " + numeroPremiosEntero);

Sin embargo, si el texto original fuera un número mayor al rango de int, como "25000000000", este proceso fallará y obtendrás valores negativos o erróneos debido a las limitaciones de cada tipo de dato.

 </p>

<h3> ¿Qué riesgos existen al castear números grandes en Java? </h3>

<p align="left"> La conversión de un tipo más grande como long a uno más pequeño como int puede causar problemas si el número excede la capacidad máxima del destino.

* Por ejemplo, intentar guardar 25 000 000 000 (veinticinco mil millones) en un int generará un valor negativo o muy diferente del esperado.
* Cada tipo de dato tiene un rango específico que no debe ser excedido.

Antes de hacer estos casteos, evalúa siempre los límites de cada tipo de dato en Java para evitar pérdidas o resultados incorrectos en tus programas.

 </p>

<hr>

<h3> Brief Summary </h3>

<table>
  <tr>
    <th>DATA TYPES</th>
    <th>SIZE</th>
    <th>DEFAULT</th>
    <th>EXPLANATION</th>
  </tr>
  <tr>
    <td>boolean</td>
    <td>1 bit</td>
    <td>false</td>
    <td>STores true or false values</td>
  </tr>
  <tr>
    <td>byte</td>
    <td>1 byte / 8 bits</td>
    <td>0</td>
    <td>Stores whole numbers from -128 to 127</td>
  </tr>
  <tr>
    <td>short</td>
    <td>2 byte / 16 bits</td>
    <td>0</td>
    <td>Stores whole numbers from -32768 to 32767</td>
  </tr>
  <tr>
    <td>int</td>
    <td>4 byte / 32 bits</td>
    <td>0</td>
    <td>Stores whole numbers from -2,147,483,648 to 2,147,483,647</td>
  </tr>
  <tr>
    <td>long</td>
    <td>8 byte / 64 bits</td>
    <td>0L</td>
    <td>Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807</td>
  </tr>
  <tr>
    <td>float</td>
    <td>4 byte / 32 bits</td>
    <td>0.0f</td>
    <td>Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits</td>
  </tr>
  <tr>
    <td>double</td>
    <td>8 byte / 64 bits</td>
    <td>0.0d</td>
    <td>Stores fractional numbers. Sufficient for storing 15 decimal digits</td>
  </tr>
  <tr>
    <td>char</td>
    <td>2 byte / 16 bits</td>
    <td>'\u0000'</td>
    <td>Stores a single character/letter or ASCII values</td>
  </tr>
</table>