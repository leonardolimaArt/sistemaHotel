using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    public class Reserva
    {
        private List<Pessoa> hospedes = new List<Pessoa>();
        private Suite suite;
        private int diasReservados;

        public List<Pessoa> Hospedes { get => hospedes; set => hospedes = value; }
        public Suite Suite { get => suite; set => suite = value; }
        public int DiasReservados { get => diasReservados; set => diasReservados = value; }

        public Reserva (Suite suite,int diasReservados){
            this.suite = suite;
            this.diasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> listaHospedes){

            if(listaHospedes.Count() <= suite.Capacidade) {
                foreach (Pessoa pessoa in listaHospedes)
                {
                    this.hospedes.Add(pessoa);
                }
            }else{
                throw new Exception("A quantidade de hospedes é maior do que a capacidade da Suite!");
            }
        }

        public void CadastrarSuite(Suite suite){
            this.suite = suite;
        }

        public int ObterQuantidadeHospede(){
            return this.hospedes.Count();
        }

        public decimal CalcularValorDiaria(){

            decimal diaria = diasReservados * suite.ValorDiaria; 

            if(diasReservados > 10){
                diaria = diaria - (diaria * 0.10M);
            }
            
            return diaria;
        }
    }
}