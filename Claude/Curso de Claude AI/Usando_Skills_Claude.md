<h2> Trabajando con Skills </h2>

<p align="left"> 

Objetivos:
* Explicar qué son las Skills y cómo las usa Claude
* Identificar las Skills integradas de Anthropic para la creación de documentos
* Habilitar y gestionar las Skills en tu configuración
</p>

<h3> ¿Qué son las Skills? </h3>

<p align="left"> Las Skills son carpetas de instrucciones, scripts y recursos que Claude carga dinámicamente para mejorar el rendimiento en tareas especializadas. Piensa en ellas como paquetes de experiencia: le enseñan a Claude cómo completar tareas específicas de manera repetible.

Ya has visto las Skills en acción si has usado Claude para crear hojas de cálculo de Excel, presentaciones de PowerPoint, documentos de Word o PDFs. Esas capacidades de creación de archivos funcionan gracias a las Skills que operan detrás de escena. Pero las Skills van mucho más allá de la creación de documentos. Las Skills personalizadas pueden codificar flujos de trabajo repetibles completos — una metodología de análisis de variación trimestral, un proceso de revisión de voz de marca o una lista de verificación de cumplimiento — para que Claude siga los mismos pasos rigurosos cada vez.

</p>

<h3> Tipos de Skills </h3>

<p align="left"> Hay dos categorías de Skills que encontrarás:

* Las Skills de Anthropic son creadas y mantenidas por Anthropic. Estas incluyen capacidades mejoradas de creación de documentos para archivos de Excel, Word, PowerPoint y PDF. Las Skills de Anthropic están disponibles para todos los usuarios de pago y Claude las invoca automáticamente cuando es relevante; no necesitas hacer nada especial para usarlas.
* Las Skills personalizadas son las que tú o tu organización crean para flujos de trabajo especializados y tareas específicas de un dominio. Por ejemplo, podrías crear una skill que aplique las pautas de marca de tu empresa a las presentaciones, estructure las notas de reuniones en un formato específico o ejecute los flujos de trabajo de análisis de datos de tu organización.

</p>

<h3> Habilitar las Skills </h3>

<p align="left"> Las Skills actualmente están disponibles como una función en vista previa para usuarios de los planes Pro, Max, Team y Enterprise. Para usar las Skills, necesitarás tener habilitada la ejecución de código y creación de archivos, ya que las Skills requieren el entorno informático seguro y aislado (sandbox) de Claude para funcionar.

Así es como puedes habilitar las Skills:

1. Navega a Configuración > Capacidades
2. Asegúrate de que Ejecución de código y creación de archivos esté activado
3. Desplázate hasta la sección Skills
4. Activa o desactiva skills individuales según sea necesario

Para los planes Enterprise, los propietarios de la organización deben primero habilitar tanto la ejecución de código como las Skills en la configuración de administración antes de que los miembros individuales puedan acceder a ellas.

Para los planes Team, esta función está habilitada de forma predeterminada a nivel de organización.

Una vez habilitada, verás las Skills disponibles listadas en tu configuración, incluyendo las Skills integradas de Anthropic y cualquier Skill personalizada que hayas subido. </p>

<h3> Usar las Skills en la práctica </h3>

<p align="left"> Lo bueno de las Skills es que normalmente no necesitas pensar en ellas: Claude se encarga de seleccionar la skill automáticamente según tu solicitud. Aquí hay algunos ejemplos de prompts que invocarían Skills:

    “Crea una hoja de cálculo de Excel que rastree los gastos mensuales con fórmulas para totales”

    “Convierte este documento de notas de reunión en una presentación de PowerPoint”

    “Genera un informe en PDF que resuma estos datos”
    
    “Crea un modelo financiero en Excel con análisis de escenarios”


Cuando Claude usa una Skill, la verás mencionada en la cadena de pensamiento de Claude mientras trabaja. El resultado será un archivo descargable que puedes guardar en tu computadora o directamente en Google Drive. </p>

<h3> Ejecución de Archivos </h3>

<p align="left"> Claude trabaja contigo en diapositivas, hojas de cálculo y revisiones de contratos

Esta misma capacidad significa que Claude puede trabajar con tus archivos reales (dentro de un entorno contenido) para crear versiones actualizadas de tus archivos (nota: en el Chat, Claude crea una nueva versión del documento en lugar de editar el original directamente). Sube diapositivas, hojas de cálculo, contratos (o cualquier archivo .xlsx, .pptx, .docx o .pdf) y observa cómo Claude crea diapositivas, realiza análisis y agrega ediciones sugeridas. Cuando Claude termine, puedes descargar estos archivos o abrirlos en Drive.

Nota: Para usar estas capacidades necesitarás darle a Claude acceso a fuentes de datos externas. Simplemente activa la opción Permitir acceso limitado a la red cuando se te solicite.

<strong> Consideraciones de seguridad </strong>

Debido a que las Skills pueden incluir código ejecutable, es importante usarlas con cuidado:

* Instala solo Skills personalizadas de fuentes confiables
* Las Skills integradas de Anthropic son probadas y mantenidas por Anthropic
* Las Skills personalizadas que subes son privadas para tu cuenta individual
* Si estás instalando una Skill personalizada de una fuente externa, revisa su contenido antes de usarla para entender qué hace.

</p>

<h3> Crear skills personalizadas </h3>

<p align="left"> Si bien las Skills integradas de Anthropic cubren tareas comunes de creación de documentos, el verdadero poder de las Skills proviene de crear las tuyas propias. Las Skills personalizadas te permiten enseñarle a Claude tus flujos de trabajo específicos, pautas de marca y formas de trabajar, para que Claude pueda aplicar ese conocimiento automáticamente cuando sea relevante.

La forma más fácil de crear una Skill personalizada es a través de una conversación con el propio Claude. No necesitas escribir código ni crear archivos manualmente: Claude se encarga de la estructura técnica por ti.

Así es como puedes crear una Skill a través de una conversación:

1. <strong> Inicia un nuevo chat </strong> y dile a Claude qué quieres crear. Por ejemplo: "Quiero crear una skill para escribir revisiones comerciales trimestrales" o "Necesito una skill que aplique nuestras pautas de marca a las presentaciones".
2. <strong> Responde las preguntas de Claude. </strong> Claude te entrevistará sobre tu flujo de trabajo, preguntando cosas como: ¿Qué debería hacer esta skill? ¿Qué hace que un resultado sea bueno para este tipo de trabajo? ¿Puedes dar ejemplos de cuándo usarías esta skill?
3. <strong> Sube materiales de referencia</strong> si los tienes. Plantillas, guías de estilo, recursos de marca o ejemplos de trabajo del que estés orgulloso ayudan a Claude a entender exactamente lo que buscas.
4. <strong> Guarda tu skill. </strong> Al terminar, Claude genera un archivo que contiene tu skill correctamente estructurada. Todo lo que tienes que hacer es guardarlo y la skill estará lista para que Claude la use.

<strong> Ve tus skills.</strong> Encuentra la pestaña Personalizar en la barra lateral izquierda. Allí puedes ver todas las skills que están disponibles para ti e incluso editar las skills que usas manualmente o conversando con Claude.

Tu Skill personalizada aparecerá en tu lista de Skills junto a las Skills integradas de Anthropic. A partir de ese momento, Claude la invocará automáticamente cada vez que trabajes en tareas relevantes, sin necesidad de activación manual. Puedes mejorar tus skills con iteración: pídele a Claude que edite una skill y actualizará los archivos por ti.

</p>