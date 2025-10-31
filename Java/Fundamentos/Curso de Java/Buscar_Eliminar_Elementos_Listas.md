<h2 align="left"> Búsqueda y eliminación de elementos en listas de Java </h2>

<h3 align="left">¿Cómo cargar una lista de películas por defecto desde el inicio? </h3>

<p align="left"> Contar con un set de datos inicial al arrancar la plataforma facilita la interacción, ya que el usuario puede buscar o gestionar contenido sin agregar elementos manualmente. Para esto,:

* Se utiliza un método llamado Cargar Películas que recibe la plataforma como parámetro.
* Este método se debe llamar antes de iniciar el bucle principal (while true) para evitar duplicados y asegurar que las películas iniciales están listas y disponibles.
* Se agregan diferentes títulos, como Shrek, Titanic, Coco o Interestelar, para trabajar sobre ellos directamente.


Esto permite probar funcionalidades y agiliza el flujo durante el desarrollo. </p>

<h3 align="left">¿Cómo buscar una película por título ignorando mayúsculas y minúsculas? </h3>

<p align="left"> Buscar de manera flexible facilita la experiencia para el usuario. Para esto:

* Se crea un método Buscar por Título dentro de la plataforma.
* Este método recibe un string y recorre la lista con un bucle for.
* Se recomienda usar equalsIgnoreCase en lugar de equals para comparar los títulos, así el resultado es correcto sin importar las mayúsculas o minúsculas.
* Si la película existe, el método retorna la instancia encontrada; si no, retorna null. 

Al implementarlo en el flujo principal:

* El usuario ingresa el nombre a buscar mediante Scanner utils.
* Se llama el método de búsqueda y se compara el resultado con null.
* Si la película existe, se muestra su ficha técnica, que incluso puede mejorarse con emojis.
* Si no se encuentra, se avisa que el contenido buscado no existe en la plataforma.</p>