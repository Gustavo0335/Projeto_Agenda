
namespace Agenda
{
    partial class FormAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridViewCompromisso = new System.Windows.Forms.DataGridView();
            this.dataGridViewNotificação = new System.Windows.Forms.DataGridView();
            this.monthCalendarDataInicio = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarDatafim = new System.Windows.Forms.MonthCalendar();
            this.SalvarTarefa = new System.Windows.Forms.Button();
            this.NovoLembrete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificação)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(554, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Evento";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridViewCompromisso
            // 
            this.dataGridViewCompromisso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompromisso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCompromisso.Location = new System.Drawing.Point(43, 26);
            this.dataGridViewCompromisso.Name = "dataGridViewCompromisso";
            this.dataGridViewCompromisso.RowTemplate.Height = 25;
            this.dataGridViewCompromisso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompromisso.Size = new System.Drawing.Size(410, 174);
            this.dataGridViewCompromisso.TabIndex = 30;
            this.dataGridViewCompromisso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompromisso_CellContentClick);
            this.dataGridViewCompromisso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompromisso_CellContentDoubleClick);
            // 
            // dataGridViewNotificação
            // 
            this.dataGridViewNotificação.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotificação.Location = new System.Drawing.Point(43, 236);
            this.dataGridViewNotificação.Name = "dataGridViewNotificação";
            this.dataGridViewNotificação.RowTemplate.Height = 25;
            this.dataGridViewNotificação.Size = new System.Drawing.Size(410, 191);
            this.dataGridViewNotificação.TabIndex = 31;
            this.dataGridViewNotificação.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotificação_CellContentClick);
            // 
            // monthCalendarDataInicio
            // 
            this.monthCalendarDataInicio.Location = new System.Drawing.Point(510, 18);
            this.monthCalendarDataInicio.Name = "monthCalendarDataInicio";
            this.monthCalendarDataInicio.TabIndex = 32;
            // 
            // monthCalendarDatafim
            // 
            this.monthCalendarDatafim.Location = new System.Drawing.Point(510, 198);
            this.monthCalendarDatafim.Name = "monthCalendarDatafim";
            this.monthCalendarDatafim.TabIndex = 33;
            // 
            // SalvarTarefa
            // 
            this.SalvarTarefa.Location = new System.Drawing.Point(554, 401);
            this.SalvarTarefa.Name = "SalvarTarefa";
            this.SalvarTarefa.Size = new System.Drawing.Size(134, 23);
            this.SalvarTarefa.TabIndex = 34;
            this.SalvarTarefa.Text = "Tarefa";
            this.SalvarTarefa.UseVisualStyleBackColor = true;
            this.SalvarTarefa.Click += new System.EventHandler(this.SalvarTarefa_Click);
            // 
            // NovoLembrete
            // 
            this.NovoLembrete.Location = new System.Drawing.Point(554, 430);
            this.NovoLembrete.Name = "NovoLembrete";
            this.NovoLembrete.Size = new System.Drawing.Size(134, 23);
            this.NovoLembrete.TabIndex = 35;
            this.NovoLembrete.Text = "Lembrete";
            this.NovoLembrete.UseVisualStyleBackColor = true;
            this.NovoLembrete.Click += new System.EventHandler(this.NovoLembrete_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 478);
            this.Controls.Add(this.NovoLembrete);
            this.Controls.Add(this.SalvarTarefa);
            this.Controls.Add(this.monthCalendarDatafim);
            this.Controls.Add(this.monthCalendarDataInicio);
            this.Controls.Add(this.dataGridViewNotificação);
            this.Controls.Add(this.dataGridViewCompromisso);
            this.Controls.Add(this.button7);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormAgenda";
            this.Text = "Agenda ";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificação)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridViewCompromisso;
        private System.Windows.Forms.DataGridView dataGridViewNotificação;
        private System.Windows.Forms.MonthCalendar monthCalendarDataInicio;
        private System.Windows.Forms.MonthCalendar monthCalendarDatafim;
        private System.Windows.Forms.Button SalvarTarefa;
        private System.Windows.Forms.Button NovoLembrete;
    }
}

