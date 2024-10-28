using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrvatska_Italija
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


class Program
{
    static void Main()
    {
       
        Console.WriteLine("Unesite neku rečenicu:");
        string rečenica = Console.ReadLine();

       
        if (string.IsNullOrWhiteSpace(rečenica))
        {
            Console.WriteLine("Rečenica ne smije biti prazna.");
            return;
        }

      
        string[] riječi = rečenica.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (riječi.Length > 0)
        {
        
            Console.WriteLine($"Prva riječ: {riječi[0]}");
            Console.WriteLine($"Zadnja riječ: {riječi[riječi.Length - 1]}");
        }
    }
}
