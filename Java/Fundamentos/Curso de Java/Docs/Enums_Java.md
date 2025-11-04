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

<h3 align="left"> ¿Cómo se capturan y validan opciones de enums cuando el usuario ingresa datos? </h3>

<p align="left"> Un reto es convertir los datos ingresados por el usuario en un valor del enum. Se usa el método Genero.valueOf() para hacerlo, pero si el texto no coincide exactamente, lanza una excepción. Para evitar errores, se puede crear un método utilitario, por ejemplo capturarGenero, que repite la solicitud hasta recibir una opción válida.

* Se utiliza un ciclo while (true) para solicitar el dato repetidamente.
* El texto del usuario se convierte a mayúsculas antes de validar.
* Si el valor es incorrecto, se informa con un mensaje como "Género no aceptado" y se vuelve a preguntar.

Además, para mejorar la experiencia de usuario, se muestran todas las opciones permitidas antes de la captura, iterando sobre Genero.values() y mostrando los nombres de los géneros disponibles. </p>

<h3 align="left"> ¿Qué ocurre si el usuario ingresa un valor inexistente? </h3>

<p align="left"> Si el usuario intenta buscar o asignar un género que no está en el enum, el sistema muestra un mensaje de error y vuelve a preguntar. Por ejemplo, si escribe "sci-fi" en vez de "CIENCIA_FICCION", verá el mensaje de "Género no aceptado".

El uso de enums se puede extender a otros atributos, como idioma (por ejemplo, ESPANOL, INGLES, ALEMAN) o calidad (por ejemplo, FULLHD, 4K, ESTANDAR). Basta con crear enums nuevos y actualizar la clase y métodos correspondientes para asegurar que siempre se reciban valores permitidos. </p>