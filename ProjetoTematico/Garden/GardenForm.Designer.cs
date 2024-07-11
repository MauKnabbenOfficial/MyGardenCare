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
            lblNome = new Label();
            txtNomeJardim = new TextBox();
            lblLocal = new Label();
            txtLocal = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblH1
            // 
            lblH1.AutoSize = true;
            lblH1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblH1.Location = new Point(173, 9);
            lblH1.Name = "lblH1";
            lblH1.Size = new Size(424, 50);
            lblH1.TabIndex = 7;
            lblH1.Text = "CADASTRO DE JARDIM";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(268, 109);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 14;
            lblNome.Text = "NOME";
            // 
            // txtNomeJardim
            // 
            txtNomeJardim.Location = new Point(316, 106);
            txtNomeJardim.Name = "txtNomeJardim";
            txtNomeJardim.Size = new Size(121, 23);
            txtNomeJardim.TabIndex = 15;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(266, 141);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(44, 15);
            lblLocal.TabIndex = 16;
            lblLocal.Text = "LOCAL";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(316, 138);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(121, 23);
            txtLocal.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(325, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "SALVAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GardenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLocal);
            Controls.Add(lblLocal);
            Controls.Add(txtNomeJardim);
            Controls.Add(lblNome);
            Controls.Add(btnSave);
            Controls.Add(lblH1);
            Name = "GardenForm";
            Text = "GardenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblH1;
        private ComboBox comboBoxPermissao;
        private Label lblNome;
        private TextBox txtNomeJardim;
        private Label lblLocal;
        private TextBox txtLocal;
        private Button btnSave;
    }
}