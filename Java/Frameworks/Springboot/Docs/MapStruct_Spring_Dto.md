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

<h3 align="left">¿Cómo se define y configura el mapper con Mapstruct? </h3>

<p align="left">Al construir el mapeador personalizado:

* Crear una interfaz MovieMapper en el paquete persistence.mapper, anotada con @Mapper(componentModel = "spring").
* Definir métodos usando reglas con @Mapping, especificando claramente el campo de origen (source) y de destino (target).
    * Por ejemplo:
        * source: título, target: title.
        * source: duración, target: duration
        * y así sucesivamente para género, fecha de estreno y clasificación.
* Para omitir campos innecesarios como estado o ID, simplemente no se declaran en las reglas.
* El mapper puede aceptar tanto un solo objeto como listas o iterables, lo que flexibiliza el uso en el repositorio.  </p>

<h3 align="left"> ¿Cómo se inyecta y utiliza el mapper en el repositorio? </h3>

<p align="left"> El MovieMapper se inyecta en el repositorio y se usa directamente en el método getAll para convertir la lista que regresa el CRUD, asegurando que se devuelvan DTOs a las capas superiores. Todo el proceso es transparente:

* El método utiliza this.movieMapper.toDTO sobre el resultado de this.crudmoviedentity.findall.
* El resultado es una respuesta orientada al dominio, fácil de usar en la aplicación o exponer vía API. </p>

<h3 align="left"> ¿Qué limitaciones tiene Mapstruct y cómo abordarlas? </h3>

<p align="left"> Aunque Mapstruct hace muy sencillo el mapeo automático, hay escenarios donde se requiere más control:

* Para tipos de datos no compatibles, como pasar de Boolean a string o de string a enum.
* Se recomienda crear conversores personalizados para estos casos, aprovechando la extensibilidad de Mapstruct. </p>