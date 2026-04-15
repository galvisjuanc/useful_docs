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

<strong> ¿Qué políticas y permisos debes considerar? </strong>

Las políticas definen quién puede subir, leer y editar archivos. En un bucket público, la lectura es abierta; el resto de permisos quedan bajo políticas que puedes ajustar más adelante. Esto es clave para controlar visibilidad y gestión de contenido.

* Lectura pública para mostrar fotos en el feed.
* Políticas para limitar quién sube o edita archivos.
* Opciones generales con disponibilidad parcial en la versión gratuita.
* Posibilidad de hacer privado y gestionar el acceso con reglas.

También verás áreas como configuraciones, analíticas y vectores en el dashboard. Son funciones nuevas mencionadas como referencia, mientras el foco aquí es el storage y su acceso.

<strong> ¿Cómo organizar y gestionar archivos para el feed? </strong>

Dentro del bucket, crea dos carpetas: Profile para fotos de perfil y Post para las imágenes de las publicaciones. Así separas contenidos y preparas el flujo para subir desde el front end y obtener URLs que se usarán en el feed.

* Carpeta Profile: fotos de perfil por usuario.
* Carpeta Post: imágenes de publicaciones.
* Archivos alojados en bucket público quedan en dominio público.

</p>