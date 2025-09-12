<h2 align="left"> Uso de la clase Scanner para capturar datos por consola en Java </h2>

<p align="left"> Explorar cómo la clase Scanner facilita la interacción entre el usuario y los programas Java es esencial para aprender a capturar datos desde consola. Aunque en entornos profesionales y en grandes aplicaciones suelen preferirse interfaces gráficas o APIs, dominar Scanner resulta ideal para practicar, experimentar y crear prototipos en proyectos sencillos. </p>

<h3> ¿Qué es la clase Scanner y para qué sirve en Java? </h3>

<p align="left"> La clase Scanner es una herramienta que permite leer datos ingresados por el usuario en la consola. Su valor está en la simplicidad para practicar conceptos clave y lograr que cualquier programa Java reciba información de manera amigable.

* Es perfecta para practicar ideas y hacer pruebas rápidas.
* Facilita el aprendizaje, ya que su uso es sencillo e inmediato.
* Resulta funcional para prototipos y ejercicios educativos. </p>

<h3> ¿Cómo se utiliza Scanner para capturar texto y números desde la consola? </h3>

<p align="left"> Al utilizar Scanner, se sigue un patrón fácil de memorizar:

1. Declarar el Scanner: Se crea con new Scanner(System.in). Esto habilita que el programa lea lo que se ingrese por teclado.
2. Solicitar información al usuario: Se muestra un mensaje con System.out.println. Por ejemplo: ¿Cuál es tu nombre?
3. Leer una línea de texto: Usar scanner.nextLine() almacena lo que el usuario escribe como una cadena.
4. Concatenar y mostrar resultados: Se puede unir texto y variables usando el símbolo +. Por ejemplo: Hola seguido del nombre ingresado.
5. Capturar números enteros: Si se necesita almacenar un número, como la edad, basta con usar scanner.nextInt(), asignándolo a una variable de tipo entero. </p>