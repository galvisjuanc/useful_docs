<h2 align="left"> Despliegue de Aplicaciones Frontend con Angular y AWS S3 </h2>

<h3 align="left"> ¿Cómo desplegar un Frontend usando AWS? </h3>

<p align="left"> El despliegue de una aplicación Frontend puede parecer intimidante, pero con las herramientas adecuadas, este proceso se simplifica considerablemente. En esta guía, te mostraremos cómo usar varios servicios de AWS para automatizar el despliegue de tu proyecto Frontend, específicamente uno desarrollado en Angular. Los servicios clave este proceso son AWS CodePipeline, CodeBuild y S3, junto con Bitbucket como sistema de control de versiones. </p>

<h3 align="left"> ¿Qué herramientas necesitas? </h3>

<p align="left"> Para lograr un despliegue exitoso de una aplicación Frontend, es necesario asegurar que cuentas con ciertos permisos y configuraciones básicas. Aquí te describimos brevemente los elementos esenciales:

CodePipeline y CodeBuild: Ya deberías tener los permisos necesarios configurados en tu cuenta.
Bitbucket: Servirá como repositorio de origen del código.
S3: Servirá como alojamiento para los archivos de tu aplicación Angular.
ARNs de Roles: Necesitas los ARNs específicos de los roles de CodePipeline y CodeBuild ya existentes. </p>

