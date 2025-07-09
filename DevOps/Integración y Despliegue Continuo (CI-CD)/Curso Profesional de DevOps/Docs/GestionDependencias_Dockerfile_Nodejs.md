<h2 align="left"> Gestión de Dependencias y Dockerfile en Node.js </h2>

<p align="left"> En esta clase te vamos a mostrar cómo usar un Dockerfile y manejar las dependecias para tenerlas lock in, siempre instalar una versión que ya usaste y probaste.

* FROM: Busco una imagen de origen y a partir de ahí se monta el container.

* WORKDIR: Es recomendable no correr todo el root. Con esto le decimos a Docker cuál va a ser nuestra carpeta de trabajo.

ADD: Es donde indicamos nuestras dependencias como package.json, hace cache de esa capa para no ejecutarla cada que corramos nuestro contenedor. También sirve para copiar, como lo hacemos en la décima línea.
RUN: le decimos a docker que ejecute un comando. En este caso npm install
EXPOSE: Exponemos el puerto 3000
CMD: Acá le decimos a Docker que ejecute este comando al momento de ejecutar nuestro container. En este caso correrá la aplicación.

dockerignore: es casi igual al gitignore, pero para docker. </p>