namespace ProjetoTematico.Garden
{
    partial class GardenForm
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
            lblH1 = new Label();
            txtEndereco = new TextBox();
            txtApelido = new TextBox();
            lblObservacoes = new Label();
            txtNome = new TextBox();
            btnSave = new Button();
            lblNome = new Label();
            lblApelido = new Label();
            SuspendLayout();
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.BackColor = Color.YellowGreen;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.ForeColor = Color.DarkOliveGreen;
            lblH1.Location = new Point(222, 61);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(424, 50);
            lblH1.TabIndex = 18;
            lblH1.Text = "CADASTRO DE JARDIM";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Segoe UI", 12F);
            txtEndereco.Location = new Point(188, 289);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(532, 29);
            txtEndereco.TabIndex = 15;
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtApelido.Location = new Point(188, 222);
            txtApelido.Multiline = true;
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(532, 61);
            txtApelido.TabIndex = 14;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.White;
            lblObservacoes.Location = new Point(101, 287);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(81, 21);
            lblObservacoes.TabIndex = 17;
            lblObservacoes.Text = "Endereço";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(188, 185);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(532, 29);
            txtNome.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(688, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 19;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(125, 187);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApelido.ForeColor = Color.White;
            lblApelido.Location = new Point(98, 222);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(84, 21);
            lblApelido.TabIndex = 16;
            lblApelido.Text = "Descrição";
            // 
            // GardenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lblH1);
            Controls.Add(txtEndereco);
            Controls.Add(txtApelido);
            Controls.Add(lblObservacoes);
            Controls.Add(txtNome);
            Controls.Add(btnSave);
            Controls.Add(lblNome);
            Controls.Add(lblApelido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GardenForm";
            Text = "GardenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH1;
        private TextBox txtEndereco;
        private TextBox txtApelido;
        private Label lblObservacoes;
        private TextBox txtNome;
        private Button btnSave;
        private Label lblNome;
        private Label lblApelido;
    }
}