<h2 align="left"> Operador instanceof para identificar tipos de objetos en Java </h2>

<h3 align="left"> ¿Qué es el polimorfismo en programación orientada a objetos? </h3>

<p align="left"> El polimorfismo es el cuarto pilar fundamental de POO. Permite tratar distintos tipos de objetos—como películas y documentales—como si fueran del mismo tipo, siempre y cuando compartan una estructura base o hereden de una clase común (Contenido).

* Puedes poner películas y documentales juntos en una lista de tipo Contenido.
* El sistema luego decide qué lógica aplicar a cada uno según su tipo en tiempo de ejecución.
* Favorece la reutilización de código y la ampliación del sistema con nuevas clases. </p>

<h3 align="left"> ¿Cómo ayuda el operador instanceof a determinar el tipo real de un objeto? </h3>

<p align="left"> El operador instanceof permite, al momento de ejecutar el programa, saber si un objeto es de un tipo específico. Esto es útil cuando se tiene una lista de objetos de tipo base, pero necesitas aplicar lógica exclusiva a, por ejemplo, un documental.

* Permite diferenciar películas de documentales dentro de la misma colección según su tipo real.
* Usando instanceof, es posible adaptar el proceso de guardado y lectura de archivos según el tipo de contenido.
* El patrón pattern variable permite simplificar el uso de instanceof y el casting inmediato.- </p>

<h3 align="left"> Ejemplo práctico dentro de la plataforma </h3>

<p align="left"> 

* Se modifica el guardado de archivos para que cada línea indique el tipo de contenido (película o documental).
* Para documentales, además se almacena el narrador dentro de la línea de datos.
* Al leer el archivo, se valida el tipo con instanceof y se instancia la clase adecuada: new Película o new Documental. </p>