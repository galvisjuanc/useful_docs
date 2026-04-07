<h2> Insertar primeros datos en Supabase </h2>

<p align="left"> Dar el salto de tablas vacías a datos reales en Supabase cambia todo: en cuanto insertas registros, se habilitan automáticamente las APIs en REST y GraphQL para consultarlos desde el front-end. Aquí verás cómo insertar desde la UI y el SQL Editor, validar que los campos automáticos funcionen, y explorar la API pública con filtros por likes sin escribir backend. </p>

<h3> ¿Cómo insertar datos en Supabase con UI y SQL Editor? </h3>

<p align="left"> Al crear tus primeros registros en la tabla Post New, Supabase genera de inmediato endpoints listos para consumir. Puedes hacerlo manualmente con la UI y luego a escala con el SQL Editor para entender la sintaxis de inserción.

¿Qué ocurre al crear el primer registro en Post New?

* Usa el botón verde de la UI para “insertar una fila”.
* El ID se crea automáticamente al guardar.
* Agrega un user ID, una image URL de prueba y un caption como “Primer post de Suplatsigram”.
* likes tiene default 0, pero puedes asignar 1 para la prueba.
* created_at y updated_at se completan por default con fecha y hora actuales.
* Se confirma el primer registro creado con todos los campos correctos.

<strong>¿Cómo insertar múltiples filas con SQL Editor? </strong>

* Prepara una sentencia de inserción para Post New con: user_id, image_url, caption y likes.
* No incluyas campos automáticos: Supabase los completa por ti.
* Ejecuta y verifica el resultado: el estado indica “exitoso”.
* Al refrescar la tabla, verás todos los nuevos registros agregados.
* Se llega a 31 registros: 30 desde SQL más 1 manual inicial.

<strong> ¿Qué campos genera Supabase por default? </strong>

* ID autoincremental del post.
* created_at y updated_at con timestamp actual.
* likes con default 0 si no lo envías.
* caption con emojis soportados, listos para renderizar en la interfaz.

<strong> ¿Cómo consultar la API pública REST y GraphQL? </strong>

Desde API Docs, Supabase documenta cómo consumir tus tablas y views en JavaScript o en bash. Puedes probar la lectura con un cliente HTTP como httpie y obtener respuestas en tiempo real.

<strong> ¿Dónde encontrar API Docs con tablas y views? </strong>

* En API Docs verás la intro y las tablas creadas, incluida Post New.
* Cada tabla trae ejemplos de lectura, escritura y filtros.
* Tienes secciones para JavaScript y para bash con comandos listos.

<strong> ¿Cómo probar con un cliente HTTP como httpie? </strong>

* Consulta la tabla original “post”: devuelve un array vacío porque no tiene registros.
* Cambia la consulta a Post New y obtendrás todos los registros almacenados.
* Revisa el detalle de cada post devuelto por la API pública.

<strong> ¿Qué filtros disponibles para likes y columnas? </strong>

* Igual a un valor, mayor que, menor que.
* Entre rangos: between, mayor o igual, menor o igual.
* Comparaciones case-sensitive cuando aplican a texto.
* Arrays y operador no igual.
* Ejemplos de resultados: mayores a 25 devuelven 9 posts. Mayores a 30 devuelven 5 posts.

<strong> ¿Qué implican estas inserciones para tu front-end? </strong>

Con datos en Post New, Supabase expone de inmediato APIs funcionales para consumir desde cualquier interfaz usando la URL y la clave pública del proyecto. Todo sin escribir backend: interactúas con la UI, sentencias SQL puntuales y una API preparada para filtrar, ordenar y paginar.

* Consultas desde el front-end usando endpoints en REST o GraphQL.
* Filtros por likes y por cualquier columna disponible.
* Respuesta inmediata al insertar nuevos registros.
* Base sólida para implementar listados, detalles y rankings con tus datos.

</p>