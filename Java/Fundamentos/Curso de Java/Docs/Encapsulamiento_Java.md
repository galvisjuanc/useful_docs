<h2 align="left"> Encapsulamiento en Java: Atributos privados y métodos getter y setter </h2>

<p>
El encapsulamiento es un concepto fundamental en la programación orientada a objetos (POO). Permite ocultar o proteger los detalles internos de una clase y controlar cómo se accede a su información. Este enfoque incrementa la seguridad, evita errores y facilita el mantenimiento del código.
</p>

<h3 align="left"> ¿Cómo funciona el encapsulamiento en Java? </h3>

<p align="left"> El encapsulamiento en Java está directamente relacionado con la visibilidad de los atributos de una clase. Una práctica recomendada es declarar los atributos como privados para impedir el acceso directo desde fuera de la clase. Así, solo se puede interactuar con ellos a través de métodos públicos.

* Los atributos privados no pueden ser modificados ni leídos desde fuera de la clase.
* Los métodos públicos permiten controlar cómo se accede o modifica la información.
* Utilizar modificadores de acceso privados protege los datos sensibles de la clase.

 </p>

 <h3 align="left"> ¿Para qué sirven los métodos getter y setter en Java? </h3>

<p align="left"> Cuando se necesita acceder o modificar los valores de los atributos privados, se usan los métodos getter y setter. Los getter permiten obtener información, mientras que los setter se utilizan para establecer valores.

* Un getter devuelve el valor del atributo sin modificarlo. Ejemplo: getTitulo() retorna el título de la película.
* Un setter permite cambiar el valor de un atributo si el diseño lo permite. Ejemplo: setDescripcion() modifica la descripción de la película.
* Es crucial decidir qué atributos necesitarán setters, especialmente si no conviene que el valor cambie tras la creación del objeto.

En Java, los booleanos siguen la convención de utilizar is en el getter en vez de get, por claridad al usar condiciones.

 </p>

  <h3 align="left"> ¿Qué prácticas se recomiendan para escribir clases seguras y robustas? </h3>

<p align="left"> Seguir estructuras y convenciones claras refuerza la robustez del software y asegura clases seguras:

* Declarar atributos privados por defecto en cada clase.
* Ubicar los métodos getter y setter al final de la clase, luego de atributos, constructores y métodos principales.
* Crear getters solo para los atributos que deban ser consultados desde fuera de la clase.
* Agregar setters únicamente cuando sea indispensable modificar ciertos atributos.
* Analizar si conviene permitir cambios en atributos clave; por ejemplo, el título de una película generalmente no debe modificarse.
* Los métodos públicos son los únicos accesibles externamente, lo cual da mayor control sobre los datos.

 </p>