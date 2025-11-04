<h2 align="left"> Validación de entrada con enums en Java </h2>

<h3 align="left"> ¿Por qué utilizar enums en Java para atributos como género? </h3>

<p align="left"> Usar enums evita que los usuarios introduzcan valores al azar. Por ejemplo, si el género es texto libre, podrían escribir cualquier palabra, lo que puede causar problemas. Con un enum, definimos una lista fija de géneros como ACCION, COMEDIA, DRAMA, ANIMADA, TERROR, CIENCIA_FICCION, entre otros. Así, el código se vuelve más seguro y legible, ya que solo se aceptan valores válidos. </p>

<h3 align="left"> ¿Cómo se crea un enum en Java? </h3>

<p align="left"> Para definir un enum se debe crear un archivo nuevo con el tipo enum. Por ejemplo, se puede definir de la siguiente manera:

    public enum Genero {
        ACCION,
        COMEDIA,
        DRAMA,
        ANIMADA,
        TERROR,
        CIENCIA_FICCION
    }

Es recomendable escribir los nombres de los enums en mayúsculas para distinguirlos fácilmente y mantener buenas prácticas. </p>

<h3 align="left"> ¿Cómo se integra el enum en la clase que lo utiliza? </h3>

<p align="left"> En la clase Película, el atributo género deja de ser una cadena y pasa a ser de tipo Genero. Esto implica que, en el constructor y otros métodos relacionados, se debe actualizar la firma y el uso del atributo:

* Ahora el género se recibe o se asigna como un tipo Genero.
* Al buscar una película por género, el método debe aceptar un Genero y comparar usando el método equals. </p>