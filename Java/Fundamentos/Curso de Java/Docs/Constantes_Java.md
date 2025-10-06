<h2 align="left"> Constantes en Java: inmutabilidad con static final </h2>

<h3 align="left"> ¿Qué es una constante en Java y por qué usarla? </h3>

<p align="left"> Una constante es un valor único e inmutable que se asigna una sola vez y no puede modificarse durante la ejecución del programa. Su uso es esencial cuando necesitas asegurar que determinados valores, como configuraciones o límites, permanezcan siempre iguales. Esto ayuda a mantener el código limpio y comprensible.

* Las constantes se definen con las palabras public static final.
* Al ser static, pertenecen a la clase y no a una instancia específica.
* La palabra final indica que el valor no puede cambiar.

 </p>

<h3 align="left"> ¿Cómo se declaran constantes en clases Java? </h3>

<p align="left"> Definir una constante en una clase es una buena práctica, sobre todo para compartir valores comunes en todo el código. Se recomienda nombrarlas en mayúsculas, una convención muy aceptada en Java.

Ejemplo simple para declarar una constante pública de tipo String:

    public static final String VERSION = "1.0.0";

De esta forma, el valor de VERSION no podrá modificarse después de ser asignado. Si intentas hacer, por ejemplo:

    VERSION = "2";

Observarás un error: no se puede asignar un valor a una variable final, lo que demuestra que la constante es inmutable.

 </p>

<h3 align="left"> ¿Cuándo conviene utilizar constantes en un proyecto Java? </h3>

<p align="left"> Las constantes son perfectas para cualquier dato que no debe cambiar durante la ejecución:

* Configuraciones fijas como nombres de plataforma o versiones.
* Límites y datos generales usados en toda la app.
* Objetos que, aunque sean de otro tipo, no se modifican (como un Scanner compartido).

 </p>