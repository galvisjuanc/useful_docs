<h2 align="left"> Deployments con Now en Jenkins: Automatiza Staging y Producción </h2>

<h3 align="left"> ¿Qué es Now y cómo nos ayuda con los deployments? </h3>

<p align="left"> Hacer deployments es una de las etapas más emocionantes en el ciclo de desarrollo, y para ello utilizaremos Now. Now facilita el lanzamiento de nuestro código a producción, generándonos una URL nueva cada vez que realizamos un deployment. Esto nos brinda la flexibilidad de tener múltiples deployments bajo diferentes URLs, permitiendo cambiar entre ellos a nivel DNS según lo que considere más adecuado. Aunque el cambio en DNS toma algo de tiempo, es una solución suficiente para los propósitos de este curso. Hermosamente sencillo, ¿no? </p>

<h3 align="left"> ¿Qué es Now y cómo nos ayuda con los deployments? </h3>

<p align="left"> Hacer deployments es una de las etapas más emocionantes en el ciclo de desarrollo, y para ello utilizaremos Now. Now facilita el lanzamiento de nuestro código a producción, generándonos una URL nueva cada vez que realizamos un deployment. Esto nos brinda la flexibilidad de tener múltiples deployments bajo diferentes URLs, permitiendo cambiar entre ellos a nivel DNS según lo que considere más adecuado. Aunque el cambio en DNS toma algo de tiempo, es una solución suficiente para los propósitos de este curso. Hermosamente sencillo, ¿no? </p>

<h3 align="left"> ¿Cómo configurar nuestra cuenta Now? </h3>

<p align="left"> Para utilizar Now en nuestros deployments, el primer paso es configurar nuestra cuenta. Debes:

1. Crear una cuenta en Now.
2. Dirigirte a la sección de configuración de cuenta y generar un nuevo token.
3. Este token será agregado a Jenkins bajo el tipo "Secret Text". Puedes llamarlo "now token" o cualquier nombre que tenga sentido para ti. </p>

<h3 align="left"> ¿Cómo integrar Now en Jenkins? </h3>

<p align="left"> Una vez creado el token, el siguiente paso es integrarlo en Jenkins. Para esto:

1. Accede a Jenkins y ve a la configuración global donde hemos añadido credenciales previamente.
2. Añade un nuevo "secret text" con el nombre de tu elección.
3. Configura nuestras herramientas en Jenkins, asegurando que contamos con NodeJS instalado.
4. Instala el paquete global de Now, para que el binario esté disponible al usar NodeJS en nuestros builds.

Todo esto prepara el camino para crear un build job en Jenkins que se encargará del proceso de deployment. </p>


<h4 align="left"> ¿Cómo configurar un job para deployment en Jenkins? </h4>

<p align="left"> La configuración de un job en Jenkins es clave para automatizar el proceso de deployment. Aquí están los pasos básicos:

1. Crear el job: Llama a tu nuevo job algo como "deployed WebApp staging", donde "WebApp" es el nombre del repositorio y "staging" es el ambiente objetivo.

2. Configurar los parámetros iniciales:
    
    2.1 Acepta un parámetro llamado "Artifact ID", que ya hemos generado previamente.
    2.2 Limpia el workspace antes de empezar. Esta práctica ayuda a evitar conflictos con artefactos anteriores.

3. Añadir credenciales y configuraciones necesarias:

    3.1 Inyecta el now token configurado previamente.
    3.2 Especifica el uso de Node con la versión que incluye Now como paquete global.

4. Ejecutar scripts necesarios:

    4.1 Usar un shell script para ejecutar el deployment.
    4.2 Utilizar now -t token para decirle a Now qué credenciales usar e iniciar el proceso de deployment con un Docker file básico.

Estos pasos nos permiten conectar la línea de producción automáticamente y garantizar que siempre estamos desplegando la última versión válida de nuestra aplicación.</p>

<h4 align="left"> ¿Cómo se automatiza el deployment con Jenkins File? </h4>

<p align="left"> Los Jenkins Files permiten definir la lógica de construcción y deployment en un pipeline de CI/CD, facilitando la ejecución automatizada bajo ciertas condiciones. Aquí se ejemplifica el proceso para automatizar el deployment a staging:

1. Agendar Deployment a Staging: Configurar el pipeline para que sólo se activen deployments a staging cuando el build esté en el branch master y haya pasado los tests sin errores.

2. Desencadenar el job de deployment:

    2.1 Utiliza la función build para ejecutar el job de deployment creado, pasándole el Artifact ID.
    2.2 Configura el parámetro wait: false para que no interfiera con la ejecución del CI, permitiendo que las pruebas sigan su curso sin necesidad de esperar que el deployment termine.

3. Verificar y probar el nuevo deployment:

    3.1 Realiza pruebas sobre la nueva URL generada por Now.
    3.2 Asegúrate de que tu aplicación funciona correctamente antes de considerar el paso a producción.

En resumen, esta estrategia permite que el deployment y las pruebas fluyan de manera independiente, asegurando la calidad y estabilidad de las actualizaciones de tu aplicación.

Al final del proceso, habrás configurado un flujo automático que cubre desde el build del código hasta su deployment y testeo en un entorno de staging, preparándote para pasos futuros hacia producción. Asegúrate de realizar pruebas exhaustivas antes de cualquier movimiento definitivo, y disfruta del poder de la automatización continua. ¡Ánimo, estás caminando por la senda del éxito en CI/CD! </p>