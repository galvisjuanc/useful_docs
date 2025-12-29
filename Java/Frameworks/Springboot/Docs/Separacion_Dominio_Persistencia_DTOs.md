<h2 align="left"> Separación de dominio y persistencia con DTOs en Java </h2>

<h3 align="left"> ¿Cómo afecta el acoplamiento entre controlador y base de datos el diseño de tu API? </h3>

<p align="left"> Actualmente, el controlador llama directamente al CRUD del Movie Entity, exponiendo la estructura interna de la base de datos. Esto implica varios riesgos:

* Alto acoplamiento: cualquier cambio en la base de datos puede romper la API fácilmente.
* Exposición de datos sensibles o innecesarios: al no filtrar la salida, pueden aparecer campos indeseados.
* Mezcla de idiomas: el endpoint es /movies pero el contenido de la respuesta está en español.

Estos problemas hacen que la API sea difícil de mantener, frágil y dependiente de la estructura interna de la base de datos.  </p>