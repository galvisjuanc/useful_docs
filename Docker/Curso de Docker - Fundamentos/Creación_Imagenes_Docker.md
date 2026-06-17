<h2> Creación y etiquetado de imágenes Docker desde Dockerfile </h2>

<p align="left"> Crear imágenes en Docker desde un archivo Dockerfile marca un paso esencial y más fluido tras superar la fase inicial de configuración. Si ya tienes listo tu Dockerfile, ahora puedes dar vida a tu aplicación construyendo imágenes que podrás compartir o desplegar en distintos entornos. </p>

<h3> ¿Cómo crear una imagen Docker desde el Dockerfile? </h3>

<p align="left"> La construcción de una imagen Docker se realiza desde la línea de comandos en la misma ubicación donde se encuentra tu archivo Dockerfile. Para confirmarlo, usa el comando básico de Linux ls, que verifica que el archivo esté presente en la carpeta. Luego, ejecuta:

    docker build .

Este comando indica que la creación se hará utilizando los pasos establecidos en tu Dockerfile desde la posición actual. Docker realizará automáticamente cada instrucción detallada dentro del archivo, por ejemplo, descargar una imagen base o copiar archivos específicos.

<strong>¿Por qué poner nombre y etiqueta a la imagen Docker? </strong>

Al generar una imagen de la forma más rápida, esta aparece por defecto sin nombre ni etiqueta, mostrando None en ambos espacios. Aunque es posible, no es recomendable, ya que dificulta la identificación y gestión de tus imágenes.

Por lo tanto, es mejor práctica etiquetar explícitamente tus imágenes. Para etiquetar la imagen desde un principio, usa el comando:

    docker build -t sitio_web:latest .

Usando -t, estableces un nombre claro (en este caso "sitio_web") y una etiqueta "latest", que indica la última versión disponible de tu contenido. Esto mejora sustancialmente la administración cuando tienes múltiples versiones o variaciones del mismo sitio o aplicación.

<strong> ¿Cómo eliminar una imagen Docker? </strong>

Si creaste una imagen sin etiqueta o con un nombre incorrecto, puedes eliminarla para mantener tu trabajo ordenado. Utiliza para esto el comando siguiente:

    docker rmi -f <identificador_de_la_imagen>

El parámetro -f representa una eliminación forzada, especialmente útil si existen dependencias involucradas. Tras eliminar, puedes nuevamente recrear tu imagen utilizando el nombre y la etiqueta adecuados.

</p>