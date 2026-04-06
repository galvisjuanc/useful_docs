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
* Se confirma el primer registro creado con todos los campos correctos.</p>