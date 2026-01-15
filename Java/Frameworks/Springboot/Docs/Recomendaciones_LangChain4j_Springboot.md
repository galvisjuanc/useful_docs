<h2 align="left"> Sistema de recomendaciones de películas con IA en Java </h2>

<h3 align="left"> ¿Cómo eliminar películas en la base de datos usando Java? </h3>

<p align="left"> Eliminar películas es sencillo empleando la notación @DeleteMapping. El método recibe el ID de la película como variable de ruta y responde con un ResponseEntity.ok().build(), ya que el método delete no retorna datos. El uso de Void en el ResponseEntity es importante porque Delete no regresa un objeto, solo indica que la operación fue realizada.

Para probar esta operación, se puede utilizar Postman enviando una petición DELETE al endpoint correspondiente con el ID de la película. Si el borrado es exitoso, se recibirá un status code 200 y el cuerpo estará vacío, confirmando la eliminación. </p>