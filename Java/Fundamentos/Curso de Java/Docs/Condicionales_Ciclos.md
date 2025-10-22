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