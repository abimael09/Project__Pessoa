using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando classe FISICA com objeto
            Fisica pessoa1 = new Fisica();
            pessoa1.nome = "Abimael";
            pessoa1.SetAltura(1.80);
            pessoa1.Anda();
            Console.WriteLine(pessoa1.nome);

            // Instanciando classe JURIDICA com objeto
            Juridica pessoa2 = new Juridica();
            pessoa2.nome = "IFBA";
            pessoa2.endereco = "Rua A";
            pessoa2.cnpj = "3333333333333";

            Console.ReadKey();
        }
    }
}
