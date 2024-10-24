//using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Sistema.Academia.Modelos
{
    public class Aluno(string nome, string cpf, int idade, string sexo, DateTime nascimento)
    {
        public string Nome = nome;
        public string Cpf = cpf;
        public int Idade = idade;
        public string Sexo = sexo;
        public DateTime Nascimento = nascimento;

    }
}

