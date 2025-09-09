<h2 align="left"> Historia y funcionamiento de Java con primer programa Hola Mundo </h2>

<p align="left"> Aprender Java es una excelente decisión, ya que su historia y arquitectura han impactado el mundo del desarrollo de software de manera profunda. Aquí entenderás conceptos clave, desde la JVM hasta la escritura de tu primer programa con buenas prácticas y el apoyo de herramientas modernas. </p>

<h3> ¿Qué es Java y cómo surgió? </h3>

<p align="left"> Java nació en 1995 en Sun Microsystems, bajo la guía del Green Team liderado por James Gosling. Su propósito original era programar para electrodomésticos inteligentes, bajo el nombre Oak. Sin embargo, su gran aporte fue permitir que un programa pudiera ejecutarse en cualquier dispositivo, sin importar el sistema operativo, bajo el lema WORA (Write Once, Run Anywhere): escribe una vez, ejecuta donde quieras. </p>

<h3> ¿Cómo funciona la Java Virtual Machine para lograr la portabilidad? </h3>

<p align="left"> El secreto de Java está en la Java Virtual Machine (JVM). A diferencia de otros lenguajes, que generan código específico para cada sistema operativo, Java usa la JVM como capa intermedia. Así, el código fuente se compila a un archivo .class en un lenguaje intermedio llamado byte code, que es multiplataforma. Luego, la JVM traduce este byte code en instrucciones específicas para el sistema operativo, ya sea Windows, Mac, Linux o hasta dispositivos embebidos como neveras y tostadoras.

Todo lo que necesitas para ejecutar aplicaciones Java es el Java Runtime Environment (JRE), que incluye la JVM. El Java Development Kit (JDK), por su parte, integra el JRE y además herramientas para escribir, compilar y construir programas. 

Resumiendo:

1. Se escribe el código fuente en un archivo .java.
2. El compilador transforma el código en bytecode (.class)
3. La JVM (Java Virtual Machine) lee el archivo de bytecode.
4. La JVM traduce el bytecode a instrucciones nativas del sistema operativo.
5. La aplicación se ejecuta en el dispositivo.

</p>

<h3> ¿Qué contiene el JDK? </h3>

<p align="left"> El JDK está compuesto del JRE y las herramientas de desarrollo (Compilador). Todo esto son las herramientas necesarias para escribir, compilar y construir un programa.

El JRE es el Java Runtime Environment es lo que se requiere para ejecutar aplicaciones Java. Este incluye el JVM que es quien realmente corre el programa.

</p>

<h3> ¿Cómo crear tu primer programa Hola Mundo en Java? </h3>

<p align="left"> El primer paso práctico es crear un paquete para organizar el código, usando la convención de nombres en minúsculas, separados por puntos (por ejemplo: platziplay).

Dentro de ese paquete, se crea una clase principal, generalmente llamada Main, empezando con mayúscula. Luego, se debe declarar el método principal, conocido como Main. Este método debe llamarse exactamente así y contar con la siguiente firma: public static void main(String[] args).

Java permite que herramientas como IntelliJ IDEA agilicen la escritura de código mediante atajos. Por ejemplo, al teclear SOUT y seleccionar la sugerencia, se genera automáticamente la línea completa System.out.println. Así, se puede escribir el conocido mensaje:

<code> System.out.println("¡Hola, mundo! 🧑‍💻"); </code>

Pulsando el botón de ejecución (play), verás el mensaje en la consola. Usar atajos como SOUT hace que programar sea más ágil y menos propenso a errores.</p>

<h3> ¿Por qué es importante comprender paquetes y convenciones en Java? </h3>

<p align="left"> Pulsando el botón de ejecución (play), verás el mensaje en la consola. Usar atajos como SOUT hace que programar sea más ágil y menos propenso a errores.

¿Por qué es importante comprender paquetes y convenciones en Java?
Organizar el código en paquetes siguiendo patrones claros mejora la legibilidad y mantenimiento. Los nombres de paquetes deben estar en minúscula y utilizar puntos como separadores. Escoger nombres significativos ayuda a identificar rápidamente la funcionalidad de cada parte del proyecto. </p>

<hr>

<h3> 🚀 What is the JVM? </h3>

<p align="left"> The JVM (Java Virtual Machine) is the engine that runs Java programs. Think of it like a translator + bodyguard for your code. It:

* Takes your compiled Java code (.class files = bytecode)
* Translates it into machine code your CPU understands
* Runs it, manages memory, and handles safety (e.g., catching exceptions, doing garbage collection) </p>

<h3> ⚙️ How It Works – Step by Step </h3>

1. You write Java code → HelloWorld.java
2. The Java compiler (javac) compiles it → Into bytecode (HelloWorld.class) Bytecode is platform-independent — works on any OS.
3. The JVM loads the bytecode JVM reads the .class file.
4. Bytecode is executed by the JVM
    * Either interpreted line-by-line
    * Or compiled at runtime to native machine code via JIT (Just-In-Time compiler)
5. JVM handles runtime stuff like:
    * Memory management (via garbage collection 🗑️)
    * Threading
    * Security
    * Exception handling