<h2 align="left"> Creación de endpoints GET en Spring Boot para consultar películas </h2>

<h3 align="left"> ¿Cómo crear un endpoint GET en Spring Boot para listar películas? </h3>

<p align="left"> Para que tu aplicación pueda mostrar todas las películas, es necesario implementar un endpoint GET en un controlador especial. Se recomienda nombrar la clase como MovieController dentro del paquete de controladores web. Usa la anotación @RestController para indicar que los métodos en esta clase serán expuestos a través de la API.

* Crea un método que regrese una lista del objeto MovieEntity.
* El método debe consultar las películas del CRUD creado anteriormente.
* Declara la variable crudMovieEntity como final, porque no cambiará tras inicializarse.
* Inicializa crudMovieEntity en el constructor. Spring Boot se encarga de pasar la dependencia correcta automáticamente.
* Para obtener todas las películas, utiliza el método findAll de crudMovieEntity. Este retorna un Iterable, por lo que se debe convertir (cast) a una List.
* Añade la anotación @GetMapping("/movies") para que Spring entienda que se trata de una solicitud GET y el recurso será accesible en /movies. </p>

<h3 align="left"> ¿Qué se muestra al consumir el endpoint GET de películas? </h3>

<p align="left"> Una vez implementado y reiniciada la aplicación, puedes consumir el servicio desde un navegador web. Al acceder a la ruta /movies, verás un listado de todas las películas en formato JSON, un estándar ampliamente usado para intercambiar información.

Los datos de cada película incluyen: 
* ID (clave primaria). 
- Título. 
- Duración. 
- Género. 
- Fecha de estreno. 
- Clasificación (promedio de calificaciones dentro de la plataforma). 
- Estado.

Puedes visualizarlo de manera más ordenada usando herramientas que formatean JSON para mayor legibilidad. </p>

<h3 align="left"> ¿Cómo probar el endpoint GET con Postman y por qué funciona automáticamente? </h3>

<p align="left"> Para verificar el correcto funcionamiento del endpoint, puedes usar Postman, una herramienta ideal para probar servicios API sin escribir código adicional. Solo necesitas:

* Crear una petición GET hacia la URL correspondiente (por ejemplo, localhost:8090/play/api/movies).
* Enviar la solicitud y observarás las películas recuperadas, presentadas en un formato claro y visual.
* Notarás que todo esto ocurre sin haber escrito código específico de conexión a la base de datos ni creado instancias manualmente. 

Esto es posible gracias a que Spring Boot gestiona las dependencias y la inyección de objetos automáticamente. Así, tu código permanece limpio y enfocado en la lógica del negocio, sin preocuparte por detalles de infraestructura. </p>