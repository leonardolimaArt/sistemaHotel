using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    public class Suite
    {
        private string tipoSuite;
                
        private int capacidade;
    
        private decimal valorDiaria;

        public string TipoSuite { get => tipoSuite; set => tipoSuite = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public decimal ValorDiaria { get => valorDiaria; set => valorDiaria = value; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){
            this.tipoSuite = tipoSuite;
            this.capacidade = capacidade;
            this.valorDiaria = valorDiaria;
        }
    }
}