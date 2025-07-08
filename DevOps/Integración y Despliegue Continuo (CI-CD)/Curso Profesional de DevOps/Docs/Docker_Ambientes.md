<h2 align="left"> Uso de Docker para Homogeneidad en Ambientes de Desarrollo </h2>

<p align="left"> Docker, el principal exponente de la tecnología de container.

* Docker se compone de varias herramientas que interactuar con el CLI de este. Docker Deamon se debe de ejecutar con privilegios root, este se une al socket de Unix, los usuarios solo pueden acceder mediante un sudo, propiedad del root. Para compilar las imágenes se utiliza los archivos "Dockerfile", con su misma línea de Docker, se manda a "time biuld".

* Al ejecutar Docker Demon localmente, corre el riesgo de que cualquier proceso que salga del Docker Container, tenga los mismos derechos que el OS host.

* Un solo proceso podría ser un único punto de falla.

* Este proceso era propietario de todos los procesos secundarios (los contenedores en ejecución).

* Si ocurría una falla, entonces habría procesos huérfanos.

* La construcción de contenedores generó vulnerabilidades de seguridad.

* Todas las operaciones de docker deben ser realizadas por un usuario con permisos root. </p>

