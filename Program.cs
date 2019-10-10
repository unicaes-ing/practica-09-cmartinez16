using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>();
            frutas.Add("1)Fresa");
            frutas.Add("2)Papaya");
            frutas.Add("3)Banana");
            frutas.Add("4)Piña");
            frutas.Add("5)Kiwi");

            int op;
            Console.WriteLine("Menu principal");
            Console.WriteLine("[1].Agregar a la lista");
            Console.WriteLine("[2].Mostrar lista");
            Console.WriteLine("[3].Insertar elemento");
            Console.WriteLine("[4].Eliminar elemento");
            Console.WriteLine("[5].Buscar en la lista");
            Console.WriteLine("[6].Vaciar lista");
            Console.WriteLine("[7].Salir");
            Console.WriteLine("--------------------------");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    string fruta;
                    Console.Clear();
                    Console.WriteLine("Cantidad de frutas que desea agregar");
                    int cant = Convert.ToInt32(Console.ReadLine());
                    int[] agregar = new int[cant];
                    for (int i = 0; i < agregar.Length; i++)
                    {

                        Console.Write("Fruta: ");
                        fruta = Console.ReadLine();


                        frutas.Add(fruta);
                    }

                    Console.Clear();
                    foreach (string fr in frutas)
                    {
                        Console.WriteLine(fr);
                    }
                    break;
                case 2:
                    Console.Clear();
                    foreach (string fr in frutas)
                    {
                        Console.WriteLine(fr);
                    }
                    break;
                case 3:
                    Console.Clear();
                    int num1;
                    string nueva;
                    Console.WriteLine("Ingrese el numero del indice donde desea agregar la fruta");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la nueva fruta agregar");
                    nueva = Console.ReadLine();
                    frutas.Insert(num1, nueva);

                    Console.Clear();
                    foreach (string fr in frutas)
                    {
                        Console.WriteLine(fr);
                    }

                    break;
                case 4:
                    Console.Clear();
                    int num;
                    Console.WriteLine("Ingrese el numero de la fruta que desea eliminar");
                    num = Convert.ToInt32(Console.ReadLine());
                    frutas.RemoveAt(num);

                    Console.Clear();
                    foreach (string fr in frutas)
                    {
                        Console.WriteLine(fr);
                    }
                    break;
                case 5:
                    Console.Clear();
                    string b;
                    Console.WriteLine("Ingrese la fruta que desea buscar");
                    b = Console.ReadLine();

                    do
                    {

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("La fruta se encuentra en la lista.");


                    } while ((frutas.Contains(b)));


                    break;
                case 6:
                    Console.Clear();
                    frutas.Clear();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir.");
                    break;
            }

            Console.ReadKey();
        }

    }
}
