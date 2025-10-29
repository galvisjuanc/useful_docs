<h2 align="left"> Implementación de menús interactivos con while y switch en Java </h2>

<h3 align="left"> ¿Cómo funcionan el ciclo while y la captura de opciones en Java? </h3>

<p align="left"> El ciclo while true permite que la plataforma esté siempre atenta a instrucciones del usuario, repitiendo un menú con las siguientes opciones:

* Agregar contenido.
* Mostrar todo.
* Buscar por título.
* Eliminar contenido.
* Salir.

Al preguntar por la opción elegida, el programa espera un valor numérico. Si el usuario decide salir (opción cinco), el programa termina con system.exit(0). </p>

<h3 align="left"> ¿Cómo se maneja la entrada inválida del usuario usando Scanner? </h3>

<p align="left"> Es común que los usuarios escriban datos en un formato distinto al esperado. Por ejemplo, si el programa pide un número y recibe texto, ocurre un input mismatch exception. Para evitarlo:

* Se utiliza un while adicional que verifica con hasNextInt() o hasNextDouble() si la entrada es válida.
* Cuando no lo es, se informa con un mensaje como “Dato no aceptado” y se descarta usando scanner.next().
* Este ciclo se repite hasta recibir un valor correcto. </p>

<h3>¿Por qué usar constantes y switch case en vez de múltiples if-else?
</h3>

<p> Usar constantes mejora la legibilidad y el mantenimiento del código. Por ejemplo:

    public static final int AGREGAR = 1;
    public static final int MOSTRAR_TODO = 2;
    public static final int BUSCAR_POR_TITULO = 3;
    public static final int ELIMINAR = 4;
    public static final int SALIR = 5;
    
Esto permite cambiar los valores en un solo lugar y referenciarlos en el resto del programa.

Además, utilizar switch case sobre varias opciones facilita entender el flujo y reduce errores. Por cada caso, se ejecuta el bloque correspondiente (agregar, mostrar, buscar, eliminar, salir) y queda abierto para integrar nuevas funciones.

</p>

<h3> ¿Cómo se prueban y enlazan las acciones dentro del menú </h3>

<p> El diseño del menú interactivo permite agregar contenido (como una película con nombre, género, duración y calificación), mostrar todos los títulos, y salir correctamente. Las opciones de buscar por título y eliminar están previstas para implementarse en pasos siguientes. </p>