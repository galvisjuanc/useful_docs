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