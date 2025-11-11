<h2 align="left"> Lectura de archivos planos y conversión a objetos en Java </h2>

<h3 align="left"> ¿Cómo crear y estructurar un archivo plano para Java? </h3>

<p align="left"> El primer paso es crear un archivo plano con extensión TXT en la raíz de tu proyecto. Este archivo reunirá los datos de las películas usando el pipe (|) como separador. Es fundamental entender que algunos campos, como la calificación, pueden estar vacíos, por eso debes prever dobles separadores, especialmente cuando un dato opcional esté ausente. Así, puedes almacenar información como título, duración, categoría, calificación y fecha de estreno de cada película.

* Cada línea del archivo representa un objeto película.
* Usa el pipe (|) como delimitador de cada campo.
* Algunos campos opcionales pueden quedar vacíos, mostrando dobles pipes con espacios entre ellos. </p>

<h3 align="left"> ¿Cómo se lee un archivo plano en Java de forma segura? </h3>

<p align="left"> Para extraer el contenido de un archivo plano, puedes aprovechar la clase Files del paquete java.nio.file. El método readAllLines devuelve una lista de strings con cada línea del archivo, resultando ideal para procesarlas una a una. Es importante envolver este proceso en bloques try y catch para manejar posibles excepciones, como la ausencia del archivo. Si ocurre una IOException, puedes mostrar un mensaje de error amigable que incluya los detalles técnicos de la excepción.

Pasos clave:

* Recupera la ruta del archivo con Paths.get("contenido.txt").
* Usa Files.readAllLines para obtener las líneas.
* Captura y comunica la excepción usando try-catch. </p>

<h3 align="left"> ¿Cómo transformar datos del archivo en objetos manejables? </h3>

<p align="left"> Una vez obtenidas las líneas, cada una debe dividirse usando el pipe como separador. Esto se logra con split y la expresión "\|" para asegurar que reconoce el carácter especial. Antes de crear el objeto película, valida que el arreglo tenga exactamente cinco elementos, para evitar errores por formatos incorrectos.

* Asigna los campos a variables: título, duración (con Integer.parseInt), género (con Enum.valueOf en mayúsculas), calificación (usa Double.parseDouble pero verifica si está vacía usando isBlank), y la fecha (con LocalDate.parse).
* Si el campo de calificación está vacío, asigna cero por claridad.
* Luego, instancia el objeto y agrégalo a la colección principal. </p>