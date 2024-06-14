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
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(331, 143);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(386, 132);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(386, 184);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(114, 27);
            txtCpf.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(386, 235);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(347, 195);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(310, 245);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 20);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "TELEFONE";
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.Location = new Point(177, 12);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(572, 62);
            lblH1.TabIndex = 6;
            lblH1.Text = "CADASTRO DE USUÁRIO";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(386, 285);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(lblH1);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(txtPhone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}