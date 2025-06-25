<h2 align="left"> Despliegue de Aplicaciones Serveless con AWS y Node/Pythonc </h2>

<h3 align="left"> ¿Qué es serverless y cómo se maneja? </h3>

<p align="left"> ¡Hola entusiasta del desarrollo! Si te has preguntado cómo serían las aplicaciones sin la carga de administrar servidores, bienvenido al emocionante mundo de serverless. Aunque el nombre sugiere la ausencia de servidores, en realidad, sí existen. La diferencia radica en que, como desarrollador o empresa, no tienes que gestionarlos. Es la plataforma Cloud la que se encarga de todo esto, permitiéndote centrarte en lo que realmente importa: tu aplicación. </p>

<h3 align="left"> ¿Cómo crear un Padline para aplicaciones serverless? </h3>

<p align="left"> Para implementar aplicaciones serverless, utilizamos un Padline y otros componentes como CodeBuild y Bitbucket, junto con permisos de AWS y un Bucket S3. Estos son utilizados para gestionar los despliegues. Pero para el caso de serverless, añadimos un ingrediente especial a la mezcla: el framework Serverless, diseñado para trabajar con AWS.

Este framework se asemeja a Terraform, solo que está diseñado específicamente para servicios serverless, como las funciones Lambda. Veamos cómo puedes implementar todo esto en unos simples pasos. </p>

<h3 align="left"> ¿Cómo se estructura el archivo Serverless? </h3>

<p align="left"> Cuando desarrollas aplicaciones serverless, un archivo clave es serverless.yaml. Este archivo funciona como la espina dorsal que define todo, desde la infraestructura hasta las funciones a deployar. Si el equipo de infraestructura de tu organización lo gestiona, solo necesitas saber los comandos básicos para lanzar las aplicaciones.

<code># code snippet for serverless.yaml

service: my-awesome-service

provider:
  name: aws
  runtime: nodejs14.x

functions:
  hello:
    handler: handler.hello</code>

 </p>

 <h3 align="left"> ¿Cómo integrar Node.js y Python en serverless? </h3>

<p align="left"> El framework Serverless permite trabajar con múltiples lenguajes, en este caso Node.js y Python. Ambos lenguajes mantienen una estructura similar en sus archivos buildspec.

Para Node:

<code> phases:
  install:
    runtime-versions:
      nodejs: 14
    commands:
      - npm install
      - npm install -g serverless
  build:
    commands:
      - sls deploy </code>

Para Python, además de las etapas estándar de instalación y despliegue, necesitas instalar un plugin adicional:

<code> phases:
  install:
    runtime-versions:
      python: 3.8
    commands:
      - pip install serverless
      - pip install serverless-plugin
  build:
    commands:
      - sls deploy </code>

Notarás que los comandos principales para desplegar son similares, lo que facilita el manejo de distintos lenguajes en un entorno serverless.


 </p>