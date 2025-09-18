<h2 align="left"> Creación de clases y objetos en Java </h2>

<p align="left"> En Java, los objetos se crean a partir de clases, que son plantillas donde se definen los atributos y comportamientos comunes. Se recomienda agrupar las clases relacionadas en paquetes para mantener el proyecto organizado. Por ejemplo, puedes tener un paquete llamado contenido para clases como Película y otro paquete plataforma para clases como Usuario.

Consejos clave: 
- Nombra las clases con mayúscula inicial y en singular. 
- Evita usar caracteres especiales como "ñ" en nombres de atributos. 
- Agrupa clases por funcionalidad usando paquetes como contenido o plataforma. </p>


<h3> ¿Cuáles son los atributos y métodos básicos de una clase Película? </h3>

<p align="left"> La clase Película se define con atributos públicos que representan características como: 

- Título (String). 
- Descripción (String). 
- Duración (int). 
- Género (String). 
- Año de estreno (int). 
- Calificación (double). 
- Disponible (Boolean), para saber si está activa en la plataforma.

Respecto a los métodos: 
- Reproducir(): imprime el mensaje indicando que se está reproduciendo la película. 
- ObtenerFichaTecnica(): retorna un string con el título, año, género y calificación, separados por saltos de línea utilizando \n para mejorar la presentación. 
- Calificar(double calificación): acepta como parámetro una calificación que se valida para que esté entre 0 y 5, actualizando el atributo solo si es correcto. 
- EsPopular(): retorna si la película es considerada popular con base en su calificación (mayor o igual a 4).

Es buena práctica definir primero los atributos, luego los métodos. Utiliza this para distinguir entre los atributos de clase y los parámetros de métodos cuando tienen el mismo nombre.

</p>