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

    // Seleccionar solo lo necesario
    .select('likes,image_url,user_id')

    // Filtrar por usuario
    .eq('user_id', '<ID_DEL_USUARIO>')

<strong> ¿Cómo leer, filtrar y ordenar posts por likes y usuario? </strong>

Primero, es posible leer todos los posts. Luego, filtrar por condición, como likes mayores a 30. En el ejemplo, la consulta devolvió cinco posts, pero estaban desordenados por cantidad de likes.

<strong> ¿Cómo ordenar por likes ascendente o descendente? </strong>

Ordena por la columna de likes según lo que necesites: ranking ascendente o descendente para destacar más o menos interacción.

    // Ascendente: de menor a mayor
    .order('likes', { ascending: true })

    // Descendente: de mayor a menor
    .order('likes', { ascending: false })


* Ascendente: devuelve 31, 32, 35, 42, 44.
* Descendente: devuelve 44, 42, 35, 32, 31.

Esto deja la respuesta lista para una interfaz que muestre el ranking de likes con claridad.

<strong> ¿Cómo filtrar por usuario con user_id? </strong>

Si la vista es el perfil, filtra por el usuario específico usando su user_id. La respuesta incluye solo sus posts, ideal para mostrar en su página sin lógicas extra en el front end.

    // Posts de un usuario
    .eq('user_id', '<ID_DEL_USUARIO>')

* Útil para la página de perfil.
* Evita filtrar en el cliente o en otra consulta.
* Llega ya listo desde la HTTP request.

<strong> ¿Cómo optimizar la respuesta para un front end más rápido? </strong>

Seleccionar menos columnas reduce el peso de la respuesta y mejora la percepción de velocidad. En la prueba, pedir solo image_url y user_id dio una respuesta de 4 KB en 244 ms. Pedir “toda la base” subió a 10 KB y 579 ms. Más del doble de tiempo para datos que no se usan.

* Selecciona campos precisos para cada pantalla.
* Evita traer columnas innecesarias.
* Ordena en el servidor y llega con el formato final.

</p>