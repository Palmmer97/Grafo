using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se Crea Objeto "Ojb"
            Grafo Ojb = new Grafo(8); 
            Ojb.Introducir(1, 1); 
            Ojb.Introducir(3, 7); 
            Ojb.Introducir(1, 2); 
            Ojb.Introducir(2, 3); 
            Ojb.Introducir(6, 7); 
            Ojb.Introducir(4, 5); 
            Ojb.Introducir(2, 7); 
            Ojb.Introducir(3, 4); 
            Ojb.Introducir(5, 6); 
            Ojb.Introducir(4, 6);                           
            Ojb.DFS(1); 
            Ojb.Direccion();
            Ojb.Adios();
            Console.ReadKey(true);
        }
    }
}
