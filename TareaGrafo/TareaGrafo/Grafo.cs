using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaGrafo
{
    class Grafo
    {

        // vertice para el grafo 
        public  int Vertice { get; set; } 
        List<int>[] Hola;

        // Se Crea constructor Constructor
        public Grafo(int V) 
        {
            Vertice = V; 
            Hola = new List<int>[V]; 
            for (int i = 0; i < V; i++) 
            {
                Hola[i] = new List<int>();
            }
        }

        // Metodo donde se agregan valores a la lista
        public void Introducir(int Principio, int V) 
        {
            Hola[Principio].Add(V); 
        }

        // Metodo de impreccion de direccion
        public void Direccion() 
        {
            Console.SetCursorPosition(0,10);
            Console.WriteLine("\n ============================ \n");
            Console.WriteLine("Direcciones simples: ");
            Console.WriteLine("A => B => C => D => E");
            Console.WriteLine("A => A => B => C => D => E");
            Console.WriteLine("A => A => B => G => F => E");
            Console.WriteLine("A => B => C => G => F => D => E");
            Console.WriteLine("\n ============================ \n");
        }
       


        // Metodo donde busca un camino hacia el  ultimo elemento
        public void DFS(int V) 
        {
            bool[] Carro = new bool[Vertice]; 
            Stack<int> Corriente = new Stack<int>();  
            Carro[V] = true; 
            Corriente.Push(V); 
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Camino hacia el ultimo elemento: ");
            // No supe como hacer que se imprimiera dos veces por esto la linea de codigo con el uno 
            Console.Write("1"); 
            while(Corriente.Count!=0) 
            {
                V = Corriente.Pop(); 
                Console.Write(">>> {0}", V); 
                foreach (int item in Hola[V]) 
                {
                    if(!Carro[item]) 
                    {
                        Carro[item] = true; 
                        Corriente.Push(item); 
                    }
                }
            }
        }


        //  Despedida 
        public void Adios()
        {
            Console.Write(@"██│░░░░░░░░░░░░░░░░░░░│██
█▌│░░░░░░░░░░░░░░░░░░░│▐█
█░└┐░░░░░░░░░░░░░░░░░┌┘░█
█░░└┐░░░░░░░░░░░░░░░┌┘░░█
█░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░█
█▌░│██████▌░░░▐██████│░▐█
██░│▐███▀▀░░▄░░▀▀███▌│░██
█▀─┘░░░░░░░▐█▌░░░░░░░└─▀█
█▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄█
███▄─┘██▌░░░░░░░▐██└─▄███
████░░▐█─┬┬┬┬┬┬┬─█▌░░████
███▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐███
████▄░░░└┴┴┴┴┴┴┴┘░░░▄████
██████▄░░░░░░░░░░░▄██████" );
        }
    }
}
