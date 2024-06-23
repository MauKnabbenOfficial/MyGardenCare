namespace ProjetoTematico
{
    partial class UserForm
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
            txtCpf = new TextBox();
            txtPhone = new TextBox();
            lblCpf = new Label();
            lblTelefone = new Label();
            lblH1 = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(290, 107);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(338, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(338, 138);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(338, 176);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(304, 146);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(271, 184);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "TELEFONE";
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.Location = new Point(155, 9);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(450, 50);
            lblH1.TabIndex = 6;
            lblH1.Text = "CADASTRO DE USUÁRIO";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(338, 214);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblH1);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(txtPhone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(panel1);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtPhone;
        private Label lblCpf;
        private Label lblTelefone;
        private Label lblH1;
        private Button btnSave;
        private Panel panel1;
    }
}