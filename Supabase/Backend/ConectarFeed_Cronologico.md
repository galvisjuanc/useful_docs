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

</p>