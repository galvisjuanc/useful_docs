<h2> Examen POO Java </h2>

1.  ¿Cuál es la palabra clave que define una clase como abstracta?
<strong> abstract </strong>

2. ¿Cuál es la mejor práctica para facilitar la comprensión de mis proyectos de java al pasar a otro equipo de trabajo, o cuando un nuevo desarrollador se integra, o simplemente se terminó y estamos haciendo la entrega del código? <strong> Tener documentación lista en HTML usando Javadocs  </strong>

3. Tienes un software que monitorea el estado de una computadora. Este verifica si está encendida, apagada o suspendida.
Necesitamos manejar los estados ON, OFF, SUSPEND como una colección de constantes, ¿Qué será más conveniente usar?  <strong> Un Enumeration </strong> 

4. Cuando en un proyecto necesites implementar bases de datos independientemente del motor, ¿cuál es el API que debes integrar?  <strong> JDBC  </strong>

5. Necesito monitorear mis sesiones de conexión cuando me conecto con JDBC a una base de datos, ¿qué Clase debería usar?  <strong> Connection  </strong>

6. Tengo un sistema de mascotas en el que acabo de generar una consulta para traer todos los perritos que actualmente están en la tienda, ¿qué elemento de JDBC debería utilizar para manejar los resultados obtenidos?  <strong> ResultSet  </strong>

7. Estás trabajando en un programa que es catálogo de guitarras en el que dependiendo de la membresía del usuario debemos mostrar ciertas guitarras. Para usuarios premium mostrar guitarras premium. Las guitarras tienen un identificador en la base de datos que les hace pertenecer al tipo premium. Planeando realizar una consulta en la que generes un filtro de usuarios y guitarras premium. ¿Qué elemento de JDBC deberás usar para ejecutar una consulta con filtros?  <strong> PreparedStatement  </strong>

8. ¿Cuál debe ser el tiempo de vida de una lambda?  <strong> Corto  </strong>

9. Una interface funcional debe tener:  <strong> Un solo método abstracto  </strong>

10. ¿Cuál es la palabra clave que define una clase en Java? <strong> class  </strong>

11. ¿Cuál es la palabra clave para declarar constantes en Java?  <strong> final  </strong>

12. ¿Cuál es una caracteristica de las funciones puras?  <strong>No generan efectos secundarios. </strong>

13. ¿Qué es una función impura?  <strong> Una funcion que altera el estado de la aplicación o genera efectos secundarios. </strong>

14. ¿Cómo podemos reducir los efectos secundarios?  </strong> Limitando las secciones donde se requieran funciones impuras.  </strong>

15.  <strong> ¿De dónde provienen las funciones lambda?
Java 8 introdujo el concepto y otros lenguajes lo implementaron.  </strong>

16. ¿Cuál es la principal razon para usar Optional?  <strong> Proteger nuestro codigo ante la ausencia de datos.  </strong>

17. En un sistema de cajero automático, ¿qué tipo de dato sería más apropiado para almacenar el saldo de una cuenta bancaria?  <strong> double, porque permite almacenar valores decimales con precisión suficiente para operaciones financieras  </strong>

18. Al implementar la verificación de PIN en un cajero, ¿qué estructura de control es más apropiada para limitar los intentos a tres?  <strong> Un bucle while que incremente un contador de intentos y se ejecute mientras sea menor a tres.  </strong>

19.  <strong>En un sistema bancario, ¿cuál sería la estructura de datos más adecuada para almacenar un historial de transacciones que crece constantemente? HashMap, porque permite búsquedas más rápidas por identificador de transacción  </strong>

20. Al implementar un sistema que necesita asociar números de cuenta con sus respectivos saldos, ¿qué estructura sería más eficiente? HashMap, porque permite almacenar pares clave-valor y realizar búsquedas rápidas por número de cuenta

21. En el diseño de un cajero automático (ATM), ¿qué ventaja ofrece la composición al contener una lista de cuentas? Permite gestionar múltiples cuentas de forma independiente, facilitando búsquedas y operaciones específicas

22. En un sistema bancario, ¿cuál sería la aplicación más adecuada del patrón Singleton?
Para el gestor de configuración del sistema, asegurando una única fuente centralizada de configuraciones.

23.  <strong>En un sistema bancario, ¿cuál es la principal ventaja de usar Generics para manejar diferentes tipos de cuentas? Mejora el rendimiento del sistema al optimizar automáticamente las operaciones con diferentes tipos de cuentas. </strong>

24. ¿Cuál es la principal ventaja de usar @BeforeEach en lugar de @BeforeAll al configurar pruebas en JUnit?  <strong> Permite que cada prueba comience en un estado limpio y predecible, evitando interferencias entre pruebas.  </strong>

25. ¿Cuál es el propósito principal de las pruebas de sistema en un proyecto Java como JavaBank? Validar que la aplicación completa funcione correctamente en un entorno similar al de producción

26. ¿Cuál es la principal ventaja de utilizar expresiones lambda con functional interfaces en el procesamiento de colecciones? Permiten filtrar, mapear y reducir colecciones de manera más concisa y declarativa

27. En un sistema bancario, ¿cuál es la forma más eficiente de obtener todas las transacciones de depósito utilizando Stream API? Utilizar el método filter() con una expresión lambda que verifique si el tipo de transacción es DEPOSIT

28. ¿Cuál es la principal ventaja de usar la clase Optional en Java para manejar valores nulos? Permite manejar la presencia o ausencia de un valor de manera explícita, evitando errores de NullPointerException.

29. <strong> En un sistema bancario con múltiples transacciones simultáneas, ¿qué problema podría ocurrir si no se implementa sincronización adecuada?
Reducción del uso de memoria en el sistema durante operaciones concurrentes  </strong>

30. ¿Cuál es la forma correcta de manejar excepciones en operaciones asíncronas con CompletableFuture? Utilizar el método exceptionally() para capturar la excepción y devolver un valor alternativo o mensaje de error. </p>