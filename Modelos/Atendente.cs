using System.Data;
using System.Security.Cryptography;
using System;

namespace Sistema.Academia.Modelos
{
    public class Atendente ( string nome, string cpf, int idade, double salario, DateTime admissao)
    {
        public string Nome = nome;
        public string Cpf = cpf;
        public int Idade = idade;
        public double Salario = salario;
        public DateTime Admissao = admissao;
    }
}
