<h2 align="left"> Examen Curso Profesional de DevOps </h2>

<p align="left">  

1. ¿Por qué es importante tener vendor lock in de dependencias? <i> Porque se instalan más rapido. </i>

2. ¿Cómo podríamos inspeccionar si nuestras dependencias son seguras? <strong> Utilizando un vendor o herramienta que las verifique contra una base de datos de dependencias. </strong>

3. ¿Cómo podríamos determinar si nuestra página web funciona a través del mundo? <strong> Usar un vendor que haga prueba a través del mundo. </strong>

4. ¿Por qué no subimos las imágenes de docker de nuestro servicio al docker repository desde la máquina local? <strong>Queremos que venga de un sitio central que se puede auditar. </strong>

5. Now hace un rolling deployment. <strong> Falso. </strong>

6. Si quisieras probar un nuevo feature de la página web con un % del tráfico por un tiempo, ¿cuál estrategia utilizarías? <i> Blue green deployment. </i>

7. Según los conceptos de Site Realiability Engineering (SRE) ¿cuántas veces debo hacer deploy al día? <strong> Es relativo a cuánto margen de error tenemos disponible para usar. </strong>

8.
Antes de hacer merge en master, y tener seguridad de que el código es el adecuado, ¿qué debe ocurrir?

Algún compañero debió verificarlo y el CI debió retornar exitosamente.

9.
Si fallan los acceptance tests luego de un deployment a production ¿qué debes hacer?

Verificar si realmente es una falla y empezar a “rollback” a una versión previa.

10.
Histogram es la representación gráfica la métrica que debo usar para medir latencia.

Verdadero.

11.
Log level fatal es ideal para notificar que el servicio comenzó a aceptar conexiones.

Falso.

12.
Los vendors pueden recibir cualquier tipo de data que les envíes.

Verdadero.

13.
Code coverage 100% garantiza que no habrá problemas de producción.

Verdadero.

14.
Para asegurarnos de que nuestras dependencias no cambien sin nuestro consentimiento, no podemos solamente depender de los layers de docker.

Verdadero.

15.
Los artefactos que utilizamos para describir el código que corre en producción deben poder reproducirse desde 0.

Verdadero.

</p>