<h2> Cómo diseñar la tabla Posts en Supabase </h2>

<p align="left"> Definir un modelo de datos claro en Supabase es el paso clave para que Suplatigram funcione y crezca con confianza. Aquí todo nace en la base de datos: al modelar bien, se generan automáticamente APIs, permisos, reglas y relaciones que el front end podrá usar para crear y mostrar posts reales. </p>

<h3 align="left"> ¿Por qué el modelo de datos en Supabase define tu backend? </h3>

<p align="left"> Diseñar primero la base te ahorra errores y asegura escalabilidad. Lo que definas hoy en la tabla se traduce en endpoints, políticas y relaciones listas para usar, sin código adicional.

* Todo nace de la base de datos y se propaga a APIs y permisos.
* Las relaciones quedan claras desde el inicio.
* Te deja listo para trabajar con datos reales.
* Permite construir el feed, las pantallas de perfil y el detalle de cada post. </p>

<h3 align="left"> ¿Cómo crear la tabla post en el table editor? </h3>

<p align="left"> El objetivo es crear la tabla base que sostendrá el feed. Se parte del table editor y, para efectos del aprendizaje, se desactivan los niveles de seguridad. La tabla puede llamarse post o posts; incluye campos por defecto y campos agregados manualmente.

* Campos por defecto: id y created_at ya vienen listos.
* Autor: user_id en formato UUID para relacionar con usuarios registrados.
* Imagen: image_url como texto que luego provendrá del storage.
* Texto del post: caption como texto descriptivo.
* Ediciones: updated_at como timestamp para registrar cambios.
* Interacciones: likes como número, útil para relacionarlo con otra tabla más adelante. 

Puntos clave del flujo en el editor:

* Se agregan columnas según la funcionalidad prevista.
* Puedes añadir columnas después de crear la tabla: no es necesario definirlo todo al inicio.
* Tras crearla, es momento de cargar datos para activar las funcionalidades de Supabase.</p>