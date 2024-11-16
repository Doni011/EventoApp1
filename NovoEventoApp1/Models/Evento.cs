﻿namespace NovoEventoApp1.Models // O namespace deve ser o mesmo que você está tentando usar no seu código
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        public int DuracaoEmDias
        {
            get
            {
                return (DataTermino - DataInicio).Days + 1;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}