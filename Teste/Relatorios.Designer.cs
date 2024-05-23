namespace Teste
{
    partial class Relatorios
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
            menuStrip1 = new MenuStrip();
            pLANTASToolStripMenuItem = new ToolStripMenuItem();
            aTIVIDADESREALIZADASToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Left;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(2, 2, 25, 2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pLANTASToolStripMenuItem, aTIVIDADESREALIZADASToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(273, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(240, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pLANTASToolStripMenuItem
            // 
            pLANTASToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pLANTASToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            pLANTASToolStripMenuItem.Name = "pLANTASToolStripMenuItem";
            pLANTASToolStripMenuItem.Size = new Size(70, 20);
            pLANTASToolStripMenuItem.Text = "PLANTAS";
            // 
            // aTIVIDADESREALIZADASToolStripMenuItem
            // 
            aTIVIDADESREALIZADASToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aTIVIDADESREALIZADASToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            aTIVIDADESREALIZADASToolStripMenuItem.Name = "aTIVIDADESREALIZADASToolStripMenuItem";
            aTIVIDADESREALIZADASToolStripMenuItem.Size = new Size(162, 20);
            aTIVIDADESREALIZADASToolStripMenuItem.Text = "ATIVIDADES REALIZADAS";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(134, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 201);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "FILTROS";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(139, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(70, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(92, 104);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Jardim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(92, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(294, 27);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(134, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 151);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relatório";
            // 
            // Relatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Relatorios";
            Text = "Relatorios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pLANTASToolStripMenuItem;
        private ToolStripMenuItem aTIVIDADESREALIZADASToolStripMenuItem;
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
    }
}