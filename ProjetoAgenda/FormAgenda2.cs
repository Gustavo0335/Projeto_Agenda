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
    public partial class FormAgenda2 : Form
    {
        List<compromisso> agenda;
        dynamic aux;
        public FormAgenda2(List<compromisso> agenda)
        {
            
            this.agenda = agenda;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent(); 
            comboBoxDescrição.DataSource = Enum.GetValues(typeof(EnumDescrição));
            comboBoxDescrição.SelectedIndex = -1;
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipo));
            comboBoxTipo.SelectedIndex = -1;
            comboBoxTarefa.DataSource = Enum.GetValues(typeof(EnumTarefa));
            comboBoxTarefa.SelectedIndex = -1;
            editarCompromisso.Enabled = false;
            editarNotificação.Enabled = false;
            salvarCompromisso.Enabled = true;
            salvarNotificação.Enabled = false;
            excluirCompromisso.Enabled = false;
            editarNotificação.Enabled = false;
            excluirNotificação.Enabled = false;
            SalvarEvento.Enabled = false;
            EditarEventos.Enabled = false;
            ExcluirEventos.Enabled = false;
            comboBoxTarefa.DataSource = Enum.GetValues(typeof(EnumTarefa));
            comboBoxTarefa.SelectedIndex = -1;
        }
        public FormAgenda2(dynamic aux, List<compromisso>agenda, DataGridView DataGridComp, MonthCalendar monthCalendarDataInicio, MonthCalendar monthCalendarDatafim)
        {
            this.aux = aux; 
            this.agenda = agenda;
            InitializeComponent();
            textBoxTitulo.Text = aux.Titulo;
            textBoxDescrição.Text = aux.Descricao;
           // textBoxLocal.Text = aux.Local;
            dateTimeDataInicio2.Value = monthCalendarDataInicio.SelectionStart;
            dateTimePickerDataFim2.Value = monthCalendarDatafim.SelectionEnd;
            listBoxNotificação2.DataSource = null;
            listBoxNotificação2.DataSource = aux.Notificacao;
            editarCompromisso.Enabled = true;
            editarNotificação.Enabled = true;
            salvarCompromisso.Enabled = true;
            salvarNotificação.Enabled = true;
            excluirCompromisso.Enabled = true;
            editarNotificação.Enabled = true;
            SalvarEvento.Enabled = true;
            EditarEventos.Enabled = true;
            ExcluirEventos.Enabled = true;
            if (aux is evento)
            {
                textBoxLocal.Text = aux.Local;
            }
            else if (aux is Tarefa)
            {
                comboBoxTarefa.DataSource = Enum.GetValues(typeof(EnumTarefa));
                comboBoxTarefa.SelectedIndex = -1;
            }
            else if (aux is Lembrete)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                comboBoxLembrete.DataSource = Enum.GetValues(typeof(EnumTipoLembrete));
                comboBoxLembrete.SelectedItem = -1;
                comboBoxLembrete.SelectedItem = (EnumTipoLembrete)aux.TipoLembrete;
                numericUpDown1.Value = aux.TempoLembrete;
                comboBoxRepetir.DataSource = Enum.GetValues(typeof(EnumRepetirLembrete));
                comboBoxRepetir.SelectedIndex = -1;
                comboBoxTerminar.DataSource = Enum.GetValues(typeof(EnumTerminarLembrete));
                comboBoxTerminar.SelectedIndex = -1;
            }

            comboBoxDescrição.DataSource = Enum.GetValues(typeof(EnumDescrição));
            comboBoxDescrição.SelectedIndex = -1;
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipo));
            comboBoxTipo.SelectedIndex = -1;
            comboBoxTarefa.DataSource = Enum.GetValues(typeof(EnumTarefa));
            comboBoxTarefa.SelectedIndex = -1;
            


        }
        public FormAgenda2( List<compromisso>agenda , dynamic aux)
        {
            this.aux = aux;
            this.agenda = agenda;
            InitializeComponent();
            textBoxTitulo.Text = aux.Titulo;
            textBoxDescrição.Text = aux.Descricao;
            dateTimeDataInicio2.Value = aux.Datahorainicio;
            dateTimePickerDataFim2.Value = aux.Datahorafim;
            listBoxNotificação2.DataSource = null;
            listBoxNotificação2.DataSource = aux.Notificacao;
            editarCompromisso.Enabled = false;
            editarNotificação.Enabled = false;
            salvarCompromisso.Enabled = true;
            excluirCompromisso.Enabled = false;
            editarCompromisso.Enabled = false;
            SalvarEvento.Enabled = false;
            EditarEventos.Enabled = false;
            ExcluirEventos.Enabled = false;
            SalvarEvento.Enabled = true;
            EditarEventos.Enabled = false;
            ExcluirEventos.Enabled = false;
            

            comboBoxDescrição.DataSource = Enum.GetValues(typeof(EnumDescrição));
            comboBoxDescrição.SelectedIndex = -1;
            comboBoxTipo.DataSource = Enum.GetValues(typeof(EnumTipo));
            comboBoxTipo.SelectedIndex = -1;
            comboBoxTarefa.DataSource = Enum.GetValues(typeof(EnumTarefa));
            comboBoxTarefa.SelectedIndex = -1;
            if (aux is Tarefa)
            {
                comboBoxTarefa.SelectedItem = (EnumTarefa)aux.Prioridade;
            }
            else if (aux is Lembrete)
            {
                comboBoxLembrete.SelectedItem = (EnumTipoLembrete)aux.TipoLembrete;
                comboBoxRepetir.DataSource = Enum.GetValues(typeof(EnumRepetirLembrete));
                comboBoxRepetir.SelectedIndex = -1;
                comboBoxRepetir.SelectedItem = (EnumRepetirLembrete)aux.TempoLembrete;
                comboBoxRepetir.DataSource = Enum.GetValues(typeof(EnumRepetirLembrete));
                comboBoxRepetir.SelectedIndex = -1;

            }
            else if (aux is evento)
            {
                textBoxLocal.SelectedText = aux.Local;
                //textBoxConvidados.SelectedText = aux.Convidados;
            }

            

        }




        private void listBoxNotificação2_SelectedIndexChanged(object sender, EventArgs e)
        {
            notificação auxnotificação = (notificação)listBoxNotificação2.SelectedItem;

            if (auxnotificação != null)
            {
                numericUpDownTempo.Value = auxnotificação.tempo;
                comboBoxDescrição.SelectedItem = (EnumDescrição)auxnotificação.Unidade;
                comboBoxTipo.SelectedItem = (EnumTipo)auxnotificação.Tipo;

            }
            else
            {
                numericUpDownTempo.Value = 0;
                comboBoxDescrição.SelectedIndex = -1;
                comboBoxTipo.SelectedIndex = -1;
            }
        }

        private void salvarCompromisso_Click(object sender, EventArgs e)
        {
            if (aux is evento)
            {
                agenda.Add(new evento(textBoxTitulo.Text, textBoxDescrição.Text, dateTimeDataInicio2.Value, dateTimePickerDataFim2.Value, textBoxLocal.Text));
            }
            else if (aux is Tarefa)
           {
                agenda.Add(new Tarefa(textBoxTitulo.Text, textBoxDescrição.Text, dateTimeDataInicio2.Value, dateTimePickerDataFim2.Value, (char)(EnumTarefa)Enum.Parse(typeof(EnumTarefa), comboBoxTarefa.Text)));
            }
            else if(aux is Lembrete)
            {
                agenda.Add(new Lembrete(textBoxTitulo.Text, textBoxDescrição.Text, dateTimeDataInicio2.Value, dateTimePickerDataFim2.Value, (byte)numericUpDownTempo.Value, (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxLembrete.Text), auxdialembrete, (char)(EnumTerminarLembrete)Enum.Parse(typeof(EnumTerminarLembrete), comboBoxTerminar.Text)));        
            }
        }

        private void editarCompromisso_Click(object sender, EventArgs e)
        {
            var aux2 = (evento)aux;
            aux2.Titulo = textBoxTitulo.Text;
            aux2.Descricao = textBoxDescrição.Text;
            aux2.Datahorainicio = dateTimeDataInicio2.Value;
            aux2.Datahorafim = dateTimePickerDataFim2.Value;
            aux2.Local = textBoxLocal.Text;
        }

        private void excluirCompromisso_Click(object sender, EventArgs e)
        {
            agenda.Remove(aux);
        }

        private void voltarTela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarNotificação_Click(object sender, EventArgs e)
        {
            //aux.notificacao.Add(new notificação((byte)numericUpDownTempo.Value), (char)(EnumDescrição)Enum.Parse(typeof(EnumDescrição), comboBoxDescrição.Text, (char)(EnumTipo)Enum.Parse(typeof(EnumTipo), comboBoxTipo.Text)))));
            // aux.Notificacao.Add(new notificação((byte)numericUpDownTempo.Value, (char)(EnumDescrição)Enum.Parse(typeof(EnumDescrição), comboBoxDescrição.Text, (char)(EnumTipoLembrete)Enum.Parse(typeof(EnumTipoLembrete), comboBoxTipo.Text))));
            listBoxNotificação2.DataSource = null;
            listBoxNotificação2.DataSource = aux.Notificacao;
        }

        private void excluirNotificação_Click(object sender, EventArgs e)
        {
            notificação auxN = (notificação)listBoxNotificação2.SelectedItem;
            aux.Notificacao.Remove(auxN);
            listBoxNotificação2.DataSource = null;
            listBoxNotificação2.DataSource = aux.Notificacao;
        }

        private void editarNotificação_Click(object sender, EventArgs e)
        {
            notificação auxN = (notificação)listBoxNotificação2.SelectedItem;
            auxN.tempo = (byte)numericUpDownTempo.Value;
            auxN.Unidade = char.Parse(comboBoxDescrição.Text);
            auxN.Tipo = char.Parse(comboBoxTipo.Text);
        }

        private void listBoxConvidados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBoxConvidados != null)
            {
                textBoxConvidados.Text = listBoxConvidados.SelectedItem.ToString();
                SalvarEvento.Enabled = false;
                EditarEventos.Enabled = true;
                ExcluirEventos.Enabled = true;
            }

            else
            {

            }

        }

        private void SalvarEvento_Click(object sender, EventArgs e)
        {
            var aux2 = (evento)aux;
            aux2.Convidados.Add(textBoxConvidados.Text);
            listBoxConvidados.DataSource = null;
            listBoxConvidados.DataSource = aux2.Convidados;
        }

        private void EditarEventos_Click(object sender, EventArgs e)
        {
            var aux2 = (evento)aux;
            aux2.Convidados[listBoxConvidados.SelectedIndex] = textBoxConvidados.Text;
        }

        private void ExcluirEventos_Click(object sender, EventArgs e)
        {
            var aux2 = (evento)aux;
            aux2.Convidados.RemoveAt(listBoxConvidados.SelectedIndex);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
        ValueTuple<bool, bool, bool, bool, bool, bool, bool> auxdialembrete = (false, false, false, false, false, false, false);
        // internal ValueTuple<bool, bool, bool, bool, bool, bool, bool> DiaLembrete { get => DiaLembrete; set => DiaLembrete = value; }
        private void comboBoxRepetir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRepetir.Text == "Domingo")
            {
                auxdialembrete.Item1 = true;
            }
            else if (comboBoxRepetir.Text == "Segunda")
            {
                auxdialembrete.Item2 = true;
            }
            else if (comboBoxRepetir.Text == "Terça")
            {
                auxdialembrete.Item3 = true;
            }
            else if (comboBoxRepetir.Text == "Quarta")
            {
                auxdialembrete.Item4 = true;
            }
            else if (comboBoxRepetir.Text == "Quinta")
            {
                auxdialembrete.Item5 = true;
            }
            else if(comboBoxRepetir.Text == "Sexta")
            {
                auxdialembrete.Item6 = true;
            }
            else if(comboBoxRepetir.Text == "Sabado")
            {
                auxdialembrete.Item7 = true;
            }
        }
        //DateTime DateFim { get => DateFim; set => DateFim = value; }
        
        private void comboBoxLembrete_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
