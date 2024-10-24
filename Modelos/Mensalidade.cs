using System;
namespace Sistema.Academia.Modelos

{
    public class Mensalidade (string situacao,DateTime dataInicio, DateTime dataFim,string plano)
    {
        public string Situacao = situacao;
        public DateTime DataInicio = dataInicio;
        public DateTime DataFim = dataFim;
        public string Plano = plano;
    }
}
