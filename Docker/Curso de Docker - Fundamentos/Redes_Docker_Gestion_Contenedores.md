<h2> Redes en Docker: Configuración y gestión eficiente de contenedores </h2>

<p align="left"> Docker ofrece múltiples posibilidades para gestionar redes dentro de nuestros contenedores, permitiendo personalizar la interacción y accesibilidad entre ellos. Conocer cómo configurar correctamente las redes facilita la comunicación interna y externa, además de mejorar significativamente la seguridad mediante mínimos accesos necesarios. </p>

<h3>¿Qué son las redes en Docker y para qué sirven? </h3>

<p align="left"> Las redes en Docker permiten conectar contenedores entre sí y con el entorno externo, otorgando flexibilidad en la comunicación. Cuando ejecutamos el comando docker inspect, podemos acceder a la configuración detallada, donde observamos:

* La IP asignada a cada contenedor.
* Los puertos especificados.
* El tipo de red utilizada, siendo común la opción denominada bridge o puente.

<strong> ¿Cómo asignar una IP específica a un contenedor? </strong>

Para asignar una dirección IP específica al contenedor, incluimos esta IP entre el parámetro -p y el puerto al ejecutar el comando docker run. Por ejemplo:

    docker run -p 127.0.0.1:8080:80 nombre_contenedor

Al hacerlo, Docker utilizará la IP indicada (en este caso, localhost). Este proceso es esencial para una correcta orquestación de contenedores y evitar conflictos en la administración de redes.

<strong> ¿Qué tipos de redes se pueden utilizar en Docker? </strong>

Docker ofrece diferentes categorías de redes para atender distintos requisitos:

* Bridge: Red por defecto usada en la mayoría de los casos, permite la interacción entre contenedores y el entorno local.
* Host: Facilita una comunicación exclusiva entre contenedores específicos, aislándolos del resto.
* None: Garantiza el máximo aislamiento donde el contenedor no puede comunicarse con otros vía red.
Además, podemos crear redes personalizadas según las necesidades del proyecto.

</p>