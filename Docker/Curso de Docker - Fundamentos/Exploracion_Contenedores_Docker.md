<h2> Exploración de Contenedores Docker y sus Comandos Básicos </h2>

<p align="left"> Docker no solo simplifica la creación de ambientes de desarrollo, también ofrece herramientas poderosas para conocer a fondo sus contenedores. A medida que incrementas tu conocimiento sobre Docker, probablemente te hayas cuestionado si realmente necesitas una máquina virtual para aprender Linux. Muchos contenedores ya incluyen una base esencial de este sistema operativo. </p>

<h3> ¿Cómo examinar el contenido interno de un contenedor Docker? </h3>

<p align="left"> Explorar la estructura interna de un contenedor Docker es esencial para comprender su funcionamiento:

* Usa docker run seguido de comandos específicos (como /bin/bash, sh, ash) para cambiar el comportamiento inicial del contenedor.
* Al ejecutar estos comandos, accedes directamente a las terminales Linux, permitiéndote navegar por sus archivos y directorios internos. 

Por ejemplo, al ejecutar:

    docker run -it imagen Docker /bin/bash

Obtendrás acceso a la estructura Linux interna del contenedor directamente desde la línea de comandos.

<strong> ¿Qué es el archivo "entrypoint" y cómo afecta a los contenedores? </strong>

El archivo docker-entrypoint.sh es crucial, pues es el primer archivo en ejecutarse al desplegar un contenedor:

* Si este archivo falla, el contenedor también dejará de funcionar instantáneamente.
* Puedes observar esta dependencia ejecutando el comando docker ps, que muestra regularmente este archivo en la columna de comandos.

</p>