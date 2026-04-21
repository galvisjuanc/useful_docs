<h2> Cómo conectar Storage y base de datos </h2>

<p align="left"> Integra Supabase Storage con tu base de datos y muestra imágenes reales en tu feed, perfil y detalle de post con un flujo simple y eficiente. Aquí se explica por qué guardar la URL pública en la tabla de posts y mantener los archivos en Storage mejora rendimiento, seguridad y control, siguiendo la recomendación directa de Supabase. </p>

<h3> ¿Cómo se relacionan storage y base de datos en Supabase? </h3>

<p align="left"> Supabase Storage y la base de datos funcionan como piezas complementarias. Storage aloja los archivos reales: imágenes, videos o documentos. La base de datos guarda la metadata: autor, título, descripción, likes, fecha y la URL pública que apunta al archivo.

<strong> ¿Qué guarda cada pieza y cómo se vinculan? </strong>

* Storage: archivos binarios reales.
* Base de datos: metadata y la columna image_url.
* image_url: enlace público que actúa como puente entre registro y archivo.
* Front end: pide los posts, recibe la URL y renderiza la imagen.

<strong> ¿Qué ventajas tiene separar archivos y datos? </strong>

* No sobrecargas la base de datos con binarios.
* Usas infraestructura optimizada de Storage con CDN y cacheo.
* Respaldas límites y controles: tamaño máximo y tipo de contenido.
* Manejas permisos con row-level security en Storage y en la base de datos por separado.
* Si migras assets a otro servicio, solo actualizas la URL, no mueves blobs.
</p>