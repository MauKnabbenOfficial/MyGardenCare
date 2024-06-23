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
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            usuarioBtnMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            jardimToolStripMenuItem = new ToolStripMenuItem();
            plantaToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cronogramaToolStripMenuItem = new ToolStripMenuItem();
            trabalhoToolStripMenuItem = new ToolStripMenuItem();
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
            headerLabel.Size = new Size(1016, 50);
            // 
            // footerPanel
            // 
            footerPanel.Location = new Point(0, 594);
            footerPanel.Size = new Size(1016, 30);
            // 
            // footerLabel
            // 
            footerLabel.Size = new Size(1016, 30);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(130, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioBtnMenuItem, perfilToolStripMenuItem, jardimToolStripMenuItem, plantaToolStripMenuItem, produtoToolStripMenuItem, cronogramaToolStripMenuItem, trabalhoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioBtnMenuItem
            // 
            usuarioBtnMenuItem.Name = "usuarioBtnMenuItem";
            usuarioBtnMenuItem.Size = new Size(141, 22);
            usuarioBtnMenuItem.Text = "Usuario";
            usuarioBtnMenuItem.Click += usuarioBtnMenuItem_Click;
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(141, 22);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // jardimToolStripMenuItem
            // 
            jardimToolStripMenuItem.Name = "jardimToolStripMenuItem";
            jardimToolStripMenuItem.Size = new Size(141, 22);
            jardimToolStripMenuItem.Text = "Jardim";
            // 
            // plantaToolStripMenuItem
            // 
            plantaToolStripMenuItem.Name = "plantaToolStripMenuItem";
            plantaToolStripMenuItem.Size = new Size(141, 22);
            plantaToolStripMenuItem.Text = "Planta";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(141, 22);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // cronogramaToolStripMenuItem
            // 
            cronogramaToolStripMenuItem.Name = "cronogramaToolStripMenuItem";
            cronogramaToolStripMenuItem.Size = new Size(141, 22);
            cronogramaToolStripMenuItem.Text = "Cronograma";
            // 
            // trabalhoToolStripMenuItem
            // 
            trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            trabalhoToolStripMenuItem.Size = new Size(141, 22);
            trabalhoToolStripMenuItem.Text = "Trabalho";
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(133, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(880, 538);
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
            LayoutPanelMain.RowCount = 1;
            LayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
            Text = "Main";
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
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuarioBtnMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem jardimToolStripMenuItem;
        private ToolStripMenuItem plantaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem cronogramaToolStripMenuItem;
        private ToolStripMenuItem trabalhoToolStripMenuItem;
        private Panel mainPanel;
        private TableLayoutPanel LayoutPanelMain;
    }
}