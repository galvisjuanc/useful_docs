<h2 align="left"> Crear tu primer proyecto en Supabase Cloud </h2>

<p align="left"> Empieza hoy con Supabase Cloud y deja listo un entorno real para tu app. Aquí verás cómo crear tu cuenta, levantar tu organización y proyecto, explorar el dashboard, modelar tablas y consumir datos vía API sin programar un backend. Además, entenderás módulos clave como authentication, storage y project settings para escalar cuando lo necesites. </p>

<h3 align="left"> ¿Cómo crear tu cuenta y proyecto en Supabase Cloud? </h3>

<p align="left"> Crear el entorno inicial es rápido. Tras ingresar a supabase.com, inicias el flujo con Start Your Project y en minutos verás el overview del proyecto activo, listo para trabajar.

<strong> ¿Qué elegir al registrarte y validar tu cuenta? </strong> 

* Entra a supabase.com y haz clic en Start Your Project.
* Regístrate con correo y contraseña, o con proveedores como GitHub.
* Si usas email y aparece una notificación, valida el correo para confirmar el acceso.

<strong>¿Cómo configurar organización, tier y región? </strong>

* Crea una organización nueva. Ejemplo: “Suplatsigram organización”.
* Selecciona el tipo: personal, educación, startup, agencia o compañía.
* Elige free tier. Permite múltiples proyectos, con solo dos activos al mismo tiempo.
* Crea el proyecto. Nombra “Suplatsigram”, genera una contraseña segura y copia. Define región para alojar la base de datos.

<strong>¿Qué muestra el dashboard overview inicial? </strong>

* Estado del proyecto: activo y sin tablas, funciones ni réplicas al inicio.
* Opciones de rama y conexiones. Acceso a documentación integrada.
* Módulos disponibles: authentication, storage, Edge Functions y real time.
* Detalles de API y endpoint, el “corazón” de Supabase.
* Librerías cliente: JavaScript, Flutter, Python, C#, Swift, Kotlin.
* Proyectos starter: Nest, Next, React, Svelte y un to-do list app.

<strong>¿Cómo modelar datos y usar el SQL editor?</strong>

Puedes crear tablas desde la UI o con el SQL Editor. Así controlas estructura, seguridad y velocidad de desarrollo según tu preferencia.

* Crea una tabla con nombre y descripción opcional.
* Activa seguridad a nivel de celda o de fila y define políticas.
* Estructura inicial sugerida: id y fecha de creación con timestamp.
* Agrega columnas según tus necesidades.
* Usa el SQL Editor para ejecutar sentencias, alterar tablas y ahorrar tiempo.

<strong>Ejemplo práctico</strong>

* Tabla “post” con: id, timestamp de creación, user, id de imagen y label.
* Nota: “user”, aun siendo texto, es palabra reservada en Postman, por eso va entre comillas.
* Ejecuta y verifica en el editor de tabla que “post” fue creada.
* Agrega contenido por UI o con SQL Editor.

Habilidad clave: diseñar el modelo de datos y aplicar políticas con seguridad a nivel de fila para controlar quién puede leer o escribir.

</p>

<h3 align="left">¿Cómo gestionar usuarios, storage y consumir la API de Supabase? </h3>

<p align="left"> La plataforma integra todo lo necesario: gestión de usuarios, archivos y acceso a datos con REST y Graph QL, incluidos API keys y documentación lista para usar.

<strong> ¿Cómo funciona authentication y user management? </strong>

* Visualiza usuarios registrados y su visibilidad: públicos o privados.
* Crea usuarios nuevos y gestiona políticas, logueos, server y sesiones.
*Controla rate limit y otras opciones orientadas a seguridad.
* Flujos soportados: registro, login con email y password, magic link por email, teléfono y proveedores externos.
* Documentación integrada sobre client API keys y service keys.

<strong> ¿Qué ofrece storage con buckets y políticas? </strong>

* Crea buckets y carpetas para imágenes, videos, documentos y más.
* Ajusta settings, escribe, modifica o elimina políticas.
* Define permisos: quién puede escribir, modificar o agregar archivos.
* Analytics y vectores disponibles en versión pro.
* Configuración por región coherente con la del proyecto.

</p>
