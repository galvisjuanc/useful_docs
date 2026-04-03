<h2> Instalación y configuración de Supabase CLI </h2>

<p align="left"> Aprende qué es Supabase CLI, cómo instalarla e iniciar un proyecto para ejecutar tu backend en local con bases de datos, autenticación, storage y funciones en contenedores. Con pocos comandos obtienes una instancia completa que replica Supabase Cloud, ideal para trabajar offline, probar cambios y comparar local vs producción con confianza. </p>

<h3 align="left"> ¿Qué es y para qué sirve Supabase CLI? </h3>

<p align="left"> Supabase CLI es la herramienta de línea de comandos para gestionar tu backend localmente: base de datos, autenticación, storage, funciones y más. Usa contenedores en tu máquina y te permite trabajar sin conexión, hacer pruebas y validar flujos antes de subir a producción.

* Trabaja el backend completo en local con las mismas capacidades que en la nube.
* Ideal para desarrollo offline, pruebas locales y comparación local vs producción.
* Aporta flexibilidad y una visión más profunda de cómo funciona Supabase under the hood.
* Aunque el curso usa Supabase Cloud, conocer la CLI amplía tus opciones de trabajo.</p>

<h3 align="left"> ¿Qué utilidades ofrece en local? </h3>

<p align="left"> 

* Base de datos con edición por SQL y herramientas de gestión.
* Autenticación para usuarios y sesiones.
* Storage para archivos.
* Funciones, incluyendo soporte para Deno y edge functions.
* Integraciones disponibles desde la interfaz.</p>

<h3 align="left"> ¿Cómo se instala e inicia un proyecto con init? </h3>

<p align="left"> La CLI incluye un comando de ayuda que lista todos los comandos disponibles, explica qué hace cada uno y muestra la versión instalada. Desde ahí podrás ver cómo se manejan bases de datos y herramientas de código.

* Usa el comando de ayuda para explorar comandos y su descripción.
* Identifica la versión instalada y opciones clave para tu flujo.</p>

<h3>¿Qué crea el comando init? </h3>

<p> 

* Inicializa un nuevo proyecto con init.
* Genera una carpeta llamada Supabase con lo necesario para arrancar.
* Pregunta si deseas instalar los settings para Deno, útil para edge functions.</p>

<h3> ¿Qué recibes al iniciar el proyecto? </h3>

<p> Tras la instalación, la CLI expone los recursos locales principales:

* API del proyecto disponible.
* GraphQL habilitado.
* Storage operativo.
* Base de datos lista.
* Studio como UI para gestionar todo.</p>