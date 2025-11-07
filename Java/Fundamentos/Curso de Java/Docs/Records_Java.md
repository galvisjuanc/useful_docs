<h2 align="left"> 
Records para simplificar código inmutable en Java </h2>

<h3 align="left"> ¿Qué es un record en Java y para qué sirve? </h3>

<p align="left"> Los records son ideales para representar datos que no necesitas modificar nunca, evitando muchísimas líneas de código repetido y fomentando buenas prácticas modernas. 

Un record permite definir una clase inmutable de manera sencilla, perfecta para almacenar datos que no deben cambiar. Cuando defines un record, Java genera automáticamente:

* Un constructor con los parámetros especificados.
* Métodos de acceso, similares a getters.
* Los métodos equals, toString y hashCode sin necesidad de escribirlos manualmente. 

Este recurso es especialmente útil para representar objetos "ligeros" o versiones resumidas de una entidad más grande, como una película con solo su título, duración y género. </p>

