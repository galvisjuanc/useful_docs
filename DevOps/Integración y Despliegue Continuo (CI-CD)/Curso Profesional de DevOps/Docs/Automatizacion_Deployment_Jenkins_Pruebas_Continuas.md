<h2 align="left"> Automatización de Deployments con Jenkins y Pruebas Continuas </h2>

<h3 align="left"> ¿Cómo avanzar de staging a producción de manera segura? </h3>

<p align="left"> El paso de staging a producción es crucial dentro del proceso de despliegue, y es esencial hacerlo con confianza, sobre todo cuando tus pruebas han sido exhaustivas en el entorno de staging. La idea es crear un job en Jenkins que sea casi idéntico al de staging, asegurándote de que todos los parámetros necesarios estén configurados correctamente. </p>

<h3 align="left"> ¿Cómo configurar el nuevo job de producción en Jenkins? </h3>

<p align="left"> En Jenkins, puedes crear un nuevo job copiando el de staging o implementarlo directamente con un Jenkinsfile. La configuración básica incluye:

* Recibir el Artifact ID: Este es un identificador único que usarás en todos tus jobs.
* Limpiar el workspace antes de cada build: Esto asegura que no quede residuo de builds anteriores.
* Asociar el secreto de now token: Necesario si estás desplegando en now, o cualquier otro secreto específico de tu entorno de producción. </p>

<h3 align="left"> ¿Cómo manejar el Artifact en Jenkins? </h3>

<p align="left"> El uso del Artifact es fundamental para la integridad del despliegue:

* Siempre se debe usar el mismo Artifact en todas las cadenas de jobs.
* El Artifact puede ser un archivo Zip, la dirección de un paquete .deb, o la ruta a un repositorio, lo importante es que se mantenga constante y se pase adecuadamente entre los jobs. </p>

<h3 align="left"> ¿Es necesario ejecutar los acceptance tests en producción? </h3>

<p align="left"> ¡Claro que sí! Aunque la infraestructura de staging debería ser casi idéntica a la de producción, hay diferencias inevitables, como en los parámetros de configuración de bases de datos. Por ello, los tests de aceptación deben ejecutarse tanto en staging como en producción para:

* Detectar configuraciones o errores específicos del ambiente de producción.
* Asegurar que el código funciona en todos los ambientes sin problemas.

La ejecución continua de pruebas es parte de la integración continua y refuerza la confianza en el código antes de lanzarlo a producción.</p>