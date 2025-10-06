<h2 align="left"> Constructores en Java para inicializar objetos con datos </h2>

<h3 align="left"> ¿Qué es un constructor en Java y por qué usarlo? </h3>

<p align="left"> El constructor en Java es un método especial que tiene exactamente el mismo nombre que la clase y no retorna ningún valor. Sirve para inicializar los atributos de los objetos desde el primer momento en que son creados.

* Al crear un objeto con new Película(), sin parámetros, se utiliza el constructor por defecto.
* Si agregas un constructor propio (por ejemplo, que reciba título, duración y género), Java ya no brinda uno por defecto.
* Personalizar el constructor ayuda a que los objetos tengan la información necesaria desde su origen, como el título, duración y género de una película.

 </p>

<h3 align="left"> ¿Cómo definir y utilizar un constructor personalizado? </h3>

<p align="left"> Definir un constructor personalizado es sencillo y sigue estas pautas:

* El constructor se crea después de los atributos y se llama igual que la clase.
* Los parámetros que recibes se asignan a los atributos del objeto usando la palabra reservada this para distinguirlos.
* Puedes asignar valores por defecto a otros campos; por ejemplo, puedes inicializar la fecha de estreno con la fecha actual o marcar el atributo disponible como true.

 </p>

<h3 align="left"> ¿Cómo manejar múltiples constructores y buenas prácticas? </h3>

<p align="left"> Una clase puede tener más de un constructor, adaptándose a diferentes necesidades al crear objetos. Usando herramientas como IntelliJ, puedes generar constructores fácilmente e incluir diferentes combinaciones de parámetros como título, duración, género y calificación.

* Para usar varios constructores, puedes utilizar la tecla Control al seleccionarlos.
* Puedes llamar a otro constructor usando this() dentro de un constructor diferente para evitar repetición de código.
* Es posible llamar métodos desde el constructor para agregar lógica, como validar y asignar calificación desde un método calificar.


Las buenas prácticas recomiendan que cada clase tenga constructores que reciban los datos fundamentales que el objeto necesita desde su nacimiento. Esto evita problemas y mejora la limpieza del código.

 </p>

<h3 align="left"> ¿Cómo crear constructores para diferentes clases como usuario? </h3>

<p align="left"> El uso de constructores se aplica de igual manera en otras clases, como usuario. Puedes generar un constructor que inicialmente solo reciba el nombre, y luego, si lo deseas, editar para agregar más datos como email. También puedes asignar valores por defecto, como la fecha de registro.

* Así, al crear un usuario con nombre y email, el constructor solo acepta esos parámetros.
* Si intentas pasar parámetros distintos, Java marcará un error porque ese constructor no los acepta. </p>