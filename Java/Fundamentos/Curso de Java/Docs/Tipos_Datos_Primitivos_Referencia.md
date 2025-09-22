<h2 align="left"> Tipos de datos primitivos y por referencia en Java </h2>

<p align="left"> Java organiza sus tipos de datos en dos grandes grupos: primitivos y por referencia (objetos).

* Primitivos: Son ocho, se usan para valores simples como números, caracteres y booleanos. Todos empiezan con minúscula y son palabras reservadas.
    * Integers: byte, short, int, long
    * Floating-Point: float, double
    * Character: char
    * Boolean: boolean

* Por referencia u objetos (Non-Primitive): Incluyen clases integradas de Java como String, Date o LocalDate, y cualquier clase que crees, como Película o Usuario. 
    * String
    * Array
    * List
    * Set
    * Stack
    * Vector
    * Dictionary
    * All user-defined classes

Ambos tipos se identifican fácilmente por cómo se nombran y dónde se usan. Los primitivos tienen un valor por defecto (cero para números, false para boolean), mientras que los objetos empiezan como null si no son inicializados. </p>

<h3> ¿Por qué y cómo usar fechas en Java? </h3>

<p align="left"> El manejo de fechas es parte esencial de muchos programas. Antes de Java 8, se usaba la clase Date (del paquete java.util). Sin embargo, ahora se recomienda utilizar LocalDate y LocalDateTime porque son más intuitivas y modernas. 

* LocalDate almacena solo día, mes y año.
* LocalDateTime permite guardar también horas, minutos y segundos, además de la fecha.

<strong>¿Cómo inicializar fechas con LocalDate y LocalDateTime? </strong>

Para asignar una fecha específica, se emplea el método LocalDate.of:

    LocalDate fechaEstreno = LocalDate.of(2018, 10, 15); // 15 de octubre de 2018

Imprimir esta variable muestra solo la parte de la fecha. Si se desea agregar hora, minuto y segundo, LocalDateTime es el adecuado:

    LocalDateTime fechaRegistro = LocalDateTime.of(2022, 12, 24, 17, 15, 14);

También se puede usar LocalDateTime.now para capturar la fecha y hora actual del sistema:

    LocalDateTime fechaActual = LocalDateTime.now();

Ambas formas permiten trabajar con la información temporal que requiera una aplicación.


</p>

<h3> ¿Cuáles son las mejores prácticas al elegir tipos de datos en Java? </h3>

<p align="left"> Escoger el tipo de dato adecuado aumenta la claridad y mantenimiento del código.

* Usa tipos primitivos para valores simples que nunca serán null.
* Prefiere objetos cuando se necesita mayor funcionalidad, como con fechas y cadenas de texto.
* Aprovecha los métodos que las clases de fecha modernas ofrecen, como acceso a partes individuales y facilidad para el manejo de zonas horarias. </p>