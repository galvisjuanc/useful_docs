<h2 align="left"> Cluster </h2>

<h3> ¿Qué son los Clústeres y cómo han evolucionado? </h3>

<p align="left"> Hoy en día, los clusters siguen existiendo, aunque funcionan de manera más eficiente. Para el usuario, parece que trabaja con una sola computadora, pero en realidad, el sistema administra múltiples recursos en segundo plano.

Los dos clusters más conocidos actualmente son:

* Kubernetes
* AWS ECS</p>

<h3> Kubernetes</h3>

<p align="left"> Kubernetes es un "sistema de orquestación de contenedores", esto significa que se encarga de administrar y coordinar contenedores en un entorno. Además, proporciona herramientas y características para implementar, escalar y gestionar aplicaciones contenerizadas de manera eficiente.

Kubernetes es un software libre disponible en casi todas las plataformas en la nube (cloud). También puedes instalarlo en una máquina local. v

Ventajas de Kubernetes
* Al ser de código abierto, cuenta con una gran cantidad de complementos y mejoras creadas por la comunidad.
* Es multicloud, por lo que se puede usar en diferentes proveedores de nube.
* Ofrece dos formas de interacción:
    * Archivos de configuración, donde defines las características y ajustes.
    * CLI (Interfaz de Línea de Comandos), que permite interactuar con el cluster directamente.
    
Cómo funciona Kubernetes

Si observas la arquitectura de Kubernetes, notarás que en el centro hay un servicio principal (representado como una caja azul en los diagramas). Este servicio actúa como intermediario entre el usuario y los recursos disponibles.

* Para interactuar con Kubernetes, utilizas el CLI, enviando comandos específicos.
* Si deseas crear nuevos servicios, utilizas los archivos de configuración.
* No puedes modificar los recursos directamente, sino que siempre debes comunicarte a través de Kubernetes.</p>

<h3> Clúster </h3>

<p align="left"> Conjunto de nodos o máquinas que trabajan juntas como una unidad cohesiva. 

Un clúster de Kubernetes es un grupo de nodos que se utilizan para ejecutar y administrar las aplicaciones en contenedores. Cada nodo en el clúster es una máquina física o virtual que ejecuta el software de Kubernetes y puede alojar uno o varios contenedores. 

Por lo tanto, Kubernetes no es un clúster en sí mismo, sino más bien una plataforma que opera sobre un clúster. Kubernetes se encarga de orquestar los contenedores y administrar los recursos del clúster, como la programación de tareas, la gestión de la escalabilidad, el equilibrio de carga, la recuperación ante fallos, entre otros aspectos.</p>

