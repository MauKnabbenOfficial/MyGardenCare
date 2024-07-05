namespace ProjetoTematico.Plant
{
    partial class PlantGridForm
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
            btnEditar = new Button();
            dgvPlantas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataPlantio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPlantas).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.DarkOliveGreen;
            btnEditar.Location = new Point(422, 76);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 31);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar Planta";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvPlantas
            // 
            dgvPlantas.BackgroundColor = Color.SeaGreen;
            dgvPlantas.BorderStyle = BorderStyle.None;
            dgvPlantas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlantas.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, DataPlantio });
            dgvPlantas.Location = new Point(12, 76);
            dgvPlantas.Name = "dgvPlantas";
            dgvPlantas.Size = new Size(404, 362);
            dgvPlantas.TabIndex = 31;
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
            // DataPlantio
            // 
            DataPlantio.HeaderText = "Data do Plantio";
            DataPlantio.Name = "DataPlantio";
            DataPlantio.Width = 150;
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
            label1.Size = new Size(587, 50);
            label1.TabIndex = 33;
            label1.Text = "CONSULTA PLANTAS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlantGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(587, 450);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(dgvPlantas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlantGridForm";
            Text = "PlantGridForm";
            Load += PlantGridForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlantas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private DataGridView dgvPlantas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataPlantio;
        private Label label1;
    }
}