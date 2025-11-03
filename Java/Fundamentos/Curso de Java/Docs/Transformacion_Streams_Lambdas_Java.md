<h2 align="left"> Transformación y ordenamiento de listas con streams en Java </h2>

<h3 align="left"> ¿Cómo transformar listas de objetos en listas de strings usando streams en Java? </h3>

<p align="left"> La función map resulta clave para convertir listas de objetos en listas de otros tipos, como strings. Por ejemplo, si tienes una lista de películas y quieres obtener solo sus títulos, puedes emplear un stream con una lambda que extraiga el título de cada objeto. El resultado será una nueva lista de strings con los títulos extraídos.

* Utiliza stream() sobre la lista original para trabajar en modo funcional.
* Aplica .map(elemento -> elemento.getTitulo()) para transformar cada objeto en su título.
* Puedes simplificarlo usando method reference con Elemento::getTitulo para mayor legibilidad.
* El resultado final lo puedes recoger con .collect(Collectors.toList()), retornando la lista transformada.</p>

<h3 align="left"> ¿Cuál es la forma eficiente de sumar propiedades numéricas en listas con streams? </h3>

<p align="left"> Para calcular, por ejemplo, la duración total de todas las películas de una plataforma, el método mapToInt convierte cada objeto de la lista en un valor entero representando la propiedad deseada (en este caso, la duración). Luego, puedes sumar todos esos valores fácilmente:

* Transforma la lista a stream con .stream().
* Usa .mapToInt(Elemento::getDuracion) para enfocar solo en la propiedad numérica.
* Aplica .sum() para obtener el total sin bucles adicionales ni contadores manuales. </p>