<h2 align="left"> Configuración de MapStruct con Spring para convertir entidades a DTO </h2>

<h3 align="left"> ¿Qué problema resuelve Mapstruct al convertir entidades en DTO en Java con Spring? </h3>

<p align="left"> Al trabajar en aplicaciones empresariales, suele ser necesario separar las entidades de base de datos (MovieEntity) y los objetos de transferencia de datos (MovieDTO). Usar Mapstruct permite convertir de forma automática y sin esfuerzo manual entre estos dos tipos, logrando:

* Desacoplar la lógica de persistencia de la lógica de dominio y de presentación.
* Evitar errores y simplificar el código al eliminar transformaciones manuales.
* Mantener el código limpio y preparado para cambios futuros en el modelo de datos.  </p>

<h3 align="left"> ¿Cómo se configura Mapstruct en un proyecto Spring con Gradle? </h3>

<p align="left"> Mapstruct se integra fácilmente añadiendo sus dependencias en el archivo build.gradle. Basta agregar la línea de la dependencia principal junto a la del annotation processor recomendado para proyectos Gradle. Ordenar y comentar las dependencias es útil para mantener claridad sobre los paquetes incluidos, como se mostró junto a las de Spring Data JPA.  </p>

<h3 align="left"> ¿Cómo crear un repositorio que devuelva DTO usando Mapstruct? </h3>

<p align="left"> Se crea una clase llamada MovieEntityRepository en la raíz de la capa de persistencia. Sus principales pasos:

* Implementa la interfaz MovieRepository y anota la clase con @Repository para permitir la inyección vía Spring.
* Recibe como dependencia un objeto CRUD y el propio MovieMapper en el constructor.
* Implementa el método getAll, el cual regresa una lista de MovieDTO, no de entidades.  </p>