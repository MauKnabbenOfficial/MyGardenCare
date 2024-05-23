namespace Teste
{
    partial class MainLayout
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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            rELATÓRIOSToolStripMenuItem = new ToolStripMenuItem();
            cUIDADOSToolStripMenuItem = new ToolStripMenuItem();
            cRONOGRAMAToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(245, 18);
            label1.Name = "label1";
            label1.Size = new Size(346, 67);
            label1.TabIndex = 0;
            label1.Text = "MyGardenCare";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(739, 18);
            button1.Name = "button1";
            button1.Size = new Size(49, 29);
            button1.TabIndex = 1;
            button1.Text = "Sair";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(2, 0, 0, 2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROToolStripMenuItem, rELATÓRIOSToolStripMenuItem, cUIDADOSToolStripMenuItem, cRONOGRAMAToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(9, 18);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(175, 148);
            menuStrip1.TabIndex = 2;
            menuStrip1.UseWaitCursor = true;
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cADASTROToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            cADASTROToolStripMenuItem.Margin = new Padding(0, 0, 0, 5);
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Padding = new Padding(5);
            cADASTROToolStripMenuItem.Size = new Size(164, 29);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            rELATÓRIOSToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rELATÓRIOSToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            rELATÓRIOSToolStripMenuItem.Margin = new Padding(0, 0, 0, 5);
            rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            rELATÓRIOSToolStripMenuItem.Padding = new Padding(5);
            rELATÓRIOSToolStripMenuItem.Size = new Size(164, 29);
            rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // cUIDADOSToolStripMenuItem
            // 
            cUIDADOSToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cUIDADOSToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            cUIDADOSToolStripMenuItem.Margin = new Padding(0, 0, 0, 5);
            cUIDADOSToolStripMenuItem.Name = "cUIDADOSToolStripMenuItem";
            cUIDADOSToolStripMenuItem.Padding = new Padding(5);
            cUIDADOSToolStripMenuItem.Size = new Size(164, 29);
            cUIDADOSToolStripMenuItem.Text = "CUIDADOS e ATIVIDADES";
            // 
            // cRONOGRAMAToolStripMenuItem
            // 
            cRONOGRAMAToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cRONOGRAMAToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            cRONOGRAMAToolStripMenuItem.Margin = new Padding(0, 0, 0, 5);
            cRONOGRAMAToolStripMenuItem.Name = "cRONOGRAMAToolStripMenuItem";
            cRONOGRAMAToolStripMenuItem.Padding = new Padding(5);
            cRONOGRAMAToolStripMenuItem.Size = new Size(164, 29);
            cRONOGRAMAToolStripMenuItem.Text = "CRONOGRAMA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(98, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 201);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aitividades da Semana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 82);
            label2.Name = "label2";
            label2.Size = new Size(173, 65);
            label2.TabIndex = 0;
            label2.Text = "HOME";
            // 
            // MainLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainLayout";
            Text = "MainLayout";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTROToolStripMenuItem;
        private ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private ToolStripMenuItem cUIDADOSToolStripMenuItem;
        private ToolStripMenuItem cRONOGRAMAToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
    }
}