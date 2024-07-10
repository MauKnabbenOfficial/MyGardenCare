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
            txtDescricao = new TextBox();
            lblObservacoes = new Label();
            txtNome = new TextBox();
            btnSave = new Button();
            lblNome = new Label();
            lblApelido = new Label();
            btnFechar = new Button();
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
            lblH1.TabIndex = 18;
            lblH1.Text = "CADASTRO DE JARDIM";
            lblH1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEndereco
            // 
            txtEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEndereco.Location = new Point(170, 120);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(532, 29);
            txtEndereco.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDescricao.Location = new Point(170, 155);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(532, 61);
            txtDescricao.TabIndex = 3;
            // 
            // lblObservacoes
            // 
            lblObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.White;
            lblObservacoes.Location = new Point(83, 123);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(81, 21);
            lblObservacoes.TabIndex = 17;
            lblObservacoes.Text = "Endereço";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(170, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(532, 29);
            txtNome.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(582, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(107, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // lblApelido
            // 
            lblApelido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApelido.ForeColor = Color.White;
            lblApelido.Location = new Point(80, 155);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(84, 21);
            lblApelido.TabIndex = 16;
            lblApelido.Text = "Descrição";
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkOliveGreen;
            btnFechar.Location = new Point(688, 312);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 31);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // GardenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 355);
            Controls.Add(btnFechar);
            Controls.Add(lblH1);
            Controls.Add(txtEndereco);
            Controls.Add(txtDescricao);
            Controls.Add(lblObservacoes);
            Controls.Add(txtNome);
            Controls.Add(btnSave);
            Controls.Add(lblNome);
            Controls.Add(lblApelido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GardenForm";
            Text = "GardenForm";
            Load += GardenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH1;
        private TextBox txtEndereco;
        private TextBox txtDescricao;
        private Label lblObservacoes;
        private TextBox txtNome;
        private Button btnSave;
        private Label lblNome;
        private Label lblApelido;
        private Button btnFechar;
    }
}