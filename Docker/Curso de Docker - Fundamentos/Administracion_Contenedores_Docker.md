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

</p>