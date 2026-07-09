<h2> Redes en Docker: Configuración y gestión eficiente de contenedores </h2>

<p align="left"> Docker ofrece múltiples posibilidades para gestionar redes dentro de nuestros contenedores, permitiendo personalizar la interacción y accesibilidad entre ellos. Conocer cómo configurar correctamente las redes facilita la comunicación interna y externa, además de mejorar significativamente la seguridad mediante mínimos accesos necesarios. </p>

<h3>¿Qué son las redes en Docker y para qué sirven? </h3>

<p align="left"> Las redes en Docker permiten conectar contenedores entre sí y con el entorno externo, otorgando flexibilidad en la comunicación. Cuando ejecutamos el comando docker inspect, podemos acceder a la configuración detallada, donde observamos:

* La IP asignada a cada contenedor.
* Los puertos especificados.
* El tipo de red utilizada, siendo común la opción denominada bridge o puente.</p>