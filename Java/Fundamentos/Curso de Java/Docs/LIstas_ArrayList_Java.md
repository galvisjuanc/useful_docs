<h2 align="left"> Operaciones básicas con listas en Java: agregar, eliminar y recorrer </h2>

<h3 align="left"> ¿Cómo se crean y utilizan listas en Java? </h3>

<p align="left"> Las listas en Java se declaran usando la palabra List junto con el tipo de elemento que almacenarán entre signos menor que y mayor que. En este ejemplo, la clase Plataforma contiene una lista de películas llamada contenido:

* Se definen dos atributos: el nombre de la plataforma y la lista de contenido.
* El atributo lista se debe inicializar en el constructor con new ArrayList<>(); para evitar errores de referencia.
* Las buenas prácticas incluyen mantener atributos privados y solo exponer lo necesario mediante métodos getter. </p>


<h3 align="left"> ¿Qué operaciones básicas puedes hacer con listas en Java? </h3>

<p align="left"> Trabajar correctamente con listas implica conocer algunos métodos clave:

* Agregar elementos: Usa el método add para añadir un elemento; también puedes especificar el índice de inserción, agregar otra lista completa (addAll), o elegir si insertas al inicio o final.
* Eliminar elementos: El método remove permite quitar un elemento por objeto o posición. Incluso puedes eliminar elementos que cumplan con una condición específica.
* Recorrer la lista: Existen diferentes maneras, como el tradicional for usando un índice, o el for mejorado, donde defines directamente el tipo del objeto que recorres.
* Obtener información: El método size devuelve el número de elementos actuales de la lista. </p>