using System;

using System.Collections.Generic;

namespace Agenda
{
    public abstract class compromisso
    {
        protected string titulo, descricao;
        protected DateTime datahorainicio, datahorafim;
        protected List<notificação> notificacao;
        protected string tipo;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Datahorainicio { get => datahorainicio; set => datahorainicio = value; }
        public DateTime Datahorafim { get => datahorafim; set => datahorafim = value; }
        public List<notificação> Notificacao { get => notificacao; set => notificacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }


        // this allows the structure compromisso c1 = new();  c1.titulo = "C1";  DateTime auxinicio = new DateTime(2021, 9, 27, 19, 52, 00); c1.datahorainicio = auxinicio c1.datahorafim = new DateTime(2021, 9, 27, 22, 34, 54);

        // this allows the structure  compromisso c2 = new compromisso("C2", "compromisso C2", new DateTime(2021, 10, 15, 10, 30, 00), new DateTime(2021,10, 17, 23, 10, 00));

        public compromisso(string titulo, string descricao, DateTime datahorainicio, DateTime datahorafim, notificação Notificacao)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.datahorainicio = datahorainicio;
            this.datahorafim = datahorafim;
            //this.notificacao = new List<notificacao>() {Notificacao}; <--- shortend the next two lines
            notificacao = new List<notificação>();
            notificacao.Add(Notificacao);
        }
    }
}
