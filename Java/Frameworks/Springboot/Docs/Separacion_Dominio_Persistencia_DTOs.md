<h2 align="left"> Separación de dominio y persistencia con DTOs en Java </h2>

<h3 align="left"> ¿Cómo afecta el acoplamiento entre controlador y base de datos el diseño de tu API? </h3>

<p align="left"> Actualmente, el controlador llama directamente al CRUD del Movie Entity, exponiendo la estructura interna de la base de datos. Esto implica varios riesgos:

* Alto acoplamiento: cualquier cambio en la base de datos puede romper la API fácilmente.
* Exposición de datos sensibles o innecesarios: al no filtrar la salida, pueden aparecer campos indeseados.
* Mezcla de idiomas: el endpoint es /movies pero el contenido de la respuesta está en español.

Estos problemas hacen que la API sea difícil de mantener, frágil y dependiente de la estructura interna de la base de datos.  </p>

<h3 align="left"> ¿Por qué es clave separar responsabilidades entre capas en una API? </h3>

<p align="left"> Separar responsabilidades permite que cada parte del sistema cumpla una función clara y focalizada. Dejar fuera la capa de dominio va contra los principios de una buena arquitectura. Con una correcta separación:

* Cada capa conoce solo lo necesario de las demás.
* La evolución de una capa no obliga a reescribir las otras.
* La lógica de dominio es independiente de la infrastructura técnica.

El patrón Data Mapper ayuda a lograr esto separando el modelo de dominio de cómo se expone en la API o se almacena en la base de datos.  </p>

<h3 align="left"> ¿Cómo implementar Movie DTO y Movie Repository siguiendo buenas prácticas? </h3>

<p align="left"> 

1. Definir el Movie DTO (Data Transfer Object):
2. Se crea dentro del paquete domain.dto.
3. Usando Java record se obtiene una clase inmutable adecuada para representar los datos expuestos.
4. Ejemplo de atributos:

    * String title (en inglés, consistente con la API)
    * Integer duration
    * String genre
    * LocalDate releaseDate
    * Double rating  </p>