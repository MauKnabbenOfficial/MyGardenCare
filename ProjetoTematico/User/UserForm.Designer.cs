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
            lblH1 = new Label();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btnFechar = new Button();
            IsAdmin = new CheckBox();
            label1 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            lblTelefone = new Label();
            lblCpf = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
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
            lblH1.TabIndex = 6;
            lblH1.Text = "CADASTRO DE USUÁRIO";
            lblH1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTelefone.HidePromptOnLeave = true;
            txtTelefone.ImeMode = ImeMode.NoControl;
            txtTelefone.Location = new Point(225, 148);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PromptChar = ' ';
            txtTelefone.Size = new Size(210, 29);
            txtTelefone.TabIndex = 3;
            txtTelefone.TextChanged += maskedTextBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCpf.HidePromptOnLeave = true;
            txtCpf.Location = new Point(225, 113);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.PromptChar = ' ';
            txtCpf.Size = new Size(210, 29);
            txtCpf.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(160, 224);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 25;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtSenha.Location = new Point(225, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(377, 29);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkOliveGreen;
            btnFechar.Location = new Point(688, 288);
            btnFechar.MaximumSize = new Size(100, 35);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 34);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // IsAdmin
            // 
            IsAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IsAdmin.AutoSize = true;
            IsAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IsAdmin.ForeColor = Color.White;
            IsAdmin.Location = new Point(225, 262);
            IsAdmin.Name = "IsAdmin";
            IsAdmin.Size = new Size(139, 25);
            IsAdmin.TabIndex = 6;
            IsAdmin.Text = "Administrador";
            IsAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 188);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 24;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(225, 184);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(377, 29);
            txtEmail.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(582, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.SeaGreen;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(141, 152);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 21);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone";
            // 
            // lblCpf
            // 
            lblCpf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.SeaGreen;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCpf.ForeColor = Color.White;
            lblCpf.Location = new Point(179, 116);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(38, 21);
            lblCpf.TabIndex = 18;
            lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(160, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(225, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 29);
            txtNome.TabIndex = 1;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 334);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(btnFechar);
            Controls.Add(IsAdmin);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblH1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblH1;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCpf;
        private Label label2;
        private TextBox txtSenha;
        private Button btnFechar;
        private CheckBox IsAdmin;
        private Label label1;
        private TextBox txtEmail;
        private Button btnSave;
        private Label lblTelefone;
        private Label lblCpf;
        private Label lblNome;
        private TextBox txtNome;
    }
}