<h2 align="left"> Implementación Continua: Métodos y Estrategias Efectivas </h2>

<p align="left"> Tenemos diferentes maneras de llevar nuestro código a producción. Esta Continuous Delivery y Continuos Deployment, también por supuesto, podemos hacerlo a mano. Esto último no es lo que queremos.

La diferencia entre Continuos Delivery y Continuos Deployment es bastante sencilla, es el mismo proceso, pero en Continuos Deployment se envía a producción automaticamente basado en los resultados de nuestros acceptance tests y en Continuos Delivery podemos hacerlo a mano. 

Ninguna es mejor que otra, todo depende de lo qué estés haciendo al momento y las cosas que estés llevando a producción. Si es algo crítico y no hay seguiridad puedes hacerlo de manera manual.

El concepto final es lanzar a producción más frecuente y tener menos errores, la manera implementada es un detalle. El resultado siempre debería ser menos errores.

Hay varios tipos de Deployments:

* Blue/Green: Es tener dos stacks corriendo en producción, actualizar uno mientras el otro sirve el tráfico, y cuando la actualización del stack seleccionado termine y todo marche bien, el tráfico es redireccionado a ese stack actualizado, y el otro se vuelve pasivo esperando a por la próxima actualización. Esta es una muy buena práctica debido a que hace "inmutable" el despliegue; pues si hay errores los podremos detectar de forma inmediata y podríamos regresar al stack pasivo, que tiene el despliegue anterior de forma rápida y segura.
* Canary: Puede ser usado en conjunto con otros tipos de deployments. Supongamos tener un set de varios nodos y vamos a desplegar nuevos cambios; en lugar de actualizar todos los nodos al mismo tiempo, o hacerlo uno a uno de forma automatizada, sólo se actualizarían unos cuantos nodos (1/3 o 1/2) y monitoreamos el tráfico para revisar cómo se comportan los nuevos cambios. Si algo sale mal, se revierten los cambios en los nodos afectados y todo vuelve a la normalidad.
* Rolling: Teniendo un set de nodos, el usuario ingresa a cada nodo actualizándolos uno a uno. Este tipo de despliegue es seguro dado que podemos monitorear el progreso del despliegue. Si algo sale mal, podríamos revertir los cambios o excluir los nodos afectados de los nodos que sirven a la plataforma. </p>