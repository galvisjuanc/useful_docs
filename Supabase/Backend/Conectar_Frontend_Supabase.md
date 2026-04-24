<h2> Cómo conectar frontend en Supabase en minutos </h2>

<p align="left"> Conecta tu base de datos de Supabase con un frontend real en minutos. Aquí verás cómo clonar el repositorio inicial, correrlo en tu máquina, preparar las variables de entorno y crear el cliente de Supabase para leer y escribir datos sin partir desde cero. </p>

<h3> ¿Cómo pasar de base de datos a interfaz con Supabase? </h3>

<p align="left"> El objetivo es vincular tu proyecto de Supabase con un frontend listo para usar. Partes de un repo preconfigurado para “Suplatigram”, lo clonas, instalas dependencias y lo ejecutas con datos moqueados. Luego, configuras variables de entorno y el cliente de Supabase para comenzar a consumir datos reales.

<strong> ¿Dónde clonar el repositorio de frontend en GitHub? </strong>

* Abre el enlace del repo en la sección de recursos de GitHub.
* Copia el link para clonar por SSH o HTTPS.
* Clona en la carpeta donde trabajarás.
* Verifica la carpeta “Supervise fundamentos”.
* Cambia de rama con git checkout a “clase doce inicio”. 

<strong> ¿Cómo instalar dependencias y ejecutar en localhost? </strong> 

* Corre npm install para instalar dependencias.
* Inicia el servidor con npm run dev.
* Abre tu navegador en localhost:3000.
* Verás el frontend con data moqueada: avatar, título, usuario, tiempo de publicación, imagen, likes y caption.

<strong> ¿Qué trae el proyecto inicial del frontend? </strong>

* Carpeta de componentes y carpeta de mocks con listado de posts.
* Página de crear post y página de rank.
* Utilidad get time ago para mostrar “publicado hace X tiempo”.
* Homepage con listado de posts y navegación entre páginas.
* Componente del corazón para dar like que cambia de color al hacer clic.
* Modal para ver el post en detalle en escritorio.
* Uso de Next.js Image y React useState para render y estado.
* Ranking que ordena los posts por likes en orden descendente.

<strong> ¿Cómo configurar variables de entorno y el cliente de Supabase? </strong>

Para conectar con tu proyecto real, prepara el archivo de entorno y crea el cliente. Así, cada página podrá leer y crear datos en tu base.

<strong> ¿Qué variables copiar del panel de Supabase? </strong>

* Renombra el archivo “M punto example” a .env.
* Desde tu panel de Supabase, entra a project overview.
* Haz clic en Connect en la barra superior.
* En App Framework copia la URL y la clave anónima.
* Pega ambos valores en tu .env para que el frontend los use.
* Si tu proyecto es de Next.js con app router, esta configuración encaja perfecto.

<strong> ¿Cómo instalar la librería y crear el cliente en JavaScript? </strong>

* Detén el servidor de desarrollo.
* Instala la librería oficial de Supabase para JavaScript.
* La documentación también muestra opción por CDN, pero seguimos la instalación por paquete.
* Importa la función create client desde la librería.
* Inicializa el cliente con la URL y la clave anónima desde variables de entorno.
* Crea el archivo utils/client.ts y exporta la constante de Supabase.
* Con eso, podrás consumir el cliente en cualquier página o función para leer o crear data.

<strong> ¿Qué flujo de trabajo seguir a partir de aquí? </strong>

Con el entorno listo, ya tienes el cliente configurado, el .env conectado y el proyecto corriendo. El siguiente paso es leer posts reales desde Supabase, mostrar imágenes del storage y construir el feed de Suplaxigram directamente en la interfaz. Verás cómo lo hecho en el backend cobra vida en el frontend.

</p>