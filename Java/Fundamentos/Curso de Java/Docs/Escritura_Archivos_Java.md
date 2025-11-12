<h2 align="left"> Escritura de archivos planos con la API moderna de Java </h2>

<h3 align="left"> ¿Cómo convertir un objeto en línea de texto para archivos planos en Java? </h3>

<p align="left"> Primero, es necesario transformar los datos del objeto en una cadena de texto que conserva el formato de las líneas existentes en el archivo. Para lograrlo, sigue estos pasos:

* Utiliza los métodos get de tu objeto (ejemplo: getTitulo, getDuracion) para obtener los valores requeridos.
* Concaténalos utilizando un separador, comúnmente una coma, asegurando que cada campo quede bien identificado.
* Prefiere el método String.join de la clase String, ya que string.join facilita unir elementos con el separador indicado, haciendo el código más limpio y legible.
* Convierte los valores numéricos o de fecha a texto usando métodos como String.valueOf y toString.

Este método garantiza que la información se escriba en el formato correcto, lista para su almacenamiento en archivos. </p>