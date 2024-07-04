namespace ProjetoTematico.Product
{
    partial class ProductForm
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
            qtdEstoque = new TextBox();
            lblObservacoes = new Label();
            txtNome = new TextBox();
            btnSave = new Button();
            lblNome = new Label();
            label1 = new Label();
            txtObservacoes = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.BackColor = Color.YellowGreen;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.ForeColor = Color.DarkOliveGreen;
            lblH1.Location = new Point(51, 33);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(463, 50);
            lblH1.TabIndex = 26;
            lblH1.Text = "CADASTRO DE PRODUTO";
            // 
            // qtdEstoque
            // 
            qtdEstoque.Font = new Font("Segoe UI", 12F);
            qtdEstoque.Location = new Point(148, 163);
            qtdEstoque.Name = "qtdEstoque";
            qtdEstoque.Size = new Size(134, 29);
            qtdEstoque.TabIndex = 23;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservacoes.ForeColor = Color.White;
            lblObservacoes.Location = new Point(35, 162);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(100, 21);
            lblObservacoes.TabIndex = 25;
            lblObservacoes.Text = "Quantidade";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(148, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(280, 29);
            txtNome.TabIndex = 21;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(414, 272);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 27;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(35, 127);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 20;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 272);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 28;
            // 
            // txtObservacoes
            // 
            txtObservacoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtObservacoes.Location = new Point(148, 202);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(366, 61);
            txtObservacoes.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 200);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 30;
            label2.Text = "Observações";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(558, 313);
            Controls.Add(txtObservacoes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblH1);
            Controls.Add(qtdEstoque);
            Controls.Add(lblObservacoes);
            Controls.Add(txtNome);
            Controls.Add(btnSave);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "Cadastro de Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH1;
        private TextBox qtdEstoque;
        private Label lblObservacoes;
        private TextBox txtNome;
        private Button btnSave;
        private Label lblNome;
        private Label label1;
        private TextBox txtObservacoes;
        private Label label2;
    }
}