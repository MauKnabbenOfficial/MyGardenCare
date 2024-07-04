namespace ProjetoTematico
{
    partial class Main
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
            menuToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
            cadastroUsuarioBtnMenuItem = new ToolStripMenuItem();
            cadastroPerfilBtnMenuItem = new ToolStripMenuItem();
            cadastroJardimBtnMenuItem = new ToolStripMenuItem();
            plantaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cronogramaToolStripMenuItem = new ToolStripMenuItem();
            trabalhoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            LayoutPanelMain = new TableLayoutPanel();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            LayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Size = new Size(1016, 50);
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Segoe UI", 12F);
            headerLabel.Size = new Size(1016, 50);
            // 
            // footerPanel
            // 
            footerPanel.Location = new Point(0, 594);
            footerPanel.Size = new Size(1016, 30);
            // 
            // footerLabel
            // 
            footerLabel.Font = new Font("Segoe UI", 12F);
            footerLabel.Size = new Size(1016, 30);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(130, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem1, consultasToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(62, 25);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrosToolStripMenuItem1
            // 
            cadastrosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastroUsuarioBtnMenuItem, cadastroPerfilBtnMenuItem, cadastroJardimBtnMenuItem, plantaToolStripMenuItem, produtoToolStripMenuItem, cronogramaToolStripMenuItem, trabalhoToolStripMenuItem });
            cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            cadastrosToolStripMenuItem1.Size = new Size(180, 26);
            cadastrosToolStripMenuItem1.Text = "Cadastros";
            // 
            // cadastroUsuarioBtnMenuItem
            // 
            cadastroUsuarioBtnMenuItem.Name = "cadastroUsuarioBtnMenuItem";
            cadastroUsuarioBtnMenuItem.Size = new Size(180, 26);
            cadastroUsuarioBtnMenuItem.Text = "Usuario";
            cadastroUsuarioBtnMenuItem.Click += usuarioBtnMenuItem_Click;
            // 
            // cadastroPerfilBtnMenuItem
            // 
            cadastroPerfilBtnMenuItem.Name = "cadastroPerfilBtnMenuItem";
            cadastroPerfilBtnMenuItem.Size = new Size(180, 26);
            cadastroPerfilBtnMenuItem.Text = "Perfil";
            // 
            // cadastroJardimBtnMenuItem
            // 
            cadastroJardimBtnMenuItem.Name = "cadastroJardimBtnMenuItem";
            cadastroJardimBtnMenuItem.Size = new Size(180, 26);
            cadastroJardimBtnMenuItem.Text = "Jardim";
            cadastroJardimBtnMenuItem.Click += jardimBtnMenuItem_Click;
            // 
            // plantaToolStripMenuItem
            // 
            plantaToolStripMenuItem.Name = "plantaToolStripMenuItem";
            plantaToolStripMenuItem.Size = new Size(180, 26);
            plantaToolStripMenuItem.Text = "Planta";
            plantaToolStripMenuItem.Click += plantaBtnMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(180, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoBtnMenuItem_Click;
            // 
            // cronogramaToolStripMenuItem
            // 
            cronogramaToolStripMenuItem.Name = "cronogramaToolStripMenuItem";
            cronogramaToolStripMenuItem.Size = new Size(180, 26);
            cronogramaToolStripMenuItem.Text = "Cronograma";
            // 
            // trabalhoToolStripMenuItem
            // 
            trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            trabalhoToolStripMenuItem.Size = new Size(180, 26);
            trabalhoToolStripMenuItem.Text = "Trabalho";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(180, 26);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(133, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(880, 518);
            mainPanel.TabIndex = 3;
            // 
            // LayoutPanelMain
            // 
            LayoutPanelMain.ColumnCount = 2;
            LayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            LayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutPanelMain.Controls.Add(menuStrip1, 0, 0);
            LayoutPanelMain.Controls.Add(mainPanel, 1, 0);
            LayoutPanelMain.Dock = DockStyle.Fill;
            LayoutPanelMain.Location = new Point(0, 50);
            LayoutPanelMain.Name = "LayoutPanelMain";
            LayoutPanelMain.RowCount = 2;
            LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LayoutPanelMain.Size = new Size(1016, 544);
            LayoutPanelMain.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1016, 624);
            Controls.Add(LayoutPanelMain);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyGardenCare";
            Controls.SetChildIndex(footerPanel, 0);
            Controls.SetChildIndex(headerPanel, 0);
            Controls.SetChildIndex(LayoutPanelMain, 0);
            headerPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            LayoutPanelMain.ResumeLayout(false);
            LayoutPanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Panel mainPanel;
        private TableLayoutPanel LayoutPanelMain;
        private ToolStripMenuItem cadastrosToolStripMenuItem1;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem cadastroUsuarioBtnMenuItem;
        private ToolStripMenuItem cadastroPerfilBtnMenuItem;
        private ToolStripMenuItem cadastroJardimBtnMenuItem;
        private ToolStripMenuItem plantaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cronogramaToolStripMenuItem;
        private ToolStripMenuItem trabalhoToolStripMenuItem;
    }
}