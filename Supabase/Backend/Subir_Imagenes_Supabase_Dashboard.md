<h2> Subir imagenes a Supabase bucket desde dashboard </h2>

<p align="left">Conecta en minutos Supabase storage con tu base de datos: sube imágenes al bucket público, copia la URL pública y enlázala a tus posts desde el dashboard. Este flujo manual te muestra cómo cada imagen alimenta el feed y los perfiles sin necesidad de código. </p>

<h3> ¿Cómo organizar carpetas y subir archivos en Supabase storage? </h3>

<p align="left"> Desde la interfaz de Supabase, entra a storage y abre el bucket que creaste. Corrige la estructura de carpetas para evitar errores: deja post y profile al mismo nivel. Si post quedó dentro de profile, elimínala con los tres puntitos, confirma la alerta, deselecciona y crea la carpeta al mismo nivel.

* Selecciona la carpeta post y elige agregar archivos.
* Sube las imágenes preparadas para pruebas.
* Verifica el mensaje de subida correcta.
* Haz clic en la imagen para ver el preview y sus detalles.
* Revisa la metadata: formato, peso y fecha de subida. 

La metadata será útil en tus proyectos para conocer la antigüedad y tipo del archivo e incluso, si lo decides, quién subió la imagen. 

<strong> ¿Cómo obtener y usar la URL pública en tus posts </strong>

Puedes obtener la URL desde el preview o desde el menú de los tres puntitos. Cópiala, pégala en una nueva pestaña y verifica que carga. La estructura refleja tu proyecto en Supabase, el servicio de storage, el nombre del bucket (por ejemplo, imágenes), la carpeta post y el archivo .jpg.

* Usa “obtener URL” y cópiala al portapapeles.
* Abre la URL en el navegador para confirmar acceso.
* Recuerda que esta imagen es pública y accesible sin login.
* Considera la privacidad: no todo contenido debe ser público.
* Aprovecha las otras opciones: renombrar, mover, descargar o eliminar.

Para las pruebas se usan imágenes públicas, lo que acelera el flujo y te permite ver resultados inmediatos en el navegador y luego en tu app.

<strong> ¿Cómo vincular la imagen con la base de datos y la API? </strong>

Abre la tabla de posts y edita la celda de la imagen con un doble clic. Selecciona todo, borra la URL de placeholder y pega la URL pública que copiaste. Presiona Enter para guardar. El cambio queda disponible en la API y en tu base de datos.

* Edita en línea con doble clic sobre la celda.
* Reemplaza el placeholder por la URL real.
* Guarda con Enter para aplicar cambios.
* El post ya apunta a su imagen correspondiente.
* Repite el proceso con los demás registros.

Habilidades y conceptos que refuerzas durante el proceso:

* Bucket público: almacena y sirve imágenes visibles en el feed y perfiles.
* Carpetas post y profile: organización correcta al mismo nivel para evitar errores.
* Preview y metadata: consulta de formato, peso y fecha para control y auditoría.
* URL pública: identificador que tu app usa para mostrar la imagen.
* Menú de tres puntitos: acciones rápidas como renombrar, mover, descargar o eliminar.
* Edición en tabla: actualización directa que impacta en la API y en la base de datos.
* Front end: luego podrás automatizar este flujo desde la interfaz de tu aplicación.


</p>