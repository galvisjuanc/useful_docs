<h2 align="left"> Creación de conversores personalizados en MapStruct para enums y strings </h2>

<h3 align="left"> ¿Cómo manejar conversiones personalizadas en MapStruct para enums y strings? </h3>

<p align="left"> En situaciones donde los tipos de datos del modelo de dominio y del DTO (Data Transfer Object) difieren, como un string en la base de datos que debe convertirse a un enum en la lógica de dominio, MapStruct requiere métodos de conversión personalizados.

* Se crea un enum (por ejemplo, Genre) que defina posibles valores: action, comedy, drama, animated, horror, science fiction.
* El DTO ahora utiliza este enum en vez de un string para mayor control y coherencia.

Esto obliga a adaptar el mapeo, pues los valores guardados en el almacenamiento pueden diferir (por ejemplo, “animada” en la base de datos versus “animated” en el enum). El conversor personalizado soluciona esta diferencia. </p>