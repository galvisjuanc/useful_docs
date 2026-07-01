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
</p>