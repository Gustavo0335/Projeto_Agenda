using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<compromisso> agenda = new();
            var e1 = new evento();
            e1.Titulo = "E1";
            e1.Descricao = "Meu primeiro evento!";
            e1.Datahorainicio = new DateTime(2021, 10, 20, 22, 45, 0);
            e1.Datahorafim = new DateTime(2021, 10, 20, 23, 30, 0);
            e1.Notificacao.Add(new notificação((byte)4, 'H', 'E'));
            e1.Notificacao.Add(new notificação((byte)30, 'M', 'N'));

            e1.Local = "Centro de eventos do ABC Bolinhas";
            e1.Convidados.Add("ze@sei.la");
            e1.Convidados.Add("abc@bolinhas");
            e1.Convidados.Add("bolinhas@nem.sei");

            agenda.Add(e1);

            List<notificação> notificacao = new();
            Application.Run(new FormAgenda(agenda));

        }
    }
}
