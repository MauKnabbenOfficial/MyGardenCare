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
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Location = new Point(126, 0);
            headerPanel.Size = new Size(674, 50);
            // 
            // headerLabel
            // 
            headerLabel.Size = new Size(674, 50);
            // 
            // footerPanel
            // 
            footerPanel.Location = new Point(126, 420);
            footerPanel.Size = new Size(674, 30);
            // 
            // footerLabel
            // 
            footerLabel.Size = new Size(674, 30);
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioBtnMenuItem, perfilToolStripMenuItem, jardimToolStripMenuItem, plantaToolStripMenuItem, produtoToolStripMenuItem, cronogramaToolStripMenuItem, trabalhoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(113, 19);
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
            mainPanel.Location = new Point(77, 53);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(723, 364);
            mainPanel.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            Controls.SetChildIndex(menuStrip1, 0);
            Controls.SetChildIndex(footerPanel, 0);
            Controls.SetChildIndex(headerPanel, 0);
            Controls.SetChildIndex(mainPanel, 0);
            headerPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}