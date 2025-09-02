<h2 align="left"> Gestión de Logs y Seguimiento de Excepciones en Producción </h2>

<p align="left"> Los niveles en los logs son sumamente importantes, y también el definirlos correctamente.

También es sumamente importante manejar los logs con una estructura que pueda ser parseada. De esta manera, si tenemos que estudiar un bloque gigante de logs de errores, podríamos utilizar un sistema de logs o desarrollar un script que procese esa información. 

Un Exception es un error que no está manejado en nuestro código. Si esto llega a ocurrir en nuestro servicio, debería ir a un Bucket diferente; debería ir en la pila de logs, pero también debe tener un espacio especial en algún lado (crear un issue en GitHub, crear un Slack alert, etc) con el fin de llamar nuestra atención para que podamos atenderlo y resolverlo lo más rápido posible, aunque no cause downtime. Esto es Exception tracking.

</p>