using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPessoa
{
    class Fisica : Pessoa
    {
        private string cpf;
        private string rg;
        private double altura;
        private int idade;

        // Métodos sets e gets
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }
        public double GetAltura()
        {
            return altura;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetIdade()
        {
            return idade;
        }

        //  Métodos
        public void Anda()
        {
            Console.WriteLine("A pessoa está andando...");
        }

        public void Fala()
        {
            Console.WriteLine("A pessoa está falando...");
        }
    }
}
