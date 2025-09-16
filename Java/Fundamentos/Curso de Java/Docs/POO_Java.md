<h2 align="left"> Qué es la programación orientada a objetos y sus ventajas </h2>

<p align="left"> La programación orientada a objetos es reconocida como un enfoque sólido y flexible para analizar, diseñar y desarrollar software. Se basa en la idea de traducir al código los elementos que nos rodean, considerando cada entidad como un objeto, tanto si es real como abstracta. Esta visión permite construir aplicaciones que simulan la realidad y favorecen una organización clara y ordenada del código. </p>

<h3> ¿Cómo define la programación orientada a objetos a un "objeto"?
 </h3>

<p align="left"> Un objeto es cualquier cosa —real o abstracta— que almacena datos y define operaciones para manipular dichos datos. Por ejemplo, en el contexto de un proyecto como Platzi Play, los objetos pueden ser "película", "plataforma", "usuario" o "categoría". Cada uno de ellos guarda datos propios y tiene funciones asociadas para operar sobre esa información.

* Un objeto incluye datos y operaciones relacionadas.
* Los objetos representan entidades del mundo real o conceptos abstractos.
* En cualquier proyecto, los objetos reflejan elementos del contexto específico del software.</p>

<h3> ¿Cuáles son las ventajas principales de usar programación orientada a objetos? </h3>

<p align="left"> La programación orientada a objetos destaca por varios beneficios directos, entre los cuales resaltan cuatro:

* Reusabilidad: Permite reutilizar el mismo código en distintas partes del proyecto o diferentes aplicaciones, facilitando el trabajo y acelerando el desarrollo.
* Mantenibilidad: Es más sencillo entender y actualizar el código, ya que se organiza de forma modular y clara.
* Modificabilidad: Ofrece la posibilidad de modificar o sumar nuevos componentes sin afectar el funcionamiento del código existente.
* Fiabilidad: Facilita el control de errores y la estabilidad general del software, al dividirlo en partes más pequeñas y manejables.</p>

<h3> ¿Cuáles son los pilares fundamentales de la programación orientada a objetos? </h3>

<p align="left"> Esta metodología se apoya en cuatro pilares fundamentales:

1. Abstracción.
2. Encapsulamiento.
3. Herencia.
4. Polimorfismo.</p>

<h3> Cuatro Ideas Principales </h3>

<p align="left"> La Programación Orientada a Objetos (POO) es una manera de programar donde el código se organiza en objetos, que son como “modelos” de cosas reales o imaginarias. Cada objeto tiene propiedades (datos que lo describen) y métodos (acciones que puede hacer). 

Por ejemplo, si creamos un objeto Carro, sus propiedades pueden ser el color, la marca y el modelo; y sus métodos podrían ser encender, acelerar o frenar.

La POO se basa en cuatro ideas principales:

1. Clases: moldes para crear objetos.
2. Objetos: lo que obtenemos al usar una clase.
3. Herencia: cuando una clase puede heredar características de otra.
4. Encapsulamiento: proteger la información para que solo se acceda de forma controlada.

Usar POO hace que el código sea más organizado, fácil de leer y reutilizable.

</p>

<hr>

<h3> 🧠 What is an Object in Java? </h3>

<p align="left"> 

    * An object is a real, usable thing created from a class.  
    
    * It has state (stored in fields / variables).

    * Behavior (defined by methods).


</p>

<h3> 🎮 Real-Life Analogy </h3>

<p align="left"> 

Let’s say you have a class called Car. That's just the blueprint.

    public class Car {
        String color;
        int speed;
        
        public void drive() {
            System.out.println("Vroom!");
        }
    }

Now, let’s create an object from that blueprint:

    Car myCar = new Car();
    myCar.color = "Red";
    myCar.speed = 120;
    myCar.drive();  // Output: Vroom!

</p>