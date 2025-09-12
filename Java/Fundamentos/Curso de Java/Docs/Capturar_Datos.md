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

<h3> ¿Por qué conviene practicar con Scanner para aprender Java? </h3>

<p align="left"> Scanner ayuda a fortalecer las habilidades básicas, sobre todo al practicar la captura de datos directamente desde la consola.

* Permite pedir varios tipos de datos, como nombres y números.
* Es útil para crear ejercicios interactivos y preguntas divertidas.
* Motiva a continuar explorando nuevas formas de pedir información.
* Facilita experimentar con mensajes, emojis y personalizaciones en la consola.</p>

<hr>

<h3> 📌 ¿Qué es Scanner? </h3>

<p align="left"> Es una clase de Java que nos permite capturar datos desde la consola, es decir, leer lo que el usuario escribe mientras se ejecuta el programa.

</p>

<p align="left"> 

🧠 nextLine()

* Sirve para leer texto completo (una línea entera).
* Captura todo lo que el usuario escribe hasta que presiona Enter.

🔢 nextInt()

* Sirve para leer números enteros (int) desde la consola.
* Si el usuario escribe otra cosa que no sea un número entero, lanza error.

💬 System.out.println() y System.out.print()

* System.out.print() → imprime sin salto de línea
* System.out.println() → imprime con salto de línea
* Alias común: sout + TAB en IntelliJ o VSCode para autocompletar

</p>