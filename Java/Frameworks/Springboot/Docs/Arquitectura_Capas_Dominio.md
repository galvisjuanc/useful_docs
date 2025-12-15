<h2 align="left"> Arquitectura por capas orientada al dominio en Java </h2>

<h3 align="left"> ¿Qué es una arquitectura de proyecto por capas y orientada al dominio? </h3>

<p align="left"> Una arquitectura por capas divide la aplicación en distintas áreas de responsabilidad. Esto facilita tanto la legibilidad como el crecimiento del sistema. La orientación al dominio significa que el núcleo de la aplicación estará claramente definido, separando la lógica de negocio de otros componentes. </p>

<h3 align="left"> ¿Cuáles son los paquetes principales y su función en esta organización? </h3>

<p align="left"> 

* Dominio (domain): Aquí se sitúa todo el núcleo (core) de la aplicación. Contiene reglas y servicios de negocio esenciales. Dentro del dominio, se recomienda crear a su vez un subpaquete domain.service para las interfaces de servicios, como PlatziAIService.

* Web: En este paquete se encuentra la capa encargada de recibir y procesar solicitudes externas, generalmente controladores. Es útil agregar un subpaquete web.controller para concentrar todos los controladores del proyecto, por ejemplo, la clase HelloController.

* Persistence: Aquí estará toda la comunicación con la base de datos, manejando el acceso y la persistencia de datos. Es común crear este paquete aunque inicialmente se encuentre vacío. </p>