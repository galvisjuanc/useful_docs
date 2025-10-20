<h2 align="left"> Relaciones entre clases en Java: asociación, agregación y composición </h2>

<h3 align="left"> ¿Cómo funcionan las asociaciones entre clases en Java?
 </h3>

<p align="left"> La asociación es el vínculo más general. En este caso, una clase utiliza a otra en alguno de sus métodos sin considerarla parte de sus atributos. Son entidades independientes, pero pueden colaborar y trabajar juntas cuando es necesario.

Ejemplo típico: un método de la clase usuario recibe como parámetro una película, pero usuario no guarda internamente ninguna instancia de película.
Las clases no se poseen ni dependen entre sí permanentemente. </p>

<h3 align="left"> ¿Qué diferencia hay entre agregación y composición? </h3>

<p align="left"> La agregación es una relación más fuerte que la asociación. Aquí, una clase contiene a otra como atributo, aunque cada una puede vivir de manera más o menos independiente.

* Por ejemplo, si una plataforma tiene una lista de categorías, estas pueden existir de forma separada e incluso la plataforma funcionaría igual sin ellas.
Si eliminas la clase principal, los elementos agregados pueden seguir teniendo sentido aparte. 

La composición es la relación más estrecha posible entre clases.

* Una clase crea, posee y controla plenamente a otra.
Si la clase principal deja de existir, la contenida también desaparece. Por ejemplo, los créditos de una película solo tienen sentido dentro de esa película y serían eliminados con ella.</p>