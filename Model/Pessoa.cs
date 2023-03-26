using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        public Pessoa (string nome, string sobrenome){
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
    }
}