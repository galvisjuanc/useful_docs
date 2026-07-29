<h2> Despliegue de Aplicaciones con Docker Compose: Frontend y Backend </h2>

<p align="left"> Dominar la integración de frontend y backend en un proyecto es clave para desarrollar aplicaciones robustas y eficientes. Docker Compose facilita esta tarea permitiendo desplegar ambos entornos en contenedores separados pero comunicados entre sí de manera sencilla y estructurada. </p>

<h3> ¿Qué es Docker Compose y para qué sirve? </h3>

<p align="left"> Docker Compose es una herramienta que permite definir y gestionar múltiples contenedores Docker a través de un único archivo YAML. Utilizando Compose puedes configurar servicios como backend y frontend de forma clara y organizada, lo que facilita su despliegue y comunicación. </p>

<h3> ¿Cómo configurar los servicios en Docker Compose? </h3>

<p align="left"> Algunos puntos esenciales en la configuración incluyen:

* Indentación y estructura: semejante a la sintaxis en Python, usa tabulaciones para estructurar claramente los distintos servicios.
* Imagen y contexto: para cada servicio, especifica la imagen que se generará y la ubicación de su Dockerfile.
* Manejo de puertos: define claramente los puertos internos y externos mediante la sintaxis "puerto_externo:puerto_interno".
* Dependencias: utiliza la palabra clave depends_on para indicar explícitamente que un servicio depende de otro, como el frontend que depende del backend ya desplegado. 

Ejemplo práctico del archivo YAML sería:


    version: '3.7'
    services:
    backend:
        image: backend
        build:
        context: ./backend
        ports:
        - 5000:5000

    frontend:
        image: frontend
        build:
        context: ./frontend
        ports:
        - 8080:80
        depends_on:
        - backend

<strong> ¿Cómo interactúan los contenedores entre sí? </strong>

Los contenedores creados por Docker Compose forman parte de una red interna, permitiendo comunicarse directamente utilizando sus nombres de contenedor como dominios. Desde el exterior, podrías conectarte mediante localhost, pero internamente es necesario usar nombres asignados por Docker Compose (por ejemplo, clase19-backend1).


</p>