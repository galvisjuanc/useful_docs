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