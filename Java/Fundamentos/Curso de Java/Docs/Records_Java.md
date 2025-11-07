<h2 align="left"> Records para simplificar código inmutable en Java </h2>

<h3 align="left"> ¿Qué es un record en Java y para qué sirve? </h3>

<p align="left"> Los records son ideales para representar datos que no necesitas modificar nunca, evitando muchísimas líneas de código repetido y fomentando buenas prácticas modernas. 

Un record permite definir una clase inmutable de manera sencilla, perfecta para almacenar datos que no deben cambiar. Cuando defines un record, Java genera automáticamente:

* Un constructor con los parámetros especificados.
* Métodos de acceso, similares a getters.
* Los métodos equals, toString y hashCode sin necesidad de escribirlos manualmente. 

Este recurso es especialmente útil para representar objetos "ligeros" o versiones resumidas de una entidad más grande, como una película con solo su título, duración y género. </p>

<h3 align="left"> ¿Cómo se define un record en Java? </h3>

<p align="left"> Al crear un record, el formato es algo especial. Utilizas la palabra record antes del nombre y defines los atributos entre paréntesis, por ejemplo:

    public record ResumenContenido(String titulo, int duracion, String genero) {}

Los atributos pueden escribirse en una sola línea o separados para mayor legibilidad. Solo necesitas declarar los datos esenciales; al ser inmutables, los records no incluyen setters. </p>

<h3 align="left"> ¿Cómo usar records para obtener listas resumidas de datos? </h3>

<p align="left"> Supongamos que ya tienes una clase Pelicula con muchos atributos, pero necesitas una versión simple solo con algunos campos. Puedes crear métodos que devuelvan listas de tu nuevo record a partir de una colección más grande:

* Dentro del método en la clase correspondiente, utiliza un stream para transformar tus datos. 

    Por ejemplo:

        return contenidos.stream()
        .map(c -> new ResumenContenido(c.getTitulo(), c.getDuracion(), c.getGenero()))
        .collect(Collectors.toList());

Así, a partir de una lista de películas completas, generas una lista más ligera. </p>