<h2> Creación de Contenedores Web con Docker y Nginx en VS Code </h2>

<p align="left"> Para entender cómo transformar un Dockerfile en un Dockercontainer utilizando Nginx, es importante seguir un flujo claro y simple. Este flujo comienza con la creación de un archivo Dockerfile, para luego utilizar comandos específicos que transformarán este archivo en una imagen Docker lista para desplegarse como un contenedor. </p>

<h3> ¿Cómo se transforma un Dockerfile en contenedor Docker? </h3>

<p align="left"> La transformación del archivo Dockerfile a un Dockercontainer sucede en etapas:

* Dockerfile: Es el punto inicial del proceso.
* Al ejecutar el comando build, este archivo se convierte en una Docker image.
* Finalmente, con el comando docker run, esta imagen se despliega obteniendo un Dockercontainer.

Este contenedor funciona como un ejecutable que permite visualizar diferentes servicios o sitios web correctamente.

<strong> ¿Qué herramientas se necesitan para facilitar el trabajo con Docker? </strong>

Para mejorar la experiencia y claridad al trabajar con Docker, especialmente en VS Code, es relevante:

* Crear un archivo Dockerfile sin extensiones adicionales (por ejemplo, "dockerfile", no "dockerfile.docker").
* Instalar la extensión oficial de Docker proporcionada por Microsoft en VS Code, que ofrece resaltado de sintaxis y facilita la lectura y edición del archivo Dockerfile.

Estas decisiones simplifican la estructura y organización del trabajo realizado con Docker.

<strong> ¿Cómo utilizar Nginx para mostrar una plantilla HTML como un sitio web mediante Docker? </strong>

Para convertir un archivo HTML en un sitio web accesible mediante Docker, es necesario utilizar la imagen oficial de Nginx disponible en Docker Hub, por seguir estos pasos clave:

* Seleccionar la imagen de Nginx: Es importante escoger la imagen oficial del servidor web Nginx desde Docker Hub, ya que este es ampliamente utilizado y facilita considerablemente el despliegue de sitios web.
* Crear la imagen en Dockerfile: Dentro del archivo Dockerfile, se debe agregar la instrucción para obtener la imagen base, escribiendo:

        FROM nginx

    Esto indica que se estará trabajando con la versión más reciente del servidor web Nginx.

* Copiar los archivos HTML dentro de la imagen: Luego de elegir la imagen base, el siguiente paso es copiar los archivos HTML o el contenido del sitio web local hacia la ubicación correspondiente dentro de la estructura de Nginx. Para facilitar el proceso y la memoria, es recomendable escribir la ruta previamente como comentario:

        # /usr/share/nginx/html

    Finalmente, para realizar la copia efectiva del archivo HTML contenido en la carpeta local (por ejemplo, llamada sitio) hacia Nginx, la instrucción será:

        COPY /sitio /usr/share/nginx/html

    Así, todos los archivos HTML copiados en dicha ruta pueden visualizarse automáticamente como un sitio web gracias a las propiedades del servidor Nginx.


</p>