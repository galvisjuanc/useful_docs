<h2> Gestión de Volumenes en Docker para Desarrollo Web </h2>

<p align="left"> Los volúmenes en Docker brindan la posibilidad de compartir información directamente entre el equipo local y un contenedor activo, facilitando la actualización constante y eficiente de contenidos como sitios web o análisis de datos en marcha. Esta herramienta permite reflejar modificaciones instantáneamente sin detener procesos. </p>

<h3> ¿Qué es exactamente un volumen en Docker? </h3>

<p align="left"> Un volumen en Docker es equivalente a una carpeta o unidad compartida entre tu computadora y un contenedor que está en ejecución. Esta función crea un puente de comunicación bidireccional, vital para proyectos que requieren una actualización continua del contenido:

* Cambios en páginas web activas.
* Integración periódica de grandes volúmenes de datos.

Es importante subrayar que esta interacción se realiza exclusivamente con contenedores activos, no con imágenes almacenadas.

<strong> ¿Cómo implementar un volumen en un proyecto sencillo con Docker? </strong>

Una manera práctica es desplegar un sitio web localmente usando el servidor web Nginx. El procedimiento es sencillo:

1. Se crea una carpeta local llamada sitio que contiene archivos HTML y recursos gráficos en assets.
2. En la terminal, se ingresa:

        docker run -v ./sitio:/usr/share/nginx/html/sitio nginx

Con este comando, se comparte directamente el contenido del directorio local sitio dentro del contenedor Docker.

* Al modificar localmente los archivos HTML, como cambiar imágenes en la propiedad src, los cambios aparecen inmediatamente en el navegador web al recargar la página.

<strong> ¿Qué diferencias existen entre copiar y crear volúmenes? </strong>

Existen diferencias claves entre los comandos Docker copy y utilizar volúmenes:

Se debe usar Copy -->

* Proyectos estáticos, sin necesidad frecuente o continua de actualización.
* Cuando deseas mantener una copia permanente y aislada del contenido original dentro de la imagen Docker.

</p>