<h2 align="left"> Arquitectura por capas orientada al dominio en Java </h2>

<h3 align="left"> ¿Qué es una arquitectura de proyecto por capas y orientada al dominio? </h3>

<p align="left"> Una arquitectura por capas divide la aplicación en distintas áreas de responsabilidad. Esto facilita tanto la legibilidad como el crecimiento del sistema. La orientación al dominio significa que el núcleo de la aplicación estará claramente definido, separando la lógica de negocio de otros componentes. </p>

<h3 align="left"> ¿Cuáles son los paquetes principales y su función en esta organización? </h3>

<p align="left"> 

* Dominio (domain): Aquí se sitúa todo el núcleo (core) de la aplicación. Contiene reglas y servicios de negocio esenciales. Dentro del dominio, se recomienda crear a su vez un subpaquete domain.service para las interfaces de servicios, como PlatziAIService.

* Web: En este paquete se encuentra la capa encargada de recibir y procesar solicitudes externas, generalmente controladores. Es útil agregar un subpaquete web.controller para concentrar todos los controladores del proyecto, por ejemplo, la clase HelloController.

* Persistence: Aquí estará toda la comunicación con la base de datos, manejando el acceso y la persistencia de datos. Es común crear este paquete aunque inicialmente se encuentre vacío. </p>

<h3 align="left"> ¿Cómo organizar las clases y archivos existentes según esta estructura? </h3>

<p align="left"> 

* Mover los controladores: Ubica las clases controladoras, como HelloController, dentro del subpaquete web.controller.
* Organizar servicios de dominio: Arrastra las interfaces y servicios relevantes al subpaquete domain.service.
* Actualizar imports automáticamente: IDEs como IntelliJ ayudan a modificar los imports y referencias de paquetes cuando se reorganizan archivos.
* Mantener la clase ejecutora: La clase principal, como PlatziPlay, debe quedar en la raíz del paquete base, ya que es responsable de lanzar la aplicación.</p>

<h3 align="left"> ¿Qué ventajas tiene esta estructura al trabajar en equipo o en proyectos grandes? </h3>

<p align="left"> 

* Separación clara de responsabilidades ayuda a que múltiples desarrolladores trabajen en paralelo sin interferir entre sí.
* Mejor mantenimiento y legibilidad, facilitando encontrar y modificar componentes específicos.
* Facilidad para escalar, ya que la organización permite agregar nuevas funcionalidades o modificar las existentes con menor riesgo de errores.</p>

<h3 align="left"> ¿Cómo practicar y validar que la estructura funciona correctamente? </h3>

<p align="left"> Una vez realizado el cambio de estructura: 

* Modifica las rutas para que los controladores respondan en los endpoints deseados, como /hello en vez de la raíz (/). 
* Lanza la aplicación y prueba en el navegador la nueva ruta para verificar el correcto funcionamiento. </p>