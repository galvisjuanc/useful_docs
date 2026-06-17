<h2> Creación y etiquetado de imágenes Docker desde Dockerfile </h2>

<p align="left"> Crear imágenes en Docker desde un archivo Dockerfile marca un paso esencial y más fluido tras superar la fase inicial de configuración. Si ya tienes listo tu Dockerfile, ahora puedes dar vida a tu aplicación construyendo imágenes que podrás compartir o desplegar en distintos entornos. </p>

<h3> ¿Cómo crear una imagen Docker desde el Dockerfile? </h3>

<p align="left"> La construcción de una imagen Docker se realiza desde la línea de comandos en la misma ubicación donde se encuentra tu archivo Dockerfile. Para confirmarlo, usa el comando básico de Linux ls, que verifica que el archivo esté presente en la carpeta. Luego, ejecuta:

    docker build .

Este comando indica que la creación se hará utilizando los pasos establecidos en tu Dockerfile desde la posición actual. Docker realizará automáticamente cada instrucción detallada dentro del archivo, por ejemplo, descargar una imagen base o copiar archivos específicos.</p>