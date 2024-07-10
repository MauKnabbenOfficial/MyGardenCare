namespace ProjetoTematico.User
{
    partial class UserGridForm
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
            label1 = new Label();
            lblH1 = new Label();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Administrador = new DataGridViewTextBoxColumn();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 70);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblH1
            // 
            lblH1.BackColor = Color.YellowGreen;
            lblH1.Dock = DockStyle.Top;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.ForeColor = Color.DarkOliveGreen;
            lblH1.Location = new Point(0, 0);
            lblH1.Name = "lblH1";
            lblH1.Padding = new Padding(20, 0, 20, 0);
            lblH1.Size = new Size(617, 50);
            lblH1.TabIndex = 27;
            lblH1.Text = "CONSULTA USUARIOS";
            lblH1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.SeaGreen;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Email, Administrador });
            dgvUsuarios.Location = new Point(12, 70);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(455, 318);
            dgvUsuarios.TabIndex = 28;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Administrador
            // 
            Administrador.HeaderText = "Administrador";
            Administrador.Name = "Administrador";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.DarkOliveGreen;
            btnEditar.Location = new Point(473, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 31);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar Usuário";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // UserGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(617, 450);
            Controls.Add(btnEditar);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblH1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserGridForm";
            Text = "UserGridForm";
            Load += UserGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblH1;
        private DataGridView dgvUsuarios;
        private Button btnEditar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Administrador;
    }
}