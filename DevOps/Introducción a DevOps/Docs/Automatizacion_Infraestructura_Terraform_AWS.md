<h2 align="left"> Automatización de Infraestructura con Terraform y AWS </h2>

<h3 align="left"> ¿Cómo crear un pipeline de infraestructura automática? </h3>

<p align="left"> Crear una infraestructura de manera automática es una habilidad esencial en la nube, y con la ayuda de herramientas como Terraform, AWS CodePipeline, CodeCommit, y CodeBuild, es posible lograrlo eficientemente. Estos servicios facilitan la orquestación y gestión automatizada, asegurando implementaciones consistentes y repetibles. </p>

<h3 align="left"> ¿Qué servicios necesitas para el pipeline automático? </h3>

<p align="left"> Para empezar, debes configurar los siguientes servicios. Cada uno desempeña un papel crucial en el proceso de automatización y despliegue de infraestructura.

* AWS CodePipeline: Orquesta el proceso de implementación, desde la obtención del código hasta su despliegue.
* AWS CodeCommit: Almacena tus archivos de código (en este caso, archivos de Terraform) de manera segura.
* AWS CodeBuild: Ejecuta procesos de construcción y tests. Aquí, se utilizarán para los pasos de terraform plan y terraform apply.
* AWS S3 Bucket: Necesario para guardar sus cosas, incluyendo los archivos de estado de Terraform (Terraform State).

Además de estos servicios, es esencial configurar los permisos necesarios para que CodePipeline pueda interactuar con otros servicios (CodeCommit, CodeBuild) y que CodeBuild tenga acceso a servicios como Secrets Manager, en caso de ser necesario. </p>

<h3 align="left"> ¿Cuáles son los comandos básicos de Terraform? </h3>

<p align="left"> Terraform es una herramienta poderosa para la creación y gestión de infraestructura como código. Conocer sus comandos básicos es esencial para maximizar su potencial:

* terraform init: Prepara el entorno de trabajo al inicializar terraform en el directorio actual, configurando la carpeta para futuros comandos como plan, apply, o destroy.

* terraform plan: Analiza los archivos de configuración de Terraform, compara con el estado almacenado, y genera un plan detallado que describe las acciones que se tomarán para alcanzar el estado deseado.

* terraform apply: Ejecuta las acciones planeadas por terraform plan, creando o actualizando la infraestructura según sea necesario.

* terraform destroy: Utiliza el estado almacenado para determinar qué recursos se deben eliminar, desmantelando así toda la infraestructura previamente creada.

Estos comandos, cuando se integran en un pipeline automatizado mediante CodePipeline y CodeBuild, aseguran que la infraestructura sea consistente y manejable de manera eficiente. </p>

<h3 align="left"> ¿Qué pasos seguir para ejecutar el pipeline? </h3>

<p align="left"> Estos pasos aseguran un flujo de trabajo fluido y automatizado que permite concentrarse en el diseño y mejoramiento de la infraestructura sin necesidad de tareas manuales repetitivas.

* Descargar y validar el código: CodePipeline descarga el código de CodeCommit para su validación y ejecución de los comandos de Terraform.
* Ejecutar el plan con Terraform: CodeBuild ejecuta terraform plan para generar un informe detallado de las acciones previstas sobre la infraestructura.
* Aplicar cambios en AWS: Se lleva a cabo terraform apply para implementar los cambios descritos en el plan, estableciendo así la infraestructura requerida.
* Desplegar pipelines futuros: La infraestructura ya configurada servirá como base para desplegar otros pipelines en clases subsiguientes.

Con esta guía, estarás listo para aventurarte en el mundo del despliegue automatizado de infraestructuras. Así que adelante, aplica estos conocimientos y comienza a optimizar tu proceso de gestión de infraestructura en la nube. </p>


<h3 align="left"> ¿Cómo se configura Terraform para integrar con AWS? </h3>

<p align="left"> Configurar Terraform para trabajar con AWS es un paso crucial en el proceso de automatización de infraestructura. El primer paso es asegurarnos de que Terraform guarde el archivo tfstate en un bucket de S3 preexistente. Este bucket será el repositorio que almacenará el estado de nuestra infraestructura, por lo que será necesario crearlo en la consola de Amazon si aún no lo hemos hecho. </p>

<h3 align="left"> ¿Cómo obtengo permisos y credenciales? </h3>

<p align="left"> Para que Terraform pueda interactuar con AWS, necesitamos configurar nuestro entorno con las credenciales adecuadas. Debemos crear un usuario de Amazon con permisos de administrador y generar una "access key". Existen varias formas de almacenar estas credenciales de manera segura:

* Archivo de configuración: Utilizar archivos de configuración dentro de un directorio AWS para guardar el access key y el secret key.
* CLI de Amazon: Trabajar directamente con el CLI (Command Line Interface) de Amazon para manejar credenciales.

Debemos evitar almacenar las credenciales directamente como parámetros dentro del archivo de configuración de Terraform debido a problemas de seguridad potenciales. Si lo hacemos por motivos de prueba, debemos recordar siempre eliminar esos datos sensibles posteriormente. </p>

<h3 align="left"> ¿Qué contienen los archivos Terraform usados? </h3>

<p align="left"> Los archivos de Terraform son fundamentales para definir la infraestructura que se va a crear y gestionar. Cada archivo corresponde a un componente o conjunto de componentes dentro de nuestra arquitectura en la nube. </p>

<h3 align="left"> ¿Cómo se configura CodeCommit y CodeBuild? </h3>

<p align="left"> La configuración de CodeCommit y CodeBuild se realiza a través de sus respectivos archivos:

* CodeCommit: Este archivo sencillo provoca la creación de un repositorio llamado repositorio de CICD usando CodeCommit.
* CodeBuild: Define los roles y permisos necesarios. Es crucial especificar:
    * Quién asume el rol (en este caso, CodeBuild).
    * Las acciones y permisos específicos que se otorgarán. </p>

<h3 align="left"> ¿Cómo se obtiene e integra una imagen de Docker? </h3>

<p align="left"> Cuando una integración precisa utilizar una imagen de Docker, como es el caso del uso de una imagen pública desde Docker Hub, necesitamos conectarnos y usar credenciales específicas:

* Credenciales de la cuenta de Docker se integran para facilitar la descarga de imágenes.
* Asegurar que las credenciales están almacenadas en los archivos de configuración adecuados. </p>

<h3 align="left"> ¿Qué pasos siguen después de configurar los archivos? </h3>

<p align="left"> Una vez configurados todos los archivos de Terraform y los servicios necesitan estar alineados para su correcta ejecución. Es importante asegurarse de que las credenciales estén listas y nuestra estructura de buckets de S3 configurada. </p>

<h3 align="left"> ¿Cómo se orquesta toda la infraestructura con CodePipeline? </h3>

<p align="left"> Para orquestar la infraestructura, utilizamos CodePipeline, que actúa como el controlador maestro que une varios pasos de ejecución:

* Uso de estados: Cada paso o estado se refiere a una acción, como usar CodeCommit para acceder al código de Terraform.
* Paso de atributos: Los inputs y outputs entre estados aseguran el flujo de datos necesarios.
* Configuración en S3: Los artefactos generados se almacenan en buckets de S3, según la estructura de CodePipeline. </p>