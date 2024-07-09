namespace ProjetoTematico.Product
{
    partial class ProductGridForm
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
            btnEditar = new Button();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            QtdEstoque = new DataGridViewTextBoxColumn();
            Observacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.YellowGreen;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 20, 0);
            label1.Size = new Size(800, 50);
            label1.TabIndex = 36;
            label1.Text = "CONSULTA PRODUTOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.DarkOliveGreen;
            btnEditar.Location = new Point(538, 82);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(144, 31);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "Editar Produto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = Color.SeaGreen;
            dgvProdutos.BorderStyle = BorderStyle.None;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, QtdEstoque, Observacao });
            dgvProdutos.Location = new Point(12, 82);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(520, 362);
            dgvProdutos.TabIndex = 34;
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
            // QtdEstoque
            // 
            QtdEstoque.HeaderText = "Qtd Estoque";
            QtdEstoque.Name = "QtdEstoque";
            QtdEstoque.Width = 150;
            // 
            // Observacao
            // 
            Observacao.HeaderText = "Observações";
            Observacao.Name = "Observacao";
            // 
            // ProductGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(dgvProdutos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductGridForm";
            Text = "ProductGridForm";
            Load += ProductGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnEditar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn QtdEstoque;
        private DataGridViewTextBoxColumn Observacao;
    }
}