using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public enum EnumTipo
    {
        Email = 'E',
        Notificação = 'N',
        Tremer = 'T'
    }
    public enum EnumDescrição
    {
        Minuto = 'M',
        Horas = 'H',
        Dias = 'D',
        Semanas = 'S',
        Meses = 'X',
        Anos = 'A'
    }
    public enum EnumTarefa
    {
        Urgente = 'U',
        Alta = 'A',
        Normal = 'N',
        Baixa = 'B',
        Minima = 'M'
    }
    public enum EnumTipoLembrete
    {
        Dia = 'D',
        Semana = 'S',
        Mês = 'M',
        Ano = 'A',
    }

    public enum EnumRepetirLembrete
    {
        Segunda = 'A',
        Terça = 'B',
        Quarta = 'C',
        Quinta = 'D',
        Sexta = 'E',
        Sabado = 'F',
        Domingo = 'G'
    }
    public enum EnumTerminarLembrete
    {
        Nunca = 'N',
        Emdata = 'D',
        AposxOcorrencia = 'A'
    }


    public partial class FormAgenda : Form
    {
        List<compromisso> agenda;
        public FormAgenda(List<compromisso> agenda)
        {
            this.agenda = agenda;

            InitializeComponent();

            evento c1 = new evento("c1", "compromisso c1", new DateTime(2021, 9, 27, 19, 52, 00), new DateTime(2021, 9, 27, 22, 34, 54));
            c1.Notificacao.Add(new notificação((byte)40, 'M', 'N'));
            c1.Notificacao.Add(new notificação((byte)10, 'M', 'N'));
            agenda.Add(c1);

            /*evento c2;
            c2 = new evento();
            c2.Titulo = "c2";
            c2.Descricao = "Compromisso c2";
            c2.Datahorainicio = new DateTime(2021, 11, 07, 00, 00, 00);
            c2.Datahorafim = new DateTime(2021, 11, 07, 23, 59, 59);
            c2.Notificacao.Add(new notificação((byte)2, 'M', 'N'));
            agenda.Add(c2);

            evento c3 = new evento("c3", new DateTime(2021, 12, 22, 17, 30, 00));
            c3.Descricao = "compromisso c3";
            c3.Datahorafim = new DateTime(2021, 12, 22, 00, 00, 00);
            c3.Notificacao.Add(new notificação((byte)15, 'M', 'N'));
            c3.Notificacao.Add(new notificação((byte)5, 'M', 'N'));
            agenda.Add(c3);

            evento c5 = new evento("c5", "compromisso c5", new DateTime(2021, 12, 25, 14, 30, 00), new DateTime(2021, 12, 25, 15, 30, 00));
            c5.Notificacao.Add(new notificação((byte)10, 'M', 'N'));
            agenda.Add(c5);

            evento c6 = new evento("c6", "Compromisso c6", new DateTime(2021, 09, 24, 15, 30, 00), new DateTime(2021, 09, 25, 12, 00, 00));
            c6.Notificacao.Add(new notificação((byte)60, 'M', 'N'));
            agenda.Add(c6);

            evento c7;
            c7 = new evento();
            c7.Titulo = "c7";
            c7.Descricao = "Compromisso c7";
            c7.Datahorainicio = new DateTime(2021, 12, 25, 00, 00, 00);
            c7.Datahorafim = new DateTime(2021, 12, 25, 23, 59, 59);
            c7.Notificacao.Add(new notificação((byte)10, 'M', 'N'));
            c7.Notificacao.Add(new notificação((byte)5, 'M', 'N'));
            agenda.Add(c7);

            evento c8 = new evento("c8", new DateTime(2021, 04, 23, 07, 00, 00));
            c8.Descricao = "Compromisso c8";
            c8.Datahorafim = new DateTime(2021, 04, 25, 12, 30, 00);
            c8.Notificacao.Add(new notificação((byte)10, 'M', 'N'));
            agenda.Add(c8); */

            AtlzdataGridViewCompromisso();

        }
        
        public void AtlzdataGridViewCompromisso()
        {
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }
        public void AtlzdataGridViewNotificação()
        {
            compromisso aux = (compromisso)dataGridViewCompromisso.CurrentRow.DataBoundItem;
            dataGridViewNotificação.DataSource = null;
            dataGridViewNotificação.DataSource = aux.Notificacao;
        }    
        private void FormAgenda_Load(object sender, EventArgs e)
        {
          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            evento aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
            
        }

        private void dataGridViewNotificação_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }

        private void dataGridViewCompromisso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamic aux = (dynamic)dataGridViewCompromisso.CurrentRow.DataBoundItem;
           //MessageBox.Show($"{aux.GetType()}");
            if (aux != null)
            {
                //TextBoxTitulo.Text = aux.Titulo;
                //textBoxDescrição.Text = aux.Descricao;
                //dateTimePickerDatainicio.Value = aux.Datahorainicio;
                //dateTimePickerDataFim.Value = aux.Datahorafim;
                dataGridViewNotificação.DataSource = null;
                dataGridViewNotificação.DataSource = aux.Notificacao;
                
            }
        }
       
        private void dataGridViewCompromisso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //compromisso aux = (compromisso)dataGridViewCompromisso.CurrentRow.DataBoundItem;
            dynamic aux = dataGridViewCompromisso.CurrentRow.DataBoundItem;
            MessageBox.Show($"{aux.GetType()}");


            if (aux is evento)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;           
            }
            else if (aux is Tarefa)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;
            }
            else if (aux is Lembrete)
            {
                new FormAgenda2(agenda, aux).ShowDialog();
                dataGridViewCompromisso.DataSource = null;
                dataGridViewCompromisso.DataSource = agenda;
            }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDatainicio_ValueChanged(object sender, EventArgs e)
        {

        }
        //novo tarefa.
        private void SalvarTarefa_Click(object sender, EventArgs e)
        {
            Tarefa aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }

        private void NovoLembrete_Click(object sender, EventArgs e)
        {
            Lembrete aux = new();
            FormAgenda2 formAge2 = new FormAgenda2(aux, agenda, dataGridViewCompromisso, monthCalendarDataInicio, monthCalendarDatafim);
            formAge2.ShowDialog();
            dataGridViewCompromisso.DataSource = null;
            dataGridViewCompromisso.DataSource = agenda;
        }
    }
}
