<h2 align="left"> Despliegue de Aplicaciones Frontend con Angular y AWS S3 </h2>

<h3 align="left"> ¿Cómo desplegar un Frontend usando AWS? </h3>

<p align="left"> El despliegue de una aplicación Frontend puede parecer intimidante, pero con las herramientas adecuadas, este proceso se simplifica considerablemente. En esta guía, te mostraremos cómo usar varios servicios de AWS para automatizar el despliegue de tu proyecto Frontend, específicamente uno desarrollado en Angular. Los servicios clave este proceso son AWS CodePipeline, CodeBuild y S3, junto con Bitbucket como sistema de control de versiones. 

<strong> ¿Qué herramientas necesitas? </strong>

Para lograr un despliegue exitoso de una aplicación Frontend, es necesario asegurar que cuentas con ciertos permisos y configuraciones básicas. Aquí te describimos brevemente los elementos esenciales:

* CodePipeline y CodeBuild: Ya deberías tener los permisos necesarios configurados en tu cuenta.
* Bitbucket: Servirá como repositorio de origen del código.
* S3: Servirá como alojamiento para los archivos de tu aplicación Angular.
* ARNs de Roles: Necesitas los ARNs específicos de los roles de CodePipeline y CodeBuild ya existentes.

<strong> ¿Cuál es el flujo de trabajo? </strong>

Para lograr un despliegue exitoso de una aplicación Frontend, es necesario asegurar que cuentas con ciertos permisos y configuraciones básicas. Aquí te describimos brevemente los elementos esenciales:

1. Conexión de repositorio: Comienza obteniendo el código fuente desde Bitbucket.
2. Construcción y empaquetado: Usa CodeBuild para ejecutar el comando npm run build, que compilará el código de Angular.
3. Despliegue: Finalmente, los archivos resultantes serán subidos al bucket S3 de AWS para ser servidos como página web estática. </p>

<h3 align="left"> ¿Qué configuraciones específicas necesita S3? </h3>

<p align="left"> AWS S3 no solo se utiliza como un simple almacenamiento; en este caso, se configurará para actuar como un servidor web. Aquí se destacan dos configuraciones importantes:

* Permisos públicos: Debes asegurarte de que los archivos sean accesibles públicamente para que puedan ser visualizados en un navegador.
* Política de servidor web: Configura la política para que los archivos sean servidos de manera adecuada desde el bucket S3.

<strong> ¿Cómo funcionan CodePipeline y CodeBuild? </strong>

La configuración de CodePipeline involucra varios pasos, entre los cuales destacan:

* CodeStartSourceConnection: Si estás utilizando repositorios de Bitbucket, necesitarás una conexión preconfigurada con ARN.
* Comandos de construcción: A través de BitBuildspec, se deberán instalar las dependencias de Angular y otras herramientas necesarias mediante comandos dentro del archivo buildspec.yml.

<code> version: 0.2
phases:
  install:
    runtime-versions:
      nodejs: 12
    commands:
      - npm install -g @angular/cli
  build:
    commands:
      - npm install
      - npm run build
</code>

<strong> ¿Cómo configurar el pipeline y dónde usar Terraform? </strong>

Terraform es clave en la creación y manejo de recursos en tu cuenta de AWS de forma automatizada. Aquí usarás Terraform para reusar configuraciones existentes como roles y políticas, al crear o modificar un CodePipeline. Su configuración incluirá:

* La fuente (en tu caso, Bitbucket).
* Construcciones y permisos necesarios.
* Configuración para almacenar los resultados en S3. </p>