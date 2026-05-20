<h2> Como Conectar un feed cronológico con Supabase </h2>

<p align="left"> Conecta tu front end a Supabase y muestra un feed tipo minired social con posts ordenados por fecha, imágenes, captions y likes. Aquí verás cómo reemplazar el mock por data real, integrar la consulta al backend y resolver el típico error de fechas en formato string para un render limpio y confiable. </p>

<h3> ¿Qué construirás y con qué datos reales? </h3>

<p align="left"> Vas a unir todo lo avanzado: lectura y creación de datos desde Supabase, y las vistas básicas del front end. El objetivo es que el feed muestre todos los posts con su imagen y caption en orden cronológico (más recientes primero), igual que una red social. 

<strong> ¿Cómo lucirá el feed con orden cronológico? </strong>

* Posts ordenados por la columna de creación en modo descendente.
* Imágenes y captions renderizados en la interfaz.
* Likes visibles por publicación.
* Avatar y usuario aún no conectados; se integrarán más adelante.

<strong> ¿Qué piezas principales quedan listas? </strong>

* Home con feed conectado a data real.
* Detalle del post operativo.
* Ranking de posts por likes, usando la misma fuente de datos.

<strong> ¿Qué data real estás viendo? </strong>

* 33 posts: 31 del import SQL y 2 nuevos (uno desde la API y otro desde el front end).
* Un post reciente creado con default user y 0 likes.
* Un post sin caption creado desde la API muestra solo el usuario que lo publicó.

<strong> ¿Cómo integrar la consulta de Supabase en el home? </strong>

Primero, importa el client de Supabase y prepara el estado de posts. Luego, usa useEffect para consultar la tabla que contiene los posts y ordenar por fecha de creación en descendente. Reemplaza el mock por la data real con setPosts.

    import { useEffect, useState } from 'react';
    import { supabase } from '@/lib/client';

    export default function Home() {
    const [posts, setPosts] = useState([]);

    useEffect(() => {
        const fetchPosts = async () => {
        const { data, error } = await supabase
            .from('post_new')
            .select('*')
            .order('created_at', { ascending: false });

        if (!error) setPosts(data || []);
        };

        fetchPosts();
    }, []);

    // render del feed con imágenes y captions...
    return null;
    }

<strong> ¿Cómo traer y ordenar los posts por fecha? </strong>

* Consulta a Supabase desde la tabla de posts (por ejemplo, post_new).
* Usa .order('created_at', { ascending: false }) para ver lo más reciente arriba.
* Renderiza la lista con la data real recibida en setPosts.


<strong> ¿Cómo resolver el error de fecha tipo string? </strong>

Supabase entrega created_at como string. Si usas una utilidad tipo getTimeAgo, conviértelo antes a Date para evitar errores con getTime.

    // Antes de formatear tiempos relativos:
    const createdAt = new Date(post.created_at);
    const label = getTimeAgo(createdAt);

* Convierte la fecha con new Date(...) antes de pasarla a tu util.
* Así, el cálculo de tiempo transcurrido funciona correctamente.

<strong> ¿Cómo limpiar el estado y eliminar el glitch del mock? </strong>

* Elimina el mock y deja solo el type si te hace falta para el tipado.
* Inicializa el estado como arreglo vacío para no mostrar datos falsos al refrescar.
* Quita el console log y cualquier referencia al mock.

    const [posts, setPosts] = useState([]); // evita mostrar el mock por un segundo

*Ese pequeño “glitch” corresponde al tiempo de respuesta de Supabase al traer la data real.

<strong>¿Qué sigue tras conectar front end y backend? </strong>


Con el feed público ya en marcha, puedes crear posts nuevos y ranquear según likes. Tus vistas principales quedan listas: home, crear post y ranking, todas alimentadas con Supabase. El siguiente paso es subir el proyecto a producción para compartirlo.

</p>