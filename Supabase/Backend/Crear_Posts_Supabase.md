<h2> Crear Posts reales con Supabase y Next.js </h2>

<p align="left"> Aprende a crear posts reales en Supabase con un flujo completo y confiable: subir la imagen al storage, obtener su URL pública, guardar el registro en la tabla y renderizarlos en el FE como un pequeño feed. Verás como hacerlo desde la API, el dashboard y con la librería Supabase JS sobre Next.js, cuidando los detalles que marcan la diferencia. </p>

<h3> ¿Cómo crear posts desde api y dashboard en Supabase? </h3>

<p align="left"> Desde el dashboard se sube una imagen al storage y se obtiene su URL pública. Luego, con HTTPie, se hace un request de tipo POST a la API pasando solo dos datos en el body: user ID e image URL. También se incluyen los headers necesarios: API key y authorization.

* Subir imagen al storage y confirmar carga completa.
* Obtener la get URL para uso en la API.
* Enviar POST con user ID e image URL.
* Confirmar respuesta 201 creado al ejecutar el llamado.</p>