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

<h3 align="left">¿Qué ventajas y errores debes tener en cuenta al manipular listas? </h3>

<p align="left"> Aquí se destacan algunos puntos prácticos observados durante la implementación:

* Siempre inicializa la lista antes de usarla para evitar el NullPointerException, un error muy común cuando se intenta acceder a una referencia no asignada.
* Es recomendable quitar imports innecesarios en el código para optimizar la gestión de memoria.
* Solo expón los métodos getter de los atributos que necesitas fuera de la clase; evitar los setter cuando no es necesario asegura la integridad de tus datos. </p>

<h3 align="left">¿Cómo puedes mostrar y gestionar el contenido de la lista? </h3>

<p align="left"> Después de agregar varias películas, puedes mostrar los títulos implementando un método que recorra la lista y los imprima. Es posible agregar, mostrar y eliminar elementos de la lista desde tu método principal (main) y ver cómo cambian los datos en tiempo real:

* Agrega varias películas a la plataforma.
* Muestra el tamaño actual y los títulos registrados.
* Elimina un elemento usando plataforma.eliminar y observa que el contenido se actualiza correctamente. 

Java también permite realizar operaciones más avanzadas como filtrar o transformar listas usando streams y lambdas, ideales para estructuras de datos limpias y operaciones modernas.

</p>