<h2 align="left"> Pruebas de Aceptación en Despliegues Staging </h2>

<h3 align="left"> ¿Cómo determinamos si un deployment está listo para producción? </h3>

<p align="left"> Cuando se trata de despliegues en entornos de staging, la frase clave es "pruebas de aceptación". Estas pruebas son esenciales para verificar que un deployment es correcto antes de considerar moverlo a producción. Esto aplica tanto si estás usando Continuous Deployment (despliegue continuo) o Continuous Delivery (entrega continua), y sin importar si el proceso es manual o automatizado.

Lo importante es probar y asegurarse que el deployment es válido y funcional. De ahí la importancia de implementar pruebas robustas en staging, que es una infraestructura que imita de cerca el entorno de producción. </p>

<h3 align="left"> ¿Qué es una prueba de aceptación? </h3>

<p align="left"> Una prueba de aceptación es un proceso mediante el cual se verifica que el sistema cumple con los requisitos y expectativas antes de ser puesto en producción. En nuestro caso, vamos a realizar una sencilla prueba que consiste en hacer una operación aritmética, como la suma de tres más cuatro, y verificar que el resultado sea el esperado.

Esta prueba simple, aunque básica, es muy útil para ilustrar cómo comprobar si un deployment funciona correctamente. </p>

<h3 align="left"> Paso a paso para realizar una prueba de aceptación </h3>

<p align="left"> 

1. Modificar el job de deployment: Iniciaremos añadiendo una simple línea de código al job de deployed web up staging, que corresponderá a un comando curl para sumar tres más cuatro.

    <code> curl http://mi-endpoint.com/sumar?num1=3&num2=4 </code>

2. Guardar y reutilizar la URL: Guardaremos la URL del endpoint en una variable llamada resolveURL.

    <code> resolveURL=$(curl http://mi-endpoint.com/sumar?num1=3&num2=4) </code>

3. Realizar la prueba de la operación: Pasamos resolveURL como parámetro al comando curl y utilizamos grep para verificar que el resultado es el esperado (7).

    <code> curl $resolveURL | grep 7 </code>

4. Manejo de errores: Si grep no encuentra el número 7, el build fallará. Esto parará todo el pipeline automáticamente en caso de que algo no funcione como debería.

 </p>


<h3 align="left"> Simulación de un fallo </h3>

<p align="left"> Para visualizar un error, podemos simplemente cambiar la expectativa del resultado de la suma a un número incorrecto. Cambiar el test a "34" en lugar de "7" permitirá ver cómo el sistema marca un error:

<code> curl $resolveURL | grep 34 </code>

Esto generará un "failure", y el sistema indicará el fallo visualmente, deteniendo cualquier proceso de despliegue adicional. </p>