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
            dataPlantio = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(61, 135);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(124, 133);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(212, 29);
            txtNome.TabIndex = 1;
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApelido.ForeColor = Color.White;
            lblApelido.Location = new Point(48, 168);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(70, 21);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtApelido.Location = new Point(124, 170);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(212, 29);
            txtApelido.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.White;
            lblObservacoes.Location = new Point(11, 206);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(107, 21);
            lblObservacoes.TabIndex = 5;
            lblObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(124, 208);
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
            btnSave.Location = new Point(338, 307);
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
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 8;
            // 
            // dataPlantio
            // 
            dataPlantio.CustomFormat = "";
            dataPlantio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataPlantio.Format = DateTimePickerFormat.Short;
            dataPlantio.Location = new Point(506, 133);
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
            label1.Location = new Point(371, 135);
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
            ClientSize = new Size(800, 450);
            Controls.Add(lblH1);
            Controls.Add(panel1);
            Name = "PlantForm";
            Text = "UserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}