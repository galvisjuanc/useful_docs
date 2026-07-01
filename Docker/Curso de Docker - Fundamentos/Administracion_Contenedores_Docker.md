<h2> Administración de Contenedores Docker: Comandos y Prácticas Esenciales </h2>

<p align="left"> Dominar la gestión de contenedores es esencial cuando trabajas con Docker, especialmente si ejecutas múltiples instancias de una misma aplicación. Aquí aprenderás los comandos clave para administrar contenedores con confianza y eficiencia, desde su creación hasta la revisión de estadísticas en tiempo real. </p>

<h3> ¿Como crear contenedores con distintos puertos usando Docker? </h3>

<p align="left"> Cuando necesitas varias instancias de una misma imagen en tu sistema Docker, lo crucial es modificar el puerto que utilizan. Esto evita conflictos entre contenedores activos simultáneamente:

* Usar el comando básico:
        
        docker run -it --rm -d -p 8080:número -name nombreImagen aminEspinosa/sitioWeb:1.0
* Cambia el puerto inicial (por ejemplo, de 8080 a 8085) cada vez que vayas a crear una nueva instancia.
* Actualiza el nombre del contenedor correspondiente al puerto elegido para distinguir las instancias claramente.

Al hacer esto correctamente, podrás ejecutar múltiples contenedores simultáneos de una misma imagen sin solapamientos.

<strong> ¿Qué información muestra el comando Docker PS? </strong>

El comando docker ps presenta de forma resumida y práctica información esencial sobre los contenedores activos:

* Container ID: identificador único del contenedor.
* Imagen: nombre de la imagen que se utiliza.
* Estatus: indica "up" si está activo y funcionando sin problemas.
* Puertos: mapeo de puertos del contenedor al entorno local.
* Nombres: identificación dada al contenedor para su manejo interno.

Para ver aún más detalles, puedes complementar el comando con dos opciones adicionales:

* docker ps -a: muestra todos los contenedores creados, incluidos aquellos que ya no están activos.
* docker ps --size: añade una columna adicional mostrando el tamaño real de cada contenedor, útil para control de recursos.
</p>

<h3> ¿Cómo monitorear el consumo de recursos de los contenedores Docker? </h3>

<p align="left"> Observar cómo consumen recursos tus contenedores en ejecución es fundamental para una gestión efectiva. Existen dos maneras prácticas:

<strong> Monitoreo mediante Docker Desktop </strong>

* Ingresa a Docker Desktop y selecciona tu contenedor activo.
* Dirígete a la pestaña "Estadísticas" para ver en tiempo real gráficos sobre:
    * Uso del CPU.
    * Memoria consumida.
    * Actividad de red y discos.

<strong> Comando Docker Stats </strong>

Escribe el comando docker stats en la terminal para obtener un resumen rápido y tabular del consumo de recursos de cada contenedor activo. Esto es especialmente útil para monitorear continuamente el rendimiento desde tu línea de comandos.


    docker stats

Utilizar estas herramientas te proporcionará una excelente visibilidad sobre cómo están operando tus contenedores y permitirá tomar decisiones informadas sobre su gestión eficiente.

<strong> Comandos Docker </strong>

Comandos para contenedores

Crea y ejecuta un contenedor a partir de una imagen, con un nombre personalizado:

    docker run --name <nombre_contenedor> <nombre_imagen>

Ejecutar un contenedor con y publicar un puerto(s) del contenedor al host.

    docker run -p <puerto_host>:<puerto_contenedor> <nombre_imagen>

Ejecutar un contenedor en segundo plano

    docker run -d <nombre_imagen>

Iniciar o detener un contenedor existente:

    docker start|stop <nombre_del_contenedor> (o <id_del_contenedor>)

Eliminar un contenedor detenido:

    docker rm <nombre_del_contenedor>

Abrir un shell dentro de un contenedor en ejecución:

    docker exec -it <nombre_del_contenedor> sh

Obtener y seguir los logs de un contenedor:

    docker logs -f <nombre_contenedor>

Inspeccionar un contenedor en ejecución:

    docker inspect <nombre_del_contenedor> (o <id_del_contenedor>)

Para listar los contenedores actualmente en ejecución:

    docker ps

Listar todos los contenedores docker (en ejecución y parados):

    docker ps --all

Ver las estadísticas de uso de recursos

    docker container stats

</p>