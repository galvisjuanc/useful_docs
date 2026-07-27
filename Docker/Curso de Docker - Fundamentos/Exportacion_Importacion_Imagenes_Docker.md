<h2> Exportación e importación de imágenes Docker con comandos CLI </h2>

<p align="left"> Vivimos en una época llena de innovaciones tecnológicas, en especial relacionadas con el desarrollo de software y administración de infraestructura. A menudo encontramos situaciones en las que necesitamos transferir imágenes Docker localmente, sin depender de Docker Hub o limitados por conexiones de redes restringidas. Para eso existe: <strong>Docker Save; Docker Load</strong> </p>

<h3> ¿Cuándo y por qué utilizar Docker Save para exportar imágenes? </h3>

<p align="left"> Puede haber ocasiones en las que compartir una imagen Docker a través de redes es complicado o simplemente imposible debido a restricciones organizacionales o limitaciones de ancho de banda. Algunas razones típicas incluyen:

* Protocolos de red en organizaciones que impiden la transferencia de imágenes.
* Ancho de banda insuficiente o demasiado lento.
* Deseo de transferir imágenes utilizando dispositivos externos como memorias USB. 

Con el comando docker save, puedes exportar fácilmente una imagen a un archivo, facilitando su traslado físico:

    docker save AminEspinosa/link3 > link3.rar

Este comando genera un archivo comprimido con todos los componentes de la imagen de Docker listos para transportar y compartir fácilmente.</p>