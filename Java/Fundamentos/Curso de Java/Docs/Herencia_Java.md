<h2 align="left"> Herencia en Java para reutilizar código entre clases relacionadas </h2>

<h3 align="left"> ¿Cómo se utiliza la herencia en Java para unificar el manejo de películas y documentales? </h3>

<p align="left"> La idea central es reemplazar una clase específica, como "película", por una más general, "contenido". De esta forma, tanto las películas como los documentales pueden extender esta clase base y compartir atributos y métodos comunes.

* Clase padre (Contenido): Incluye elementos generales como título, descripción, duración, género, fecha de estreno, calificación y disponibilidad.
* Clases hijas (Película y Documental): Heredan todo lo anterior y pueden agregar elementos propios, como el narrador en el caso de Documental. 

El proceso para migrar hacia esta estructura es el siguiente:

* Renombrar la clase existente: Cambiar "película" por "contenido" tanto en la definición de la clase como en todas sus referencias dentro del código.
* Actualizar constructores y variables: Adaptar los constructores para que reflejen los cambios y permitan que las clases hijas se creen correctamente usando el constructor de la clase padre (super).
* Crear nuevas clases hijas: Definir "Película" y "Documental" extendiendo de la clase "Contenido" y personalizarlas según sus necesidades. </p>

<h3 align="left"> ¿Cómo se agregan atributos y constructores específicos en clases hijas?
 </h3>

<p align="left"> Agregar atributos únicos en las clases hijas permite ampliar la funcionalidad sin perder la estructura común. Por ejemplo, en la clase "Documental":

* Se añade un atributo "narrador", específico de los documentales.
* El constructor primero debe llamar al constructor de la clase padre utilizando la palabra clave super, y luego inicializar el nuevo atributo propio.
* Es útil añadir getters para acceder a los nuevos atributos.

Recomendación clave: Al extender una clase, siempre asegurarse de que el constructor hijo llame al constructor adecuado de la clase base antes de inicializar sus propios atributos. </p>