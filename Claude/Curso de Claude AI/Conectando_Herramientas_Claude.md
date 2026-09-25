<h2> Conectando tus herramientas </h2>

<p align="left"> 

Objetivos:
* Explica qué son los conectores y por qué son importantes para tu trabajo con Claude
* Navega por el directorio de conectores y configura tu primera conexión
* Usa las herramientas conectadas de manera efectiva en tus conversaciones con Claude
</p>

<h2> Qué son los conectores </h2>

<h3> Puntos Clave </h3>

<p align="left"> 

* Los conectores transforman a Claude de un asistente en un colaborador informado al darle a Claude acceso a las mismas herramientas, datos y contexto que usas todos los días. En lugar de empezar cada conversación desde cero, Claude puede trabajar directamente con tu información real.
* Los conectores permiten que Claude lea información y realice acciones en tu nombre. Dependiendo del conector y los permisos que otorgues, Claude puede buscar en tus archivos, recuperar documentos, analizar datos, crear contenido nuevo, actualizar registros y ejecutar tareas en tus aplicaciones conectadas—todo desde dentro de tu conversación.
* El Model Context Protocol (MCP) impulsa los conectores. Piensa en MCP como el USB-C para la IA—un estándar universal que permite a Claude conectarse a muchas aplicaciones diferentes a través de una única interfaz consistente. Este estándar abierto significa que los desarrolladores pueden crear conectores para cualquier herramienta, y esos conectores funcionan sin problemas con Claude.
* Hay dos tipos de conectores: conectores web y extensiones de escritorio. Los conectores web vinculan a Claude con servicios en la nube como Google Drive, Notion, Slack y Asana. Las extensiones de escritorio se ejecutan localmente en tu computadora a través de la aplicación Claude Desktop, dando a Claude acceso a archivos locales y aplicaciones nativas.

</p>

<h3> Encontrar y conectar herramientas </h3>

<p align="left"> 
A continuación hay una solicitud que Claude ya puede manejar — todo lo que necesita está en las palabras que escribiste. Nada más está conectado todavía. Activa una fuente y observa cómo crece la solicitud: cada conexión te permite pedir algo que vive fuera de tu mensaje.

<strong> Tu solicitud a Claude </strong>
    
    Redacta una breve actualización de estado sobre el proyecto de presupuesto para mi gerente.


Una oración—eso es una solicitud completa. Claude la redacta solo a partir de tus palabras.

Activa o desactiva una fuente

    Almacenamiento en la nube
    no conectado

    Correo electrónico
    no conectado

    Chat del equipo
    no conectado

La misma solicitud por debajo todo el tiempo. Lo que cambia es lo que puedes pedirle que use como referencia.

Qué te permite pedir cada conexión
Ahora mismo: solo lo que está en tu mensaje. Activa una fuente para agregarle algo.

Anthropic mantiene un directorio de conectores recomendados en claude.ai/directory. El directorio está organizado en dos pestañas:

* Web: Servicios en la nube y aplicaciones (Gmail, Notion, Slack, Asana, Linear, Stripe, y muchos más)
* Extensiones de escritorio: Herramientas locales que se ejecutan en tu computadora a través de la aplicación Claude Desktop

El directorio lista conectores en lugar de aplicaciones individuales, por lo que una entrada puede cubrir varias herramientas relacionadas. El conector Atlassian Rovo, por ejemplo, alcanza tanto a Jira como a Confluence, así que busca Atlassian en lugar de cualquiera de las dos aplicaciones por nombre. Si una herramienta que necesitas no tiene su propia entrada, puedes agregarla como un conector personalizado en su lugar.

Para explorar los conectores disponibles, también puedes hacer clic en el botón + en la parte inferior izquierda de la ventana de chat, y luego seleccionar Conectores.

</p>

<h3> Configurar un conector web </h3>

<p align="left"> Así es como se conecta un servicio en la nube:

1. Encuentra el conector: Navega a claude.ai/directory, o haz clic en + > Conectores en cualquier chat
2. Haz clic en Conectar: Selecciona el conector que quieres agregar
3. Autentícate: Serás redirigido a la página de inicio de sesión del servicio. Inicia sesión con tus credenciales existentes
4. Otorga permisos: Revisa los permisos específicos que Claude está solicitando, y luego autoriza el acceso
5. Prueba la conexión: Regresa a Claude e intenta una solicitud simple, como "¿Puedes acceder a mi [nombre de herramienta]?"

Una vez conectado, Claude puede buscar, leer y, en algunos casos, realizar acciones dentro de ese servicio—dependiendo de los permisos que hayas otorgado.

</p>