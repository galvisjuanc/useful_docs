<h2> Despliegue de API Flask en Docker paso a paso </h2>

<p align="left"> En cualquier proyecto de software, manejar eficazmente el back-end es esencial para lograr aplicaciones sólidas y confiables. Una excelente forma de abordar esto es mediante el despliegue de APIs construidas con Python en contenedores de Docker, facilitando consistencia y eficiencia entre diferentes entornos. </p>

<h3> ¿Qué es el back-end y cómo funciona con Python? </h3>

<p align="left"> El back-end es aquella parte del proyecto que gestiona la lógica y el procesamiento de datos en el servidor. Utilizando Python con frameworks como Flask, puedes crear APIs ligeras y efectivas con métodos específicos que devuelven información precisa. Por ejemplo, una API Flask puede contener el método GetMyInfo encargado de ofrecer información estructurada en formato JSON.

Para visualizar el resultado podrás ejecutar un comando simple desde la terminal:

    python -m flask run

Con este comando, la aplicación Flask comienza a ejecutarse localmente. Copiando la IP proporcionada con su respectivo puerto, luego puedes acceder desde un navegador agregando el método específico al final del URL (por ejemplo, /GetMyInfo). De esta forma, obtendrás confirmación visual del correcto funcionamiento de tu API.

<strong> ¿Cómo desplegar una API Python dentro de Docker? </strong>

Cuando deseas asegurar que la aplicación tenga el mismo comportamiento en cualquier ambiente, Docker es una herramienta extremadamente útil. Esto implica crear un Dockerfile para preparar tu aplicación y entorno.



</p>