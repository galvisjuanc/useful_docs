<h2> Examen Curso Java </h2>

1.  ¿Cuál es el propósito principal de la palabra clave `final` en Java cuando se aplica a la declaración de una variable?
<strong> Asegurar que el valor de la variable no pueda ser modificado después de su asignación inicial.</strong>

2. ¿Cuál es el objetivo principal del principio de abstracción en la programación orientada a objetos? <strong> Identificar y representar las características y comportamientos esenciales de un objeto relevantes para un contexto específico. </strong>

3. ¿Qué implicación directa tiene convertir el método `reproducir()` en un método abstracto dentro de la clase `Contenido`?
<strong> Obliga a que todas las subclases no abstractas, como `Pelicula`, implementen su propia versión del método `reproducir()`. </strong>

4. Un programador ejecuta el siguiente código: long numeroGrande = 25000000000L; int numeroPequeno = (int) numeroGrande; System.out.println(numeroPequeno); ¿Cuál es el resultado más probable que se imprimirá en la consola y por qué? <strong>
Se imprimirá un número negativo inesperado debido a un desbordamiento de datos (overflow). </strong>

5. ¿Cuál es la ventaja principal de utilizar una interfaz como `Promocionable` en lugar de agregar el método `promocionar()` directamente en la clase `Documental`?
<strong> Permite definir un comportamiento común que puede ser implementado por otras clases en el futuro, promoviendo el bajo acoplamiento y la extensibilidad. </strong>

6. ¿Cuál es la diferencia fundamental en cómo Java maneja los tipos de datos primitivos y los tipos por referencia en términos de su valor por defecto?
<strong> Los primitivos tienen valores por defecto numéricos o booleanos (0, false), mientras que los de referencia tienen `null` por defecto. </strong>

7. Una empresa necesita distribuir su nueva aplicación de escritorio Java. Los desarrolladores usarán sus máquinas para crear y probar el software, mientras que los clientes solo lo ejecutarán. ¿Qué paquetes de software de Java deberían instalar los desarrolladores y los clientes, respectivamente?
<strong> Los desarrolladores necesitan el JDK (Java Development Kit) y los clientes solo el JRE (Java Runtime Environment). </strong>

8. ¿Cuál es la principal ventaja de utilizar `String.join()` en lugar de la concatenación tradicional con el operador `+` para construir una línea de texto a partir de los atributos de un objeto, según lo explicado en la clase?
<strong> Mejora significativamente la legibilidad y el mantenimiento del código al especificar un único delimitador para una secuencia de elementos. </strong>

9. ¿Cuál es la principal ventaja de refactorizar una estructura de múltiples `if-else if` a un `switch-case` para manejar las opciones del menú, como se describe en la clase?
<strong> Mejora la legibilidad y el mantenimiento del código cuando se evalúa una única variable contra múltiples valores constantes. </strong>

10. Según lo explicado en la clase, ¿cuál es la función principal de una clase en la programación orientada a objetos en Java?
<strong> Servir como un molde o plantilla para crear objetos que comparten una estructura y comportamiento definidos. </strong>

11. ¿Cuál es el propósito principal de envolver el código de lectura de archivos con `Files.readAllLines()` dentro de un bloque `try-catch`?
<strong> Para manejar la excepción de tipo `IOException` que podría ocurrir si el archivo no existe o no se puede leer. </strong>

12. En la clase, se declara la lista como `private List contenido;`. ¿Cuál es el propósito principal de usar genéricos (``) en esta declaración? <i>
Optimizar el uso de la memoria al pre-asignar espacio para un número fijo de películas. 
Repasar </i>

13. ¿Cuál es el propósito principal del operador `instanceof` en Java, tal como se demostró en la clase para manejar películas y documentales?
<strong>
 Verificar el tipo real de un objeto durante la ejecución para aplicar lógica específica a cada tipo. </strong>

14. Al analizar el método `capturarGenero()` en `ScannerUtils`, ¿cuál es el propósito clave de combinar un bucle `while(true)` con un bloque `try-catch` para gestionar la entrada del usuario?
<strong> Asegurar que el programa solicite repetidamente la entrada hasta que el usuario ingrese un texto que corresponda a un valor válido del enum `Genero`. </strong>

15. Se quiere implementar un método que devuelva las películas peor calificadas de la plataforma, es decir, ordenadas de menor a mayor calificación. ¿Cuál implementación del método `sorted()` dentro de un stream de `Contenido` lograría correctamente este resultado?

<i> sorted(Comparator.comparing(Contenido::getCalificacion).reversed()) </i>

16. ¿Cuál es la filosofía o característica principal de la Programación Orientada a Objetos, según se describe en la clase? <strong> Busca llevar al código las mismas cosas que vemos en el mundo real, modelando todo como objetos. </strong>