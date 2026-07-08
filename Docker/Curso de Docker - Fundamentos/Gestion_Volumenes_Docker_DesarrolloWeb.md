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

Es recomendable utilizar un volumen --> 

* Para proyectos que necesitan ser actualizados con frecuencia o mientras están corriendo.
* En casos de análisis de datos que requieren ingresar continuamente nueva información.

<strong> Resumen </strong>

* Los Volúmenes en Docker son unidades de almacenamiento que actúan como carpetas compartidas bidireccionales entre la máquina anfitriona y un contenedor activo.
* Su propósito principal es establecer un puente de comunicación para facilitar la actualización constante y eficiente de contenidos.
* Permiten que las modificaciones realizadas en el sistema de archivos local se reflejen instantáneamente dentro del contenedor en ejecución.
* Esto es vital para proyectos que requieren actualización continua (como un sitio web activo) sin detener o reconstruir el contenedor.
* La interacción con los volúmenes se realiza exclusivamente con contenedores activos, no con las imágenes base.
* La implementación práctica se realiza con el comando docker run -v, mapeando la ruta local a la ruta del contenedor.
* El comando de ejemplo es docker run -v ./sitio:/usr/share/nginx/html/sitio nginx para montar un sitio web Nginx.
* Los volúmenes difieren del comando COPY del Dockerfile en su naturaleza de persistencia.
* COPY es ideal para proyectos estáticos o para mantener una copia aislada y permanente dentro de la imagen.
* Se recomienda usar Volúmenes para proyectos dinámicos que necesitan ingresar datos continuamente o requieren una modificación mientras están corriendo.

</p>