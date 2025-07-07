<h2 align="left"> Herramientas IAC </h2>

<h3> ¿Qué es la Infraestructura como Código? </h3>

<p align="left"> 
La Infraestructura como Código (IaC) consiste en definir y gestionar la infraestructura de TI mediante archivos de código. Esto permite que, al ejecutar un programa, se cree una infraestructura basada en esos archivos. </p>

<h3> Herramientas para IaC </h3>

<p align="left"> 
Objetivo Principal: Replicación de Ambientes
El uso de Terraform permite la creación y gestión de entornos de infraestructura. Un proceso típico es:

1. Crear un ambiente base (ejemplo: "producción") con todos los recursos necesarios para la aplicación.
2. Generar versiones reducidas de ese ambiente con menos memoria, procesos, instancias o recursos.
3. Guardar la configuración en un sistema de control de versiones para asegurar su accesibilidad y trazabilidad. </p>

<h3> Como funciona Terraform </h3>

<p align="left"> 
Terraform utiliza archivos de configuración donde se definen los recursos a desplegar. Estos archivos se procesan mediante comandos en la línea de comandos (CLI) de Terraform para implementarlos en la nube correspondiente.

Terraform también genera un archivo de estado que almacena la configuración y permite gestionar cambios futuros en la infraestructura. Este archivo debe almacenarse en un lugar seguro y es fundamental para aplicar modificaciones controladas. </p>


