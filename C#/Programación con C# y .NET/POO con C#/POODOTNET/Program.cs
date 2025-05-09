using POODOTNET;
using POODOTNET.Models;

namespace POODOTNET
{
    internal class Program 
    {
        SuperHeroeRecord superHeroeRecord = new(1, "Superman", "Clark Kent");
        SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark Kent");

        Console.WriteLine(superHeroeRecord == superHeroeRecord2);

        var imprimirinfo = new ImprimirInfo();

        var poderVolar = new SuperPoder
        {
            Nombre = "Volar",
            Descripcion = "Capacidad para volar y planear en el aire.",
            Nivel = NivelPoder.NivelUno
        };

        var superFuerza = new SuperPoder();
        superFuerza.Nombre = "SuperFuerza";
        superFuerza.Descripcion = "Extremadamente fuerte. Destroza todo.";
        superFuerza.Nivel = NivelPoder.NivelDos;

        var regeneracion = new SuperPoder
        {
            Nombre = "Regeneracion",
            Descripcion = "Recuperar el cuerpo sin dejar heridas",
            Nivel = NivelPoder.NivelTres
        };
    }    
}
