<h2> Gestión de Contenedores Docker: Comandos y Docker Desktop </h2>

<p align="left"> Docker facilita enormemente el proceso de desplegar aplicaciones al utilizar imágenes y contenedores. Aunque Docker Desktop es una excelente opción visual para manejo local, usar la línea de comandos se vuelve fundamental al automatizar o llevar proyectos a un entorno productivo. Aquí descubrirás cómo pasar de un entorno gráfico amigable a expresivos comandos útiles en producción. </p>

<h3> ¿Cómo cambiar de Docker Desktop a línea de comandos? </h3>

<p align="left"> Docker Desktop permite correr contenedores fácilmente con solo presionar Play o Run. Aunque útil para desarrollo local, esta opción visual limita la automatización y productividad fuera del entorno de desarrollo.

La alternativa idónea para producciones o automatizaciones está en utilizar comandos específicos como docker run, que además provee información interactiva del contenedor ejecutándose. 

<strong> ¿Qué comandos básicos de Docker debería conocer? </strong>

Antes de ejecutar comandos específicos, conviene verificar imágenes y contenedores disponibles en tu entorno:

* docker images: permite ver imágenes existentes.
* docker ps: muestra contenedores en ejecución actualmente.

Cuando quieras ejecutar un contenedor desde la línea de comandos, puedes usar la siguiente estructura básica:

    docker run -it --rm -d -p 8080:80 --name web sitio_web

Cada parámetro tiene un propósito específico:

* -it: interacción directa con el contenedor para ver logs o mensajes.
* --rm: elimina versiones anteriores del contenedor al terminar.
* -d: ejecuta el contenedor, listo para usarse posteriormente.
* -p: expone puertos y gestiona conexiones entre el host y el contenedor (8080:80 significa que localmente usarás el puerto 8080 y la aplicación exactamente puerto 80).
* --name: asigna un nombre al contenedor para fácil identificación.

</p>