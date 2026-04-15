<h2> Crear bucket publico en Supabase Storage </h2>

<p align="left">Impulsa tu app con imágenes visibles al instante: aquí verás cómo crear un bucket público en Supabase Storage, entender políticas de acceso y organizar archivos para que el feed muestre fotos con URLs públicas. Todo paso a paso, sin complicaciones. </p>

<h3> ¿Cómo crear un bucket público en Supabase Storage? </h3>

<p align="left"> Desde el dashboard de Supabase, entra a la sección de storage y crea un bucket para las fotos. Se recomienda un nombre claro, por ejemplo Images, y activar la opción de público para permitir lectura sin autorización. Así, cualquiera podrá ver las fotos al abrir la URL, incluso sin iniciar sesión.

* Crear bucket con nombre claro: Images.
* Marcar como público para lectura sin autorización.
* Confirmar que el plan gratuito aplica límite global de 50 MB por archivo.
* Mantener sin restricciones de tipo o tamaño si buscas simplicidad.

<strong> ¿Qué límites y tipos de archivo conviene configurar? </strong>

Puedes restringir el tamaño y los tipos de archivo permitidos. En el plan gratuito, el límite por archivo es de 50 MB: si se intenta subir algo mayor, fallará, ya sea desde el dashboard o el front end. En este flujo se deja el límite por defecto y sin restricción de tipos para agilizar las pruebas.


</p>