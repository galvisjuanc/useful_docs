<h2> Como analizar documentos y datos con Claude</h2>

<p align="left"> Trabajar con información dispersa en PDF, presentaciones y archivos Excel consume gran parte de tu día. Aquí aprenderás cómo analizar documentos y datos con Claude para extraer insights clave, crear modelos predictivos y armar dashboards, ideal para cualquier profesional que quiera dejar de procesar datos a mano y empezar a tomar decisiones más rápido.

La idea central es simple: le entregas la información a Claude y él hace el trabajo pesado de análisis por ti. Vamos a ver dos frentes concretos, el trabajo con documentos y el análisis de datos, con ejemplos reales de reportes y un CRM de restaurantes. </p>

<h3> ¿Cómo extraer insights de varios PDF con Claude? </h3>

<p align="left"> Lo primero es cargar los documentos y darle una instrucción clara. En la clase se cargan dos reportes: uno de Microsoft sobre economía y futuro del trabajo, y el último informe de Anthropic sobre adopción de inteligencia artificial [00:36].

El prompt que se usa es directo: entregarle ambos reportes y pedirle extraer los principales usos que la gente le da a la IA para inspirar un sistema operativo personal que ayude a ser más productivo [01:20]. Aquí aparece la estructura clave del prompting: contexto y tarea. Le explicas de qué tratan los documentos y qué quieres que haga con ellos.

    ¿Cuántas imágenes puede procesar Claude en una conversación? Claude tiene un límite de 100 imágenes por conversación, incluidas las páginas de cada PDF. Si te acercas al tope, considera iniciar un chat nuevo.

En el ejemplo, el chat marcaba 84 de 100 imágenes, suficiente para el análisis [02:33]. Un consejo importante: al trabajar con varios documentos donde quieres que la IA itere, activa el pensamiento extendido o esfuerzo, para que analice con mayor profundidad [02:20]. </p>

<h3> ¿Qué patrones detecta Claude al cruzar reportes? </h3>

<p align="left "> Después de analizar ambos reportes, Claude agrupa los usos en cuatro grandes familias [03:34]:

* Trabajo cognitivo: analizar, resolver problemas, evaluar y pensar creativamente.
* Producción y transformación de contenido: escribir y crear.
* Backoffice y operaciones vía API: automatización.
* Aprendizaje y vida personal.

Y aquí viene lo interesante. Más allá de la lista, aparecen tres hallazgos que son oro para diseñar un sistema personal [04:20]. El primero es que el modo importa más que la tarea: existen modos de delegación, colaboración, asignación y exploración, y los llamados frontier professionals saben cuál usar en cada momento. El segundo, cómo prompteas es cómo responde. El tercero, lo que mueve la aguja es organizacional, no individual. </p>

<h3> ¿Cómo hacer análisis de datos en Excel con Claude? </h3>

<p align="left"> Cuando dejamos los PDF y pasamos a archivos Excel, el enfoque cambia. En la clase se usa data ficticia de un CRM de restaurantes en Chile: nombre comercial, ubicación, tipo de cocina, tamaño del local, plataformas de delivery, contactos y oportunidades abiertas [06:07].

Una práctica muy recomendable es armar un diccionario de datos que defina qué contiene cada hoja, qué campo es y de qué tipo. Antes servía para tus compañeros, pero hoy es clave porque así la IA entiende el archivo al instante [07:12]. Y lo mejor: le puedes pedir a Claude que cree ese diccionario por ti.

    ¿Qué es un diccionario de datos y por qué importa con IA? Es un documento que explica el contenido de cada hoja y campo de un Excel. Le da contexto a la IA para que interprete tus datos correctamente sin adivinar.

Cuando le pides analizar el Excel, Claude usa una skill específica y ejecuta comandos de código en lugar de razonar solo con el modelo de lenguaje [08:30]. Esto funciona como una calculadora avanzada que aumenta la certeza del análisis. La recomendación es usar el modelo más poderoso disponible, en este caso Opus, junto al pensamiento extendido [09:35]. 

<strong> ¿Cuáles son los cuatro niveles de análisis de datos? </strong>

El análisis de datos con Claude tiene cuatro niveles de profundidad progresiva:

1. Análisis descriptivo: promedios, máximos, ventas por período y la data clave del negocio [07:34].
2. Modelo predictivo: proyecciones de venta usando Python, con regresiones lineales y modelamiento [11:00].
3. Insights accionables: acciones concretas para llevar al jefe de ventas y ejecutar de inmediato [13:10].
4. Dashboard: toda la data clave lista para presentar [15:20].

En el nivel descriptivo, Claude entregó un gráfico interactivo con número de oportunidades, pipeline, win rate y etapas [10:07]. Detectó que Carlos concentra el mayor valor ganado con ciclos más largos, que Claudia mueve volumen pero es la que más pierde, y que Pedro y María José son señales de alerta [10:30].

    ¿Cómo se calcula el win rate? El win rate se calcula solo sobre las oportunidades cerradas, no sobre el total del pipeline. Por eso una lectura rápida puede confundir si no lo tienes en cuenta.

Para el modelo predictivo, Claude armó una página interactiva en HTML donde puedes modificar supuestos: qué pasa si reactivas oportunidades estancadas, si mejoras la conversión o si cambias el ciclo de venta [11:40]. El resultado depende de los datos: con más historial, podría armar modelos de segmentación estadística o scoring.

<strong> ¿Cómo generar insights y un dashboard listo para presentar? </strong>

En el tercer nivel, Claude entregó un Word con ocho acciones priorizadas en tres tier: sprint de reactivación de 52 oportunidades, acciones a 30 días y correcciones estructurales como recalibrar el scoring [13:50]. Sumó recomendaciones como congelar descuentos, definir un SLA por etapa y armar un playbook para productos de alto valor.

Para el dashboard, basta con usar esa palabra. Tiene una carga semántica que ya explica mucho, así que tu prompt queda más liviano y efectivo [15:40]. Claude armó una página web exportable a PDF o HTML con pipeline por etapa, proyección a seis meses, rendimiento por vendedor, canales por conversión y razones de pérdida [16:40].

La gran oportunidad está en los cientos de documentos que ya tienes guardados. Puedes extraer patrones de cómo trabajas y, por ejemplo, diseñar junto a Claude una serie de prompts para que cada vez que le pases un archivo recurrente te devuelva el reporte listo [17:50]. De eso se trata construir tu sistema operativo personal.
</p>