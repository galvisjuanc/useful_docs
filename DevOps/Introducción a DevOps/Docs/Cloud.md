<h2 align="left"> Cloud </h2>

<h3> Modelo de Responsabilidad</h3>

<p align="left"> El mundo de los proveedores cloud es fascinante y, al mismo tiempo, complejo en su estructura de responsabilidades compartidas. Cuando hablamos de nubes privadas, la responsabilidad recae completamente en la empresa que las gestiona. Es decir, la empresa se encarga de administrar el hardware, el software, la energía, el acceso a datos, y más. 

* Responsabilidades de la empresa en una nube privada (local): Datos y acceso, Solicitudes, Tiempo de Ejecución, Sistema Operativo, Máquina Virtual, Proceso, Redes, Almacenamiento. </p>

<h3> Modelo de Responsabilidad compartida</h3>

<p align="left"> Sin embargo, en la nube pública, las cosas cambian y los modelos de responsabilidad son fundamentales para entender cómo se distribuyen las responsabilidades entre el proveedor del servicio y el usuario.

Estas responsabilidades suelen clasificarse en tres modelos principales: infraestructura como servicio (IaaS), plataforma como servicio (PaaS) y software como servicio (SaaS). Cada uno implica un nivel diferente de control y responsabilidad tanto para el proveedor como para el usuario.

* IaaS
    * Responsabilidades de la empresa en una nube publica usando IaaS: Datos y acceso, Solicitudes, Tiempo de Ejecución, Sistema Operativo, Máquina Virtual.
    * Responsabilidades del tercero: Proceso, Redes, Almacenamiento.

* PaaS
    * Responsabilidades de la empresa en una nube publica usando PaaS: Datos y acceso, Solicitudes.
    * Responsabilidades del tercero: Tiempo de Ejecución, Sistema Operativo, Máquina Virtual, Proceso, Redes, Almacenamiento.

* SaaS
    * Responsabilidades de la empresa en una nube publica usando SaaS: Datos y acceso.
    * Responsabilidades del tercero: Solicitudes, Tiempo de Ejecución, Sistema Operativo, Máquina Virtual, Proceso, Redes, Almacenamiento.

Actualmente, dentro de varios proveedores de servicio, tenemos estos tres gigantes:

* Amazon Web Services:
    * IaaS : Elastic Compute Cloud (EC2)
    * PaaS : Elastic Beanstalk
    * CaaS : Elastic Kubernetes Service (EKS)
    * FaaS : Lambda
    * Object Storage : Simple Storage Service (RDS)
    * Relational: Relational Database Service (RDS)
    * NoSQL: DynamoDB

* Microsoft Azure:
    * IaaS : Virtual Machines
    * PaaS : App Service
    * CaaS : Azure Kubernetes Service (AKS)
    * FaaS : Functions
    * Object Storage : Blobs
    * Relational: SQL Database
    * NoSQL: Cosmos DB

* Google Cloud Platform:
    * IaaS : Compute Engine
    * PaaS : App Engine
    * CaaS : Kubernetes Engine
    * FaaS : Cloud Functions
    * Object Storage : Cloud Storage
    * Relational: Cloud SQL
    * NoSQL: Cloud Bigtable

 </p>

<h3> Desglose del Encabezados para Computador </h3>

<p align="left"> 

* IaaS (Infrastructure as a Service): Es el nivel más básico, donde se alquilan recursos informáticos como servidores, almacenamiento y redes.
* PaaS (Platform as a Service): Ofrece un entorno preconfigurado para desarrollar y desplegar aplicaciones, sin la necesidad de gestionar la infraestructura subyacente.
* CaaS (Container as a Service): Proporciona una plataforma para ejecutar contenedores, que son unidades de software independientes y portables.
* FaaS (Functions as a Service): Permite ejecutar pequeños fragmentos de código (funciones) sin tener que gestionar servidores. </p>

<h3 align="left"> Desglose del Encabezados para Datos </h3>

<p align="left"> 

* Object Storage: Almacenamiento de objetos, ideal para grandes volúmenes de datos no estructurados
* Relational: Bases de datos relacionales, diseñadas para almacenar datos estructurados en tablas.
* NoSQL: Bases de datos NoSQL, diseñadas para manejar grandes volúmenes de datos no estructurados o semiestructurados. </p>