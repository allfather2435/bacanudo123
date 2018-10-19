using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereço, RG, lográdouro;
            string bairro, cidade;

            Console.WriteLine("Olá, como vai");
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu endereço");
            endereço = Console.ReadLine();
            Console.WriteLine("Digite o seu RG");
            RG = Console.ReadLine();
            Console.WriteLine("Digite o seu lográdouro");
            lográdouro = Console.ReadLine();
            Console.WriteLine("Digite a sua cidade");
            cidade = Console.ReadLine();
            cidade = cidade.ToLower();
            
            switch (cidade)
            {
                case "osasco":
                    Console.WriteLine("Digite o seu bairro");
                    bairro = Console.ReadLine();
                    bairro.ToLower();

                    break;

                case "barueri":
                    Console.WriteLine("Digite o seu bairro");
                    bairro = Console.ReadLine();
                    bairro.ToLower();

                    break;

                case "itapevi":
                    Console.WriteLine("Digite o seu bairro");
                    bairro = Console.ReadLine();
                    bairro.ToLower();

                    break;

                case "jandira":
                    Console.WriteLine("Digite o seu bairro");
                    bairro = Console.ReadLine();
                    bairro.ToLower();

                    break;

            }
                


            Console.ReadKey();


        }
    }
}
