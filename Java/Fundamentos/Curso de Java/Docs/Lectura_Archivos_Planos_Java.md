<h2 align="left"> Lectura de archivos planos y conversión a objetos en Java </h2>

<h3 align="left"> ¿Cómo crear y estructurar un archivo plano para Java? </h3>

<p align="left"> El primer paso es crear un archivo plano con extensión TXT en la raíz de tu proyecto. Este archivo reunirá los datos de las películas usando el pipe (|) como separador. Es fundamental entender que algunos campos, como la calificación, pueden estar vacíos, por eso debes prever dobles separadores, especialmente cuando un dato opcional esté ausente. Así, puedes almacenar información como título, duración, categoría, calificación y fecha de estreno de cada película.

* Cada línea del archivo representa un objeto película.
* Usa el pipe (|) como delimitador de cada campo.
* Algunos campos opcionales pueden quedar vacíos, mostrando dobles pipes con espacios entre ellos. </p>