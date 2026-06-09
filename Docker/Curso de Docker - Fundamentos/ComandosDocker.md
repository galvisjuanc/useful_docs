<h2> Comandos Esenciales de Docker: Uso y documentación </h2>

<p align="left"> Dominar Docker implica conocer tanto su interfaz gráfica (Docker Desktop) como su terminal de comandos. Ambas alternativas ofrecen ventajas específicas, así que es ideal familiarizarse con las dos para aprovechar mejor el potencial de Docker. </p>

<h3> ¿Cómo verificar la versión de Docker instalada? </h3>

<p align="left"> Una acción básica para comprobar nuestra instalación es utilizar la línea de comandos con el comando:


    docker --version

Este comando confirma que Docker está instalado correctamente y muestra la versión actual y el build correspondiente, asegurando que todo esté listo para trabajar sin complicaciones.

<strong> ¿Qué información relevante aporta docker info? </strong> 

Con el comando:

    docker info 

Puedes acceder a detalles importantes sobre el hardware disponible o asignado a Docker en tu sistema. Muestra especificaciones relevantes como la memoria, procesador y GPU disponibles, información útil para decidir futuros ajustes en tu equipo.

<strong> ¿Cuáles son los comandos básicos equivalentes a Docker Desktop? </strong>

Docker Desktop tiene una interfaz visual amigable, pero es fundamental conocer su equivalente en línea de comandos. Estos son algunos ejemplos clave que puedes memorizar:

* Listar imágenes disponibles: docker images
* Ver contenedores activos: docker ps
* Explorar opcionews de comandos específicos con ayuda: docker images --help

Estos comandos ofrecen funcionalidades equivalentes a las categorías gráficas, simplificando el intercambio entre interfaz gráfica y terminal.

<strong> ¿Por qué aprovechar la documentación integrada de Docker? </strong>

Docker facilita una documentación integrada extensa y clara a través del comando docker help o añadiendo --help tras comandos específicos. Es particularmente útil cuando trabajas con comandos complejos como:

* docker build: Crea imágenes a partir de archivos Dockerfile.
* docker run: Ejecuta contenedores a partir de imágenes disponibles.

Ambos comandos tienen múltiples parámetros, pero la documentación proporcionada al utilizar --help facilita enormemente entender cada opción y explicación disponible.

</p>