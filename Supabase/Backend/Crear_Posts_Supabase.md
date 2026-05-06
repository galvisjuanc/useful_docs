<h2> Crear Posts reales con Supabase y Next.js </h2>

<p align="left"> Aprende a crear posts reales en Supabase con un flujo completo y confiable: subir la imagen al storage, obtener su URL pública, guardar el registro en la tabla y renderizarlos en el FE como un pequeño feed. Verás como hacerlo desde la API, el dashboard y con la librería Supabase JS sobre Next.js, cuidando los detalles que marcan la diferencia. </p>

<h3> ¿Cómo crear posts desde api y dashboard en Supabase? </h3>

<p align="left"> Desde el dashboard se sube una imagen al storage y se obtiene su URL pública. Luego, con HTTPie, se hace un request de tipo POST a la API pasando solo dos datos en el body: user ID e image URL. También se incluyen los headers necesarios: API key y authorization.

* Subir imagen al storage y confirmar carga completa.
* Obtener la get URL para uso en la API.
* Enviar POST con user ID e image URL.
* Confirmar respuesta 201 creado al ejecutar el llamado.

De inmediato se valida en el editor de tabla que el nuevo registro se creó correctamente. Se ve que:

* Los campos de creado y actualizado se completan de forma automática.
* caption no aparece porque no se envió.
* likes se inicializa en cero por defecto.
* El nombre del archivo puede diferir si proviene del nombre original de la imagen.

Este proceso “manual” refleja lo que hace la librería Supabase JS cuando trabajas desde el front end: primero sube al storage, luego obtiene la URL pública y finalmente inserta el registro en la tabla.

<strong> ¿Qué hace la librería supabase js en el front end? </strong>

Se preparó una interfaz sencilla para cargar una imagen, escribir una caption y publicar. Al intentar publicar, surge un error de row level security: las políticas impedían insertar datos. Por efectos didácticos se aplicaron “permisos básicos” para permitir leer, insertar, actualizar y borrar mediante sentencias SQL, y así continuar con la demostración.

Tras ajustar las políticas, el front end permite publicar y devuelve un objeto con la data del post: caption, fecha de creación, ID, URL de la imagen subida al storage, likes en cero, última actualización y user ID definido en el código. Todo coherente con los valores por defecto configurados.
</p>

