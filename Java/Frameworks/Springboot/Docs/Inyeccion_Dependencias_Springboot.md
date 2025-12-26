<h2 align="left"> Inyección de dependencias y contenedor IoC en Spring Boot </h2>

<h3 align="left">¿Qué es la inyección de dependencias en Spring Boot? </h3>

<p align="left"> La inyección de dependencias se basa en un patrón de diseño donde los objetos que una clase necesita le son proporcionados en vez de ser creados internamente. Este enfoque reduce el acoplamiento, mejora la cohesión y facilita las pruebas.

* Facilita la limpieza y flexibilidad del código.
* Permite remplazar y probar dependencias con facilidad.
* Promueve best practices y principios como SOLID. </p>

<h3 align="left"> ¿Cómo funciona el contenedor IoC de Spring? </h3>

<p align="left"> El contenedor de Inversión de Control (IoC) de Spring se encarga de crear y administrar automáticamente todos los objetos necesarios, llamados beans.

* Las clases no generan sus propias dependencias; el contenedor se encarga de ello.
* Spring escanea el proyecto y detecta clases con anotaciones como @Repository para acceso a datos, @Service para lógica de negocio, @Controller y @RestController para la exposición web, y @Component para componentes genéricos.
* Al detectar estas anotaciones, Spring crea los objetos y gestiona sus dependencias por nosotros.
* Esto mejora la estructura del sistema y facilita mantener un bajo acoplamiento y alta cohesión. </p>