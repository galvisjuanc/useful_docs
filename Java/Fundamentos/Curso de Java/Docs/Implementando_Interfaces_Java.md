<h2 align="left"> Creación e implementación de interfaces en Java </h2>

<h3 align="left"> ¿Qué es una interfaz en Java y para qué sirve? </h3>

<p align="left"> Las interfaces permiten definir un conjunto de métodos que varias clases pueden implementar, independientemente de su jerarquía. Así puedes crear estructuras más versátiles, listas para futuras expansiones sin modificar el código existente.

* Las interfaces se declaran usando la palabra reservada interface después del modificador de acceso.
* Dentro de una interfaz, solo se definen los métodos, sin implementar su lógica (a menos que sea default o static, pero en este caso no se utiliza default).
* Los métodos de una interfaz actúan como contratos: cualquier clase que implemente la interfaz debe definir la lógica de esos métodos. </p>