using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioOO_1
{
    internal class Pessoa
    {
        String nome;
        int idade;
        double peso;
        double altura;

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade, double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public void exibirDados()
        {
            Console.Write("Nome: " + Nome + ". Idade: " + Idade + ". Peso: " + Peso.ToString("F2") + ". Altura: " + Altura.ToString("F2") + ".");
        }

    }
}