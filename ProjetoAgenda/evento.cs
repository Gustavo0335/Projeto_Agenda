using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class evento : compromisso
    {
        private string local;
        private List<string> convidados;

        internal string Local { get => local; set => local = value; }
        internal List<string> Convidados  { get => convidados; set => convidados = value; }

       
        public evento(string titulo = default, string descricao = default, DateTime DatahoraInicio = default, DateTime DatahoraFim = default,  string local = default,  string convidados = default, notificação notificação = default) : base (titulo, descricao, DatahoraInicio, DatahoraFim, notificação)
        {
            this.local = local;
            this.convidados = new List<string>();
            if (convidados != null)
            {
                this.convidados.Add(convidados);
            }
        }

        
    }
}
