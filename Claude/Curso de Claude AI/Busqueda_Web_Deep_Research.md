<h2> Búsqueda Web y Deep Research </h2>

<p align="left"> Abrir diez pestañas, leer artículo por artículo, descartar la mitad y guardar lo que sirve: ese es el ritual de investigación que te come la mañana. Aquí aprenderás a usar las dos funciones de búsqueda de Claude —la búsqueda web y la investigación profunda— para que la IA haga la curatoría por ti y tú te quedes con la parte que importa, ideal para cualquier profesional que investiga antes de decidir.

La idea central es un cambio de roles: en lugar de que tú busques, leas y filtres, Claude busca, procesa y te sirve lo clave [03:19]. Vamos a ver las dos funciones por separado, con una demo real de investigación profunda de punta a punta. </p>

<h3> ¿Por qué Claude necesita buscar en internet? </h3>

<p align="left"> laude, como toda herramienta de IA, corre sobre un modelo preentrenado —Opus, Sonnet o Haiku— y eso significa que su conocimiento tiene una fecha de corte [00:09]. En los modelos de Claude esa fecha suele estar unos seis meses en el pasado [00:19]. El buscador existe para llenar ese vacío: completar lo que le falta o traer información en tiempo real [00:28].

    ¿Qué pasa si no activo la búsqueda web? Claude responde solo con lo que aprendió hasta su fecha de corte. Para temas estables no hay problema; para precios, versiones, noticias o tendencias vas a recibir información vieja sin que te avise.

<strong> ¿Cómo activar la búsqueda web en Claude? </strong>

Anda al botón más y activa búsqueda web [00:48]. Si acabas de instalar la aplicación o nunca tocaste esa configuración, debería estar activa por defecto [00:56].

Con eso listo, hay dos formas de que busque: dejar que decida cuándo lo necesita, o pedírselo explícitamente en el prompt. En la clase se usa la segunda: busca en internet toda la información acerca de los modelos de Claude [01:13]. Nombrar la acción en el prompt fuerza el buscador [01:39].

Y aquí está lo que diferencia a Claude del resto de las herramientas: intercala lo que descubre con el pensamiento extendido [02:04]. Si encuentra algo nuevo, puede lanzar otra búsqueda o decidir que quiere explorar ese hilo antes de responder [02:09]. Eso sube la calidad del resultado varios niveles.

En el ejemplo devolvió la línea actual de modelos con su nombre en la API, para qué sirve cada uno, el tamaño de la ventana de contexto, reglas para elegir entre ellos y los niveles de esfuerzo [02:22]. Todo desde la página oficial de Anthropic, y todo trazable: puedes abrir las fuentes que usó y validar por tu cuenta [02:47].

<strong> ¿Cómo cambia tu forma de buscar? </strong>

Piensa en el flujo de siempre: vas a Google, te salen resultados, abres pestañas, lees cada artículo, descartas los que no sirven y guardas lo que rescataste [03:00]. Toda la curatoría la haces tú.

Con Claude los papeles se invierten [03:25]. La IA busca, procesa, extrae lo clave y te lo entrega en un formato útil. Tu rol pasa a ser el de validador: reviso, confío en la fuente, me hace sentido, y si algo no cuadra le pido que ajuste o complemente, porque el formato es conversacional [03:42].

El efecto real es de reasignación de tiempo: baja el tiempo de búsqueda y sube el tiempo de trabajar con la información, que es donde está el valor del día a día [04:01].

<strong> ¿Qué es Deep Research y en qué se diferencia? </strong>

La segunda función de búsqueda es la investigación profunda o Deep Research, también en el botón más, en investigación [04:12].

    ¿Cuál es la diferencia entre búsqueda web y Deep Research? La búsqueda web hace unas cuantas consultas dentro de tu conversación. Deep Research arma un plan de investigación, recolecta cientos de fuentes, las procesa combinándolas con el pensamiento extendido y te devuelve un reporte con análisis y tesis, no solo una respuesta [04:46].

Sirve para cualquier decisión que exija comparar: modelos de celular, tendencias de mercado, opciones de auto [04:30].

<strong> ¿Cómo funciona una investigación profunda paso a paso? </strong>

En la demo el prompt fue corto: las mejores herramientas para crear sitios web para mi negocio de forma simple y SEO friendly [05:15]. Podrías armar uno mucho más elaborado con más contexto, como se vio en la clase de prompting y en el curso de prompting de la AI Academy [05:28].

Lo interesante es que Claude no se lanza a investigar de inmediato: primero hace preguntas de profundización [05:44]. En este caso preguntó qué tipo de sitio necesitaba —landing, sitio de marca, newsletter—, si quería mantenerlo sin tocar código y si había restricción de presupuesto [05:50]. Además, como en la clase anterior se activó la memoria, Claude ya sabía cuál era la empresa y trajo ese contexto solo [06:37]. Ahí se ve la ganancia de ir combinando funciones para el sistema operativo personal.

Un detalle práctico: si tienes conectores activos, conviene desconectarlos para que la investigación fluya sin interrupciones [06:59].

Los números de la corrida:

* 7 segundos: 30 fuentes encontradas y en revisión [07:18].
* 49 segundos: 138 fuentes [07:41].
* Total: 5 minutos 55 segundos y 309 fuentes revisadas [07:57].

    ¿Claude usa las 309 fuentes? No. Ese número es lo que encontró, no lo que ocupó [08:07]. Descarta con criterio: si varias fuentes refuerzan el mismo punto, lo trata como probablemente cierto, y para elegir aplica los mismos atributos que posicionan un sitio en un buscador —expertise, experiencia, autoridad y contenido fresco [08:22].

<strong> ¿Qué te entrega el reporte y cómo lo exportas? </strong>

El resultado fue una guía completa con recomendación principal, comparativa detallada de otras herramientas y ranking de capacidad SEO [08:40]. Desde arriba puedes copiar el texto, descargarlo como markdown o descargarlo como PDF [08:56].

    ¿Por qué descargar en markdown? Es un archivo de texto liviano que usa símbolos para marcar negritas, cursivas y títulos [09:02]. Es el formato que mejor procesa la IA, así que si vas a reutilizar el reporte en otro prompt o en otra herramienta, ese es el que quieres.

Por dentro, el documento venía estructurado con TL;DR y recomendación principal, key findings para el caso específico, capacidad SEO y de blog, un perfil por plataforma, costos reales de arranque y costos ocultos como el dominio y el recargo cambiario, facilidad de migración futura, recomendaciones concretas de instalación, perfiles alternativos, los umbrales que cambiarían la recomendación y los caveats a tener en cuenta [09:16].

Fíjate en el penúltimo punto: no solo te dice qué elegir, te dice bajo qué condiciones esa respuesta dejaría de ser válida.

<strong> ¿En qué usar Deep Research en tu trabajo? </strong>

La gracia es dejar a la IA trabajando por ti mientras haces otra cosa [10:22]. Dos ejemplos de la clase: si estás en ventas, pídele las mejores prácticas del área y armen juntos un playbook que después reutilizas con un prompt o con otras funciones de Claude [10:41]. Si estás montando un sitio web, pídele buenas prácticas de publicación que sean SEO friendly y que permitan indexar bien en buscadores y redes sociales [10:52].

Piensa en las tareas que repites cada semana y en cuáles de ellas un documento de investigación te ahorraría horas. Ese es tu punto de partida.

</p>