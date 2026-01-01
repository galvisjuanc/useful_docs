<h2 align="left"> Creación de conversores personalizados en MapStruct para enums y strings </h2>

<h3 align="left"> ¿Cómo manejar conversiones personalizadas en MapStruct para enums y strings? </h3>

<p align="left"> En situaciones donde los tipos de datos del modelo de dominio y del DTO (Data Transfer Object) difieren, como un string en la base de datos que debe convertirse a un enum en la lógica de dominio, MapStruct requiere métodos de conversión personalizados.

* Se crea un enum (por ejemplo, Genre) que defina posibles valores: action, comedy, drama, animated, horror, science fiction.
* El DTO ahora utiliza este enum en vez de un string para mayor control y coherencia.

Esto obliga a adaptar el mapeo, pues los valores guardados en el almacenamiento pueden diferir (por ejemplo, “animada” en la base de datos versus “animated” en el enum). El conversor personalizado soluciona esta diferencia. </p>

<h3 align="left"> ¿Cómo implementar un conversor personalizado para string y enum en Java? </h3>

<p align="left"> El conversor personalizado consta de dos métodos estáticos. Uno convierte de string a enum, y el otro, de enum a string.

* El método stringToGenre recibe el string de la base de datos y retorna el enum correspondiente tomando en cuenta las diferencias de nombres y mayúsculas/minúsculas.
* Utiliza una estructura switch y verifica primero si el string recibido es nulo, en cuyo caso devuelve null.
* Cada valor de string se asigna al valor correcto del enum (por ejemplo, "acción" a action, "animada" a animated). 

El método inverso, genreToString, sigue la misma lógica:

* Recibe un valor enum y devuelve el string que almacena la base de datos.
* También verifica si el valor es nulo y asigna los textos correctos según el caso.

Ambos métodos deben anotarse con @Named de org.mapstruct para que el framework los reconozca y los aplique automáticamente al mapear campos específicos.</p>