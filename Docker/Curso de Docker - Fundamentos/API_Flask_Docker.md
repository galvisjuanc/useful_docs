<h2> Despliegue de API Flask en Docker paso a paso </h2>

<p align="left"> En cualquier proyecto de software, manejar eficazmente el back-end es esencial para lograr aplicaciones sólidas y confiables. Una excelente forma de abordar esto es mediante el despliegue de APIs construidas con Python en contenedores de Docker, facilitando consistencia y eficiencia entre diferentes entornos. </p>

<h3> ¿Qué es el back-end y cómo funciona con Python? </h3>

<p align="left"> El back-end es aquella parte del proyecto que gestiona la lógica y el procesamiento de datos en el servidor. Utilizando Python con frameworks como Flask, puedes crear APIs ligeras y efectivas con métodos específicos que devuelven información precisa. Por ejemplo, una API Flask puede contener el método GetMyInfo encargado de ofrecer información estructurada en formato JSON.

Para visualizar el resultado podrás ejecutar un comando simple desde la terminal:

    python -m flask run

Con este comando, la aplicación Flask comienza a ejecutarse localmente. Copiando la IP proporcionada con su respectivo puerto, luego puedes acceder desde un navegador agregando el método específico al final del URL (por ejemplo, /GetMyInfo). De esta forma, obtendrás confirmación visual del correcto funcionamiento de tu API.

<strong> ¿Cómo desplegar una API Python dentro de Docker? </strong>

Cuando deseas asegurar que la aplicación tenga el mismo comportamiento en cualquier ambiente, Docker es una herramienta extremadamente útil. Esto implica crear un Dockerfile para preparar tu aplicación y entorno.

<strong> ¿Qué es un Dockerfile y cómo crearlo para una API Python? </strong>

Un archivo Dockerfile incluye instrucciones específicas usando palabras reservadas que Docker reconoce:

* FROM: Define la imagen base que utilizarás (por ejemplo, python:3.12-alpine3.17).
* WORKDIR: Establece el directorio de trabajo dentro del contenedor (generalmente /app para Python).
* COPY: Transfiere archivos o directorios hacia tu contenedor.
* RUN: Ejecuta comandos dentro del contenedor como instalación de dependencias.
* CMD: Dicta el comando a ejecutar cuando el contenedor inicie.

Aquí un ejemplo basado en la API Python mencionada:

    FROM python:3.12-alpine3.17
    WORKDIR /app
    COPY requirements.txt requirements.txt
    RUN pip install -r requirements.txt
    COPY . .
    CMD ["python", "-m", "flask", "run"]

Cada instrucción sigue una secuencia determinada, esencial para que Docker entienda la estructura y dónde alojar los elementos necesarios para correr tu aplicación.

<strong> ¿Por qué Docker es útil para diferentes proyectos tecnológicos? </strong>

Docker utiliza términos estándar como FROM, WORKDIR, COPY, RUN y CMD, independientemente de la tecnología o plataforma que elijas trabajar. Esto significa que puedes usar estos mismos conceptos aplicados a:

* Herramientas de infraestructura.
* Bases de datos.
* Múltiples lenguajes de programación.

<strong> Comandos del Dockerfile </strong>

Especifica la imagen base desde la cual se construira la imagen:

    FROM image:tag

Establece el directorio de trabajo dentro del contenedor. Las instrucciones siguientes se ejecutarán en este directorio:

    WORKDIR /path/to/workdir

Copia archivos o directorios desde el sistema de archivos local al sistema de archivos del contenedor:

    COPY <local> <remote>

Ejecuta comandos durante la construcción de la imagen. Puedes usarlo para instalar paquetes, configurar el entorno.... :

    RUN command example: RUN npm install

Proporciona el comando predeterminado a ejecutar cuando el contenedor se inicia:

    CMD ["executable", "param1", "param2"] example: CMD ["npm", "run", "dev"]

Informa a Docker que la aplicación dentro del contenedor escuchará en el puerto especificado en tiempo de ejecución:

    EXPOSE port

Establece variables de entorno dentro del contenedor:

    ENV key=value

Crea un punto de montaje para almacenar datos persistentes fuera del contenedor:

    VOLUME ["/data"]

</p>