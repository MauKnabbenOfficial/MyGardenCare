namespace ProjetoTematico.Schedule
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblH1 = new Label();
            dgvCronograma = new DataGridView();
            IsFeito = new DataGridViewCheckBoxColumn();
            Planta = new DataGridViewTextBoxColumn();
            Atividade = new DataGridViewTextBoxColumn();
            Observacoes = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            DtaRealizacao = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dtaPeriodoIni = new DateTimePicker();
            dtaPeriodoFim = new DateTimePicker();
            label2 = new Label();
            btnConsultar = new Button();
            cbPlantas = new ComboBox();
            label3 = new Label();
            tipSomenteFeitas = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvCronograma).BeginInit();
            SuspendLayout();
            // 
            // lblH1
            // 
            lblH1.BackColor = Color.YellowGreen;
            lblH1.Dock = DockStyle.Top;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.ForeColor = Color.DarkOliveGreen;
            lblH1.Location = new Point(0, 0);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(800, 50);
            lblH1.TabIndex = 7;
            lblH1.Text = "CRONOGRAMA";
            lblH1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvCronograma
            // 
            dgvCronograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCronograma.BackgroundColor = Color.SeaGreen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCronograma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCronograma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCronograma.Columns.AddRange(new DataGridViewColumn[] { IsFeito, Planta, Atividade, Observacoes, Usuario, DtaRealizacao });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCronograma.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCronograma.Location = new Point(12, 163);
            dgvCronograma.Name = "dgvCronograma";
            dgvCronograma.ReadOnly = true;
            dgvCronograma.RowHeadersVisible = false;
            dgvCronograma.Size = new Size(776, 275);
            dgvCronograma.TabIndex = 8;
            // 
            // IsFeito
            // 
            IsFeito.HeaderText = "Feito";
            IsFeito.Name = "IsFeito";
            IsFeito.ReadOnly = true;
            // 
            // Planta
            // 
            Planta.HeaderText = "Planta";
            Planta.Name = "Planta";
            Planta.ReadOnly = true;
            // 
            // Atividade
            // 
            Atividade.HeaderText = "Atividade";
            Atividade.Name = "Atividade";
            Atividade.ReadOnly = true;
            // 
            // Observacoes
            // 
            Observacoes.HeaderText = "Observações";
            Observacoes.Name = "Observacoes";
            Observacoes.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // DtaRealizacao
            // 
            DtaRealizacao.HeaderText = "Data Realizacao";
            DtaRealizacao.Name = "DtaRealizacao";
            DtaRealizacao.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 86);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 9;
            label1.Text = "Período";
            // 
            // dtaPeriodoIni
            // 
            dtaPeriodoIni.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtaPeriodoIni.CustomFormat = "dd'/'MM'/'yyyy";
            dtaPeriodoIni.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtaPeriodoIni.Format = DateTimePickerFormat.Short;
            dtaPeriodoIni.Location = new Point(117, 85);
            dtaPeriodoIni.Name = "dtaPeriodoIni";
            dtaPeriodoIni.Size = new Size(200, 29);
            dtaPeriodoIni.TabIndex = 10;
            // 
            // dtaPeriodoFim
            // 
            dtaPeriodoFim.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtaPeriodoFim.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dtaPeriodoFim.Format = DateTimePickerFormat.Short;
            dtaPeriodoFim.Location = new Point(346, 85);
            dtaPeriodoFim.Name = "dtaPeriodoFim";
            dtaPeriodoFim.Size = new Size(200, 29);
            dtaPeriodoFim.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(322, 86);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 12;
            label2.Text = "a";
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.DarkOliveGreen;
            btnConsultar.Location = new Point(631, 100);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(104, 31);
            btnConsultar.TabIndex = 13;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cbPlantas
            // 
            cbPlantas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbPlantas.FormattingEnabled = true;
            cbPlantas.Location = new Point(117, 118);
            cbPlantas.Name = "cbPlantas";
            cbPlantas.Size = new Size(200, 29);
            cbPlantas.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 121);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 15;
            label3.Text = "Planta";
            // 
            // tipSomenteFeitas
            // 
            tipSomenteFeitas.AutoSize = true;
            tipSomenteFeitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tipSomenteFeitas.ForeColor = Color.White;
            tipSomenteFeitas.Location = new Point(346, 122);
            tipSomenteFeitas.Name = "tipSomenteFeitas";
            tipSomenteFeitas.Size = new Size(145, 25);
            tipSomenteFeitas.TabIndex = 16;
            tipSomenteFeitas.Text = "Somente Feitas";
            tipSomenteFeitas.UseVisualStyleBackColor = true;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(tipSomenteFeitas);
            Controls.Add(label3);
            Controls.Add(cbPlantas);
            Controls.Add(btnConsultar);
            Controls.Add(label2);
            Controls.Add(dtaPeriodoFim);
            Controls.Add(dtaPeriodoIni);
            Controls.Add(label1);
            Controls.Add(dgvCronograma);
            Controls.Add(lblH1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCronograma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH1;
        private DataGridView dgvCronograma;
        private DataGridViewCheckBoxColumn IsFeito;
        private DataGridViewTextBoxColumn Planta;
        private DataGridViewTextBoxColumn Atividade;
        private DataGridViewTextBoxColumn Observacoes;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn DtaRealizacao;
        private Label label1;
        private DateTimePicker dtaPeriodoIni;
        private DateTimePicker dtaPeriodoFim;
        private Label label2;
        private Button btnConsultar;
        private ComboBox cbPlantas;
        private Label label3;
        private CheckBox tipSomenteFeitas;
    }
}