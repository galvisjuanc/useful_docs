<h2 align="left"> Pruebas de Aceptación en Despliegues Staging </h2>

<h3 align="left"> ¿Cómo determinamos si un deployment está listo para producción? </h3>

<p align="left"> Cuando se trata de despliegues en entornos de staging, la frase clave es "pruebas de aceptación". Estas pruebas son esenciales para verificar que un deployment es correcto antes de considerar moverlo a producción. Esto aplica tanto si estás usando Continuous Deployment (despliegue continuo) o Continuous Delivery (entrega continua), y sin importar si el proceso es manual o automatizado.

Lo importante es probar y asegurarse que el deployment es válido y funcional. De ahí la importancia de implementar pruebas robustas en staging, que es una infraestructura que imita de cerca el entorno de producción. </p>

<h3 align="left"> ¿Qué es una prueba de aceptación? </h3>

<p align="left"> Una prueba de aceptación es un proceso mediante el cual se verifica que el sistema cumple con los requisitos y expectativas antes de ser puesto en producción. En nuestro caso, vamos a realizar una sencilla prueba que consiste en hacer una operación aritmética, como la suma de tres más cuatro, y verificar que el resultado sea el esperado.

Esta prueba simple, aunque básica, es muy útil para ilustrar cómo comprobar si un deployment funciona correctamente. </p>