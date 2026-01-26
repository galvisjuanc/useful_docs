<h2 align="left"> Control de excepciones con @RestControllerAdvice en Spring Boot </h2>

<h3 align="left"> ¿Por qué es clave el control de errores en una API Spring? </h3>

<p align="left"> Gestionar los posibles errores garantiza una experiencia de usuario transparente y una API robusta. Por ejemplo, al guardar películas, puede ser necesario evitar que existan títulos duplicados—aunque la base de datos lanza un error, debemos traducirlo en mensajes útiles, amigables y específicos para quien consume la API.

* Evitar errores inesperados reduce frustración del usuario.
* Centralizar excepciones simplifica el mantenimiento y mejora la trazabilidad.
* Proveer mensajes claros ayuda a los desarrolladores a comprender rápidamente los problemas. </p>