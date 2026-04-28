<h2> Conectar Supabase JS con datos reales del ranking </h2>

<p align="left"> Conecta tu front end a datos reales con Supabase JS y construye un ranking de posts por número de likes. En minutos pasas de mocks a lecturas desde la base de datos, validas en consola y habilitas imágenes desde storage con Next.js, sin fricción. </p>

<h3> ¿Cómo conectar Supabase JS y leer datos reales? </h3>

<p align="left"> Con el client ya configurado, la verificación inicial consiste en hacer una primera lectura, correr el proyecto con npm run dev y revisar la consola del navegador en localhost:3000. Si todo está bien, verás los posts tal como en el dashboard de Supabase. La llamada se ejecuta dentro de un useEffect para dispararse al montar la página.

* Importar el client desde utils.
* Crear una función asíncrona de fetch con manejo de error.
* Renderizar la llamada dentro de useEffect.
* Validar en la consola que llegan los datos: caption, fecha de creación, id, imagen, likes, actualización y usuario.

        // app/page.tsx o pages/index.tsx
        import { useEffect, useState } from 'react';
        import { supabase } from '@/utils/client'; // tu cliente ya inicializado

        export default function Home() {
        const [posts, setPosts] = useState<any[]>([]);

        useEffect(() => {
            async function fetchPosts() {
            const { data, error } = await supabase
                .from('posts')
                .select('*');

            if (error) {
                console.error('Error al obtener los posts:', error);
                return;
            }
            console.log('Posts:', data);
            setPosts(data ?? []);
            }

            fetchPosts();
        }, []);

        return <main>{/* render según tu UI */}</main>;
        }

<strong> ¿Qué valida esta primera integración? </strong>

* Que el client se conecte correctamente.
* Que la lectura refleje lo mismo que ves en el dashboard de Supabase.
* Que el ciclo de vida de React con useEffect dispare la consulta al inicio.

<strong> ¿De qué forma ordenar y filtrar posts por likes con Supabase JS? </strong>

Para construir el rank necesitas una consulta más específica: seleccionar columnas puntuales, filtrar por mínimo de likes, ordenar de forma descendente y, si hace falta, limitar resultados para pruebas. Luego, reemplazas los mocks por esta data.


    // Consulta para el ranking
    const { data, error } = await supabase
    .from('posts')
    .select('id, image_url, caption, likes')
    .gt('likes', 5)                 // mayor que 5
    .order('likes', { ascending: false }) // descendente
    .limit(10);                     // opcional durante las pruebas

* Solo traer columnas necesarias: id, image_url, caption, likes.
* Filtrar posts con al menos seis likes.
* Ordenar por likes en forma descendente.
* Usar limit 10 para validar rápido; luego puedes retirarlo.

</p>