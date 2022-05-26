using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
     public class notificação
    {
        //public byte tempo;
        private char unidade;
        private char tipo;

        public byte tempo { get; set; }
        public char Unidade { get => unidade; set => unidade = value; }
        public char Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
            }

        }

        public notificação(byte tempo, char unidade, char tipo)
        {
            this.tempo = tempo;
            this.unidade = unidade;
            this.tipo = tipo;
        }
      
    }

}
