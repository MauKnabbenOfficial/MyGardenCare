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
            btnFechar = new Button();
            IsAdmin = new CheckBox();
            label1 = new Label();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SeaGreen;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(163, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNome.Location = new Point(228, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 29);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCpf.Location = new Point(228, 133);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(210, 29);
            txtCpf.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPhone.Location = new Point(228, 170);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 29);
            txtPhone.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.SeaGreen;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCpf.ForeColor = Color.White;
            lblCpf.Location = new Point(184, 137);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(38, 21);
            lblCpf.TabIndex = 4;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.SeaGreen;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(135, 174);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 21);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone";
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
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.DarkOliveGreen;
            btnSave.Location = new Point(399, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(IsAdmin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 8;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.DarkOliveGreen;
            btnFechar.Location = new Point(505, 300);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 35);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // IsAdmin
            // 
            IsAdmin.AutoSize = true;
            IsAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IsAdmin.ForeColor = Color.White;
            IsAdmin.Location = new Point(228, 244);
            IsAdmin.Name = "IsAdmin";
            IsAdmin.Size = new Size(139, 25);
            IsAdmin.TabIndex = 10;
            IsAdmin.Text = "Administrador";
            IsAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 211);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(228, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(377, 29);
            txtEmail.TabIndex = 9;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lblH1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckBox IsAdmin;
        private Label label1;
        private TextBox txtEmail;
        private Button btnFechar;
    }
}