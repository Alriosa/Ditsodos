using System;
using BusinessLayer;
using BusinessLayer.creador;
using BusinessLayer.creadorItems;
using Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaItems metodo_Fabrica = new FabricaItems();

            Troop tropa;

            tropa = metodo_Fabrica.createTroop("Archer", 1);

            Console.WriteLine(tropa.getDescription());


        }
    }
}
