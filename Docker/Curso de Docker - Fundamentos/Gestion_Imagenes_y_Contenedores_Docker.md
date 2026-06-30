<h2> Gestión de Imágenes y Contenedores en Docker </h2>

<p align="left"> Docker facilita considerablemente la gestión de imágenes mediante comandos intuitivos y efectivos desde tu terminal u opciones visuales desde Docker Desktop. Aprender a administrar adecuadamente versiones, etiquetas (tags) y eliminación de imágenes es clave para mantener un control claro y efectivo sobre proyectos que implican múltiples imágenes y contenedores. </p>

<h3> ¿Cómo asignar versiones específicas a tus imágenes Docker? </h3>

<p align="left"> Asignar versiones específicas a tus imágenes Docker es sencillo mediante el parámetro -tag. Desde tu terminal puedes hacerlo fácilmente de esta manera:

    docker build --tag sitio_web22:2.1.5 .

Aquí puedes definir según tus preferencias el nombre y número de versión, lo que facilita la identificación posterior de cada versión particular.

<strong> ¿Cuál es la forma eficiente de filtrar y encontrar imágenes Docker? </strong>

Al trabajar con múltiples imágenes, utilizar filtros en la línea de comandos simplifica enormemente la búsqueda y gestión. Usa el parámetro filter para ubicar imágenes según su tag específico:

    docker images --filter=reference="*:1.0"

Así obtendrás únicamente aquellas imágenes etiquetadas con un tag específico, evitando revisar largas listas.

<strong> ¿Cómo visualizar el ID completo de tus imágenes Docker? </strong>

Docker habitualmente muestra IDs resumidos. Para mostrar el ID real completo del tipo SHA-256, emplea el parámetro --no-trunc:

    docker images --no-trunc

Esto proporciona mayor detalle cuando necesitas identificar inequívocamente imágenes usadas en distintos contextos.

<strong> ¿Cómo actualizar y eliminar etiquetas fácilmente? </strong>

Docker permite modificar etiquetas (tags) sin necesidad de reconstrucción, ejecutando simplemente:

    docker image tag sitio_web:latest amin/sitio_web:latest

Para eliminar etiquetas (no imágenes completas), usa el comando:

    docker rmi amin/sitio_web:latest

<strong> ¿De qué forma puedes forzar la eliminación de imágenes Docker? </strong>

Si intentas borrar una imagen activa (en uso por alguno de tus contenedores), Docker arroja un error. Una solución eficiente es el uso del parámetro -f (force):

    docker rmi -f <IMAGE_ID>

Esto eliminará la imagen inmediatamente, deteniendo también cualquier contenedor relacionado.



</p>