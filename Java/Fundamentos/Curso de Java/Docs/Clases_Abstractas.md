<h2 align="left"> Clases abstractas y métodos abstractos en Java </h2>

<h3 align="left"> ¿Qué es un contenido en una plataforma de streaming y por qué usar clases abstractas? </h3>

<p align="left"> El término contenido en plataformas de streaming es muy general: puede significar una película, una serie o incluso un evento en vivo. Este concepto es abstracto porque representa una idea general que luego debe concretarse en tipos específicos.

En Java, esto se traduce en crear una clase abstracta. Declararla con la palabra reservada abstract impide que sea instanciada directamente y obliga a que otras clases (por ejemplo, película o documental) la especialicen.

Ventajas de usar clases abstractas: 
* Evitas la creación de objetos demasiado generales que no deberían existir por sí solos.
* Garantizas que cada tipo de contenido defina sus propias particularidades. </p>

<h3 align="left"> ¿Cómo implementar un método abstracto y forzar la especialización en las subclases? </h3>

<p align="left"> Un método abstracto en la clase abstracta define solo la firma del método, sin su implementación. Es decir, no hay cuerpo, solo punto y coma. Por ejemplo:

    public abstract void reproducir();

Esto indica que todas las subclases deben forzarmente implementar el método. Java lo confirma mostrando un error si no lo haces. Así, cada clase hija (como película o documental) debe declarar su versión personalizada del método reproducir, adaptada a sus necesidades.

Características de los métodos abstractos: 
* Declarados con abstract y sin cuerpo. 
* Solo pueden colocarse en clases abstractas. 
* Obligatorio que las subclases lo sobrescriban. </p>

<h3 align="left"> ¿Cómo beneficia el polimorfismo al reproducir distintos tipos de contenido? </h3>

<p align="left"> Al definir métodos abstractos y sobrescribirlos, se aprovecha el polimorfismo: puedes manejar objetos de distintos tipos (película, documental) usando referencias genéricas (de tipo contenido). Al llamar a reproducir(), cada subclase ejecuta su propia versión.

Ejemplo visto en el transcript: 
* Si llamas a reproducir sobre una película, muestra: "Reproduciendo la película Titanic". 
* Si lo haces sobre un documental, el mensaje es: "Reproduciendo el documental Oasis, narrado por Alejandro Ramírez".

Esto significa que desde la lógica general de la plataforma, solo es necesario trabajar con Contenido, pero el comportamiento siempre es el apropiado para cada tipo. </p>