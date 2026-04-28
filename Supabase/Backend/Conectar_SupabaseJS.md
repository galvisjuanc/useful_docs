<h2> Conectar Supabase JS con datos reales del ranking </h2>

<p align="left"> Conecta tu front end a datos reales con Supabase JS y construye un ranking de posts por número de likes. En minutos pasas de mocks a lecturas desde la base de datos, validas en consola y habilitas imágenes desde storage con Next.js, sin fricción. </p>

<h3> ¿Cómo conectar Supabase JS y leer datos reales? </h3>

<p align="left"> Con el client ya configurado, la verificación inicial consiste en hacer una primera lectura, correr el proyecto con npm run dev y revisar la consola del navegador en localhost:3000. Si todo está bien, verás los posts tal como en el dashboard de Supabase. La llamada se ejecuta dentro de un useEffect para dispararse al montar la página.

* Importar el client desde utils.
* Crear una función asíncrona de fetch con manejo de error.
* Renderizar la llamada dentro de useEffect.
* Validar en la consola que llegan los datos: caption, fecha de creación, id, imagen, likes, actualización y usuario.

</p>