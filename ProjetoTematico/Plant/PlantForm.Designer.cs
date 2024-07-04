namespace ProjetoTematico.Plant
{
    public partial class PlantForm
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblApelido = new Label();
            txtApelido = new TextBox();
            lblObservacoes = new Label();
            txtObservacoes = new TextBox();
            lblH1 = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            dgvCuidados = new DataGridView();
            DescricaoCuidado = new DataGridViewTextBoxColumn();
            ObservacoesCuidado = new DataGridViewTextBoxColumn();
            Periodicidade = new DataGridViewTextBoxColumn();
            btnAddCuidado = new Button();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboPeriodicidade = new ComboBox();
            label3 = new Label();
            txtObservacoesCuidado = new TextBox();
            txtDescricaoCuidado = new TextBox();
            dataPlantio = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuidados).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(65, 107);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(128, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(212, 29);
            txtNome.TabIndex = 1;
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApelido.ForeColor = Color.White;
            lblApelido.Location = new Point(52, 140);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(70, 21);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtApelido.Location = new Point(128, 142);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(212, 29);
            txtApelido.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.White;
            lblObservacoes.Location = new Point(15, 178);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(107, 21);
            lblObservacoes.TabIndex = 5;
            lblObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtObservacoes.Location = new Point(128, 180);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(532, 61);
            txtObservacoes.TabIndex = 3;
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.BackColor = Color.YellowGreen;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.ForeColor = Color.DarkOliveGreen;
            lblH1.Location = new Point(155, 9);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(449, 50);
            lblH1.TabIndex = 6;
            lblH1.Text = "CADASTRO DE PLANTAS";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(688, 653);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataPlantio);
            panel1.Controls.Add(txtObservacoes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtApelido);
            panel1.Controls.Add(lblObservacoes);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblApelido);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 696);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvCuidados);
            panel2.Controls.Add(btnAddCuidado);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboPeriodicidade);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtObservacoesCuidado);
            panel2.Controls.Add(txtDescricaoCuidado);
            panel2.Location = new Point(12, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 372);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 0;
            label2.Text = "Cuidados";
            // 
            // dgvCuidados
            // 
            dgvCuidados.BackgroundColor = Color.DarkGreen;
            dgvCuidados.BorderStyle = BorderStyle.None;
            dgvCuidados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuidados.Columns.AddRange(new DataGridViewColumn[] { DescricaoCuidado, ObservacoesCuidado, Periodicidade });
            dgvCuidados.GridColor = Color.DarkGreen;
            dgvCuidados.Location = new Point(12, 227);
            dgvCuidados.Name = "dgvCuidados";
            dgvCuidados.Size = new Size(738, 128);
            dgvCuidados.TabIndex = 29;
            // 
            // DescricaoCuidado
            // 
            DescricaoCuidado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DescricaoCuidado.HeaderText = "Descrição";
            DescricaoCuidado.Name = "DescricaoCuidado";
            DescricaoCuidado.Width = 83;
            // 
            // ObservacoesCuidado
            // 
            ObservacoesCuidado.HeaderText = "Observações";
            ObservacoesCuidado.Name = "ObservacoesCuidado";
            // 
            // Periodicidade
            // 
            Periodicidade.HeaderText = "Periodicidade";
            Periodicidade.Name = "Periodicidade";
            // 
            // btnAddCuidado
            // 
            btnAddCuidado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddCuidado.ForeColor = Color.DarkOliveGreen;
            btnAddCuidado.Location = new Point(591, 170);
            btnAddCuidado.Name = "btnAddCuidado";
            btnAddCuidado.Size = new Size(168, 36);
            btnAddCuidado.TabIndex = 28;
            btnAddCuidado.Text = "Adicionar Cuidado";
            btnAddCuidado.UseVisualStyleBackColor = true;
            btnAddCuidado.Click += btnAddCuidado_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 209);
            label6.Name = "label6";
            label6.Size = new Size(747, 15);
            label6.TabIndex = 13;
            label6.Text = "----------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 100);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 27;
            label4.Text = "Observações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 33);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 26;
            label5.Text = "Descrição";
            // 
            // comboPeriodicidade
            // 
            comboPeriodicidade.Font = new Font("Segoe UI", 12F);
            comboPeriodicidade.FormattingEnabled = true;
            comboPeriodicidade.Items.AddRange(new object[] { "Diário", "Semanal", "Quinzenal", "Mensal" });
            comboPeriodicidade.Location = new Point(143, 164);
            comboPeriodicidade.Name = "comboPeriodicidade";
            comboPeriodicidade.Size = new Size(185, 29);
            comboPeriodicidade.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 167);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 24;
            label3.Text = "Periodicidade";
            // 
            // txtObservacoesCuidado
            // 
            txtObservacoesCuidado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtObservacoesCuidado.Location = new Point(143, 100);
            txtObservacoesCuidado.Multiline = true;
            txtObservacoesCuidado.Name = "txtObservacoesCuidado";
            txtObservacoesCuidado.Size = new Size(616, 61);
            txtObservacoesCuidado.TabIndex = 23;
            // 
            // txtDescricaoCuidado
            // 
            txtDescricaoCuidado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDescricaoCuidado.Location = new Point(143, 33);
            txtDescricaoCuidado.Multiline = true;
            txtDescricaoCuidado.Name = "txtDescricaoCuidado";
            txtDescricaoCuidado.Size = new Size(616, 61);
            txtDescricaoCuidado.TabIndex = 22;
            // 
            // dataPlantio
            // 
            dataPlantio.CustomFormat = "";
            dataPlantio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataPlantio.Format = DateTimePickerFormat.Short;
            dataPlantio.Location = new Point(510, 105);
            dataPlantio.Name = "dataPlantio";
            dataPlantio.Size = new Size(150, 29);
            dataPlantio.TabIndex = 11;
            dataPlantio.Value = new DateTime(2024, 7, 3, 21, 18, 16, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 107);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 10;
            label1.Text = "Data do Plantio";
            // 
            // PlantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 696);
            ControlBox = false;
            Controls.Add(lblH1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlantForm";
            Text = "Cadastro de Planta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuidados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtApelido;
        private TextBox txtObservacoes;
        private Label lblApelido;
        private Label lblObservacoes;
        private Label lblH1;
        private Button btnSave;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dataPlantio;
        private Panel panel2;
        private Label label2;
        private ComboBox comboPeriodicidade;
        private Label label3;
        private TextBox txtObservacoesCuidado;
        private TextBox txtDescricaoCuidado;
        private Button btnAddCuidado;
        private Label label6;
        private Label label4;
        private Label label5;
        private DataGridView dgvCuidados;
        private DataGridViewTextBoxColumn DescricaoCuidado;
        private DataGridViewTextBoxColumn ObservacoesCuidado;
        private DataGridViewTextBoxColumn Periodicidade;
    }
}