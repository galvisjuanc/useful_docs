<h2 align="left"> Implementación Continua: Métodos y Estrategias Efectivas </h2>

<p align="left"> Tenemos diferentes maneras de llevar nuestro código a producción. Esta Continuous Delivery y Continuos Deployment, también por supuesto, podemos hacerlo a mano. Esto último no es lo que queremos.

La diferencia entre Continuos Delivery y Continuos Deployment es bastante sencilla, es el mismo proceso, pero en Continuos Deployment se envía a producción automaticamente basado en los resultados de nuestros acceptance tests y en Continuos Delivery podemos hacerlo a mano. 

Ninguna es mejor que otra, todo depende de lo qué estés haciendo al momento y las cosas que estés llevando a producción. Si es algo crítico y no hay seguiridad puedes hacerlo de manera manual.

El concepto final es lanzar a producción más frecuente y tener menos errores, la manera implementada es un detalle. El resultado siempre debería ser menos errores.

Hay varios tipos de Deployments:

* Blue/Green: Tener dos tags del mismo código dándole update a una de ellas mientras la otra sirve el tráfico.
* Canary: Este se puede usar en conjunto con otros tipos. Tenemos un pull de nodos y vamos a implementar algo nuevo pudiendo resultar riesgoso. Solo modifcamos uno de esos nodos.
* Rolling: Es hacerle update a máquinas una por una. Son seguros ya que podemos monitorear el progreso.</p>