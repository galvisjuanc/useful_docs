<h2> Administración de Contenedores Docker: Comandos y Prácticas Esenciales </h2>

<p align="left"> Dominar la gestión de contenedores es esencial cuando trabajas con Docker, especialmente si ejecutas múltiples instancias de una misma aplicación. Aquí aprenderás los comandos clave para administrar contenedores con confianza y eficiencia, desde su creación hasta la revisión de estadísticas en tiempo real. </p>

<h3> ¿Como crear contenedores con distintos puertos usando Docker? </h3>

<p align="left"> Cuando necesitas varias instancias de una misma imagen en tu sistema Docker, lo crucial es modificar el puerto que utilizan. Esto evita conflictos entre contenedores activos simultáneamente:

* Usar el comando básico:
        
        docker run -it --rm -d -p 8080:número -name nombreImagen aminEspinosa/sitioWeb:1.0
* Cambia el puerto inicial (por ejemplo, de 8080 a 8085) cada vez que vayas a crear una nueva instancia.
* Actualiza el nombre del contenedor correspondiente al puerto elegido para distinguir las instancias claramente.
</p>