using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Tarefa : compromisso
    {
        private char prioridade;
        internal char Prioridade { get => prioridade; set => prioridade = value; }
        public Tarefa(string titulo = default, string descricao = default, DateTime datahorainicio = default, DateTime datahorafim = default,char prioridade = default, notificação notificação = default) : base(titulo, descricao, datahorainicio, datahorafim, notificação)
        {
            this.prioridade = prioridade;
        }

    }
}
