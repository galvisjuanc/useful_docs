<h2 align="left"> Transformación y ordenamiento de listas con streams en Java </h2>

<h3 align="left"> ¿Cómo transformar listas de objetos en listas de strings usando streams en Java? </h3>

<p align="left"> La función map resulta clave para convertir listas de objetos en listas de otros tipos, como strings. Por ejemplo, si tienes una lista de películas y quieres obtener solo sus títulos, puedes emplear un stream con una lambda que extraiga el título de cada objeto. El resultado será una nueva lista de strings con los títulos extraídos.

* Utiliza stream() sobre la lista original para trabajar en modo funcional.
* Aplica .map(elemento -> elemento.getTitulo()) para transformar cada objeto en su título.
* Puedes simplificarlo usando method reference con Elemento::getTitulo para mayor legibilidad.
* El resultado final lo puedes recoger con .collect(Collectors.toList()), retornando la lista transformada.</p>