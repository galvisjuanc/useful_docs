<h2 align="left"> Escritura de archivos planos con la API moderna de Java </h2>

<h3 align="left"> ¿Cómo convertir un objeto en línea de texto para archivos planos en Java? </h3>

<p align="left"> Primero, es necesario transformar los datos del objeto en una cadena de texto que conserva el formato de las líneas existentes en el archivo. Para lograrlo, sigue estos pasos:

* Utiliza los métodos get de tu objeto (ejemplo: getTitulo, getDuracion) para obtener los valores requeridos.
* Concaténalos utilizando un separador, comúnmente una coma, asegurando que cada campo quede bien identificado.
* Prefiere el método String.join de la clase String, ya que string.join facilita unir elementos con el separador indicado, haciendo el código más limpio y legible.
* Convierte los valores numéricos o de fecha a texto usando métodos como String.valueOf y toString.

Este método garantiza que la información se escriba en el formato correcto, lista para su almacenamiento en archivos. </p>

<h3 align="left"> ¿Cómo escribir una nueva línea en el archivo plano utilizando Java? </h3>

<p align="left"> Con la línea de texto lista, puedes escribir datos en el archivo empleando la clase Files de la API moderna (java.nio.file). Los puntos clave son:

* Utiliza el método Files.writeString para escribir la cadena en el archivo deseado.
* Especifica el path del archivo con Paths.get(nombreArchivo).
* Añade al final de la línea el System.lineSeparator para garantizar que cada contenido nuevo empiece en una línea distinta, sin importar el sistema operativo.
* Incluye opciones estándar:
* StandardOpenOption.CREATE crea el archivo si no existe.
* StandardOpenOption.APPEND añade la línea al final, evitando sobrescribir el contenido anterior.
* Envuelve todo el proceso en un bloque try-catch para manejar posibles errores e informar mensajes claros en caso de fallos.

Al aplicar estos pasos, cualquier elemento nuevo, como una película, se integra sin afectar los datos ya existentes y respetando el formato requerido. </p>