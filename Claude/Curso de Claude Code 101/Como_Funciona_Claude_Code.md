<h2> ¿Cómo funciona Claude Code? </h2>

<p align="left"> Claude Code es diferente de las aplicaciones de chat típicas. Entender cómo funciona por dentro te ayudará a usarlo de manera más efectiva. </p>

<h3> El bucle agéntico </h3>

<p align="left"> Claude Code se explica mejor a través del bucle agéntico:

1. Ingresas un prompt en Claude Code.
2. Claude reúne el contexto que necesita interactuando con el modelo, que devuelve texto o una llamada a una herramienta que Claude Code puede ejecutar.
3. Toma acción — por ejemplo, editando un archivo o ejecutando un comando.
4. Verifica los resultados y determina si logran lo que tu prompt se propuso hacer.
5. Si lo logran, Claude termina y espera el siguiente prompt. Si no lo logran, vuelve al inicio del bucle e intenta de nuevo hasta que los resultados sean completos y verificables.

A lo largo de este bucle, puedes agregar contexto, interrumpir o guiar al modelo para ayudar a orientarlo hacia tu objetivo. </p>

<h3> Contexto </h3>

<p align="left"> Claude tiene una ventana de contexto que determina cuánto de tu conversación, contenido de archivos, salidas de comandos y más puede almacenar y referenciar. Una vez que alcanzas ese límite, Claude Code compacta tu conversación — determinando automáticamente qué puede eliminar o resumir para reducir la ventana de contexto a un tamaño utilizable. </p>

<h3> Herramientas </h3>

<p align="left"> Las herramientas son la columna vertebral de cómo funcionan los agentes. La mayoría de los asistentes de IA simplemente reciben texto y devuelven texto. Las herramientas permiten que Claude Code determine cuándo ejecutar código para acercarse a completar una tarea. Esto podría ser una herramienta de lectura de archivos, una herramienta de búsqueda web, o cualquier otro número de capacidades. Claude Code usa comprensión semántica para determinar cuándo llamar a una herramienta y cómo usar la salida. </p>

<h3> Permisos </h3>

<p align="left"> Claude Code tiene varios modos de permisos:

* Manual: Claude pide permiso explícito antes de editar un archivo o ejecutar un comando de shell.
* Aceptación automática: Los archivos se editan sin preguntar, y los comandos comunes del sistema de archivos como mkdir, mv y rm se ejecutan sin preguntar también. Otros comandos todavía requieren aprobación.
* Modo de planificación: Claude lee archivos y ejecuta comandos de shell para explorar, sin editar tus archivos fuente, y compila un plan de acción antes de comenzar cualquier trabajo.
* Modo automático: Claude trabaja sin solicitudes de permiso rutinarias mientras un clasificador verifica la mayoría de las acciones en segundo plano, enfocado en bloquear acciones que son irreversibles, destructivas o dirigidas fuera de tu entorno. Cuando algo se bloquea, Claude generalmente encuentra un enfoque más seguro o te pide autorización.

El modo en que comienza una nueva sesión depende de tu versión de Claude Code y tu configuración.

Todo esto se puede configurar en tu archivo de configuración. Ten cuidado al omitir permisos — darle a Claude Code total libertad para ejecutar comandos significa que un error podría ser más difícil de detectar antes de que ocurra.</p>

<h3> Resumen </h3>

<p align="left"> Claude Code combina varios conceptos agénticos: un bucle agéntico, una ventana de contexto gestionada, herramientas y permisos configurables — todo dentro de tu terminal. Puede leer tu base de código, tomar acción y verificar su propio trabajo. Eso es lo que lo hace fundamentalmente diferente de una ventana de chat. </p>