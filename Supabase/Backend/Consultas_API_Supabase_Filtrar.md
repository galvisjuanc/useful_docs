<h2> Consultas de API en Supabase: filtrar y ordenar </h2>

<p align="left">Construye confianza al consumir la API generada automáticamente por Supabase y prepara datos listos para el front end. Aquí verás cómo leer, filtrar y ordenar posts, seleccionar solo las columnas necesarias y medir el impacto en peso y tiempo de respuesta, sin memorizar recetas: solo entendiendo el patrón correcto. </p>

<h3> Consultas de API en Supabase: filtrar y ordenar </h3>

<p align="left"> La idea clave es aplicar siempre el mismo flujo. Así reduces complejidad y aseguras respuestas útiles para la interfaz de usuario.

* Elegir la tabla: por ejemplo, posts.
* Seleccionar columnas: solo lo que la pantalla necesita.
* Aplicar filtros: por likes o por usuario.
* Ordenar resultados: ascendente o descendente. 

Este patrón permite construir casi cualquier pantalla de lectura: desde el perfil del usuario hasta el feed principal, con datos limpios y listos.

<strong>¿Qué columnas seleccionar para cada pantalla? </strong>

Cuando una vista solo requiere imagen y contador de likes, selecciona esas columnas (por ejemplo: likes, image_url, user_id) y evita traer el resto. Así no hay datos repetidos ni sin uso.

<strong> Ejemplos de selección y filtros mínimos: </strong>

</p>