<h2> Crear tablas en Supabase con SQL </h2>

<p align="left"> Aprende a crear y recrear tablas en Supabase desde el editor de SQL para entender cómo trabaja Postgres por debajo y ganar más control sobre tu proyecto. Verás cómo una sentencia SQL construye la estructura que ya hiciste en la UI, y por qué esto es clave para migraciones y trabajo profesional. </p>

<h3 align="left"> ¿Por qué crear tablas en Supabase con SQL? </h3>

<p align="left"> Trabajar directamente con SQL te da control y claridad. Aunque Supabase automatiza cosas, todo se basa en SQL y conviene dominarlo para avanzar con confianza.

* Más control sobre tu proyecto y sus estructuras.
* Entendimiento real de cómo funciona Postgres.
* Base sólida para migraciones, colaboración en equipos y ambientes avanzados.
* Posibilidad de ejecutar sentencias directamente sobre tu base de datos. </p>

<h3 align="left"> ¿Qué papel cumple Postgres debajo de Supabase? </h3>

<p align="left"> Supabase se apoya en Postgres. Por eso, mientras más cómodo te sientas con SQL, más fácil será ajustar, migrar y mantener tus datos con precisión.

<strong> ¿Cómo recrear la tabla de posts desde el editor de SQL? </strong>

El objetivo es tomar la tabla de posts creada en la UI y rehacerla vía código. Para evitar conflictos con nombres, no se usa “post” porque ya existe: se crea una nueva llamada post new. Se pegan las sentencias en el editor de SQL, se ejecutan y se valida el resultado en el editor de tabla.

* Abre el editor de SQL en Supabase.
* Pega la sentencia que recrea la tabla de posts.
* Usa el nombre post new para no chocar con la tabla “post”.
* Ejecuta la sentencia: verás confirmación exitosa sin filas de retorno.
* Abre el editor de tabla y verifica que ahora existen “post” y “post new”.

<strong> ¿Qué nombres y campos incluye la nueva tabla? </strong>

La estructura replica la creada manualmente, con campos clave para un post.

* ID: identificador único del post.
* user ID: referencia al usuario que publica.
* image URL: ruta de la imagen asociada.
* caption: texto descriptivo del post.
* likes: contador de reacciones.
* creado y actualizado: marcas de tiempo para auditoría.

<strong> ¿Cómo verificar el resultado en el editor de tabla? </strong>

Tras ejecutar, confirma que están las dos tablas y que post new contiene los campos esperados. Así validas que la sentencia SQL construyó la estructura correctamente.


 </p>