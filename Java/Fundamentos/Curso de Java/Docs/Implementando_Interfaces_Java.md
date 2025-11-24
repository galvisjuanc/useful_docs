<h2 align="left"> Creación e implementación de interfaces en Java </h2>

<h3 align="left"> ¿Qué es una interfaz en Java y para qué sirve? </h3>

<p align="left"> Las interfaces permiten definir un conjunto de métodos que varias clases pueden implementar, independientemente de su jerarquía. Así puedes crear estructuras más versátiles, listas para futuras expansiones sin modificar el código existente.

* Las interfaces se declaran usando la palabra reservada interface después del modificador de acceso.
* Dentro de una interfaz, solo se definen los métodos, sin implementar su lógica (a menos que sea default o static, pero en este caso no se utiliza default).
* Los métodos de una interfaz actúan como contratos: cualquier clase que implemente la interfaz debe definir la lógica de esos métodos. </p>

<h3 align="left"> ¿Cómo implementar una interfaz en Java con ejemplos prácticos? </h3>

<p align="left"> En el proyecto se crea la interfaz Promocionable, que contiene solo un método:

    public interface Promocionable {
        String promocionar();
    }

Posteriormente, la clase Documental extiende de otra clase llamada Contenido e implementa la interfaz Promocionable. Eso significa que debe definir el método promocionar: 

    @Override
    public String promocionar() {
        return "Descubre el documental " + this.getTitulo() + " narrado por " + this.getNarrador();
    }
Así, cuando se ejecuta el programa, el sistema muestra los mensajes promocionales personalizados, como: Descubre el documental Oasis, narrado por Alejandro Ramí.

</p>

<h3 align="left"> ¿Por qué usar interfaces mejora la arquitectura del software? </h3>

<p align="left"> Las interfaces facilitan que el sistema pueda crecer sin complicaciones ni dependencias excesivas entre clases, y este patrón también sirve fuera del ejemplo de documentales </p>

<h3 align="left"> ¿Qué ventajas tienen frente a otros enfoques? </h3>

<p align="left"> 

* Menor acoplamiento: Evitas atar la lógica a tipos concretos, permitiendo más flexibilidad.
* Extensibilidad: Nuevas funcionalidades (por ejemplo, más servicios de pago) pueden agregarse sin alterar lo ya implementado.
* Dependencia de abstracciones: Sigues el principio SOLID de invertir dependencias, donde el sistema depende de contratos (interfaces) en vez de implementaciones específicas. </p>

<h3 align="left"> ¿Cómo se aplica este patrón a servicios reales? </h3>

<p align="left"> Pensemos en un sistema de pagos que procesa servicios como Stripe, PayPal o tarjetas de crédito. Todos pueden implementar una misma interfaz llamada ServicioDePagoEnLinea con un método procesarPago.

Esto permite que el sistema procese pagos sin preocuparse por los detalles de cada proveedor. Solo invoca procesarPago y deja a la clase concreta encargarse de la lógica interna. </p>