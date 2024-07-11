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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            menuToolStrip = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroUsuarioBtnMenuItem = new ToolStripMenuItem();
            cadastroJardimBtnMenuItem = new ToolStripMenuItem();
            cadastroPlantaBtnMenuItem = new ToolStripMenuItem();
            cadastroProdutoBtnMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            consultaUsuarioBtnMenuItem = new ToolStripMenuItem();
            consultaPlantaBtnMenuItem = new ToolStripMenuItem();
            consultaProdutoBtnMenuItem = new ToolStripMenuItem();
            consultaCronogramaBtnMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            LayoutPanelMain = new TableLayoutPanel();
            btnSair = new Button();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            LayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(btnSair);
            headerPanel.Size = new Size(1016, 50);
            headerPanel.Controls.SetChildIndex(headerLabel, 0);
            headerPanel.Controls.SetChildIndex(btnSair, 0);
            // 
            // headerLabel
            // 
            headerLabel.BackColor = Color.DarkGreen;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(130, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStrip
            // 
            menuToolStrip.DropDownItems.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, consultasToolStripMenuItem });
            menuToolStrip.Font = new Font("Segoe UI", 12F);
            menuToolStrip.Name = "menuToolStrip";
            menuToolStrip.Size = new Size(62, 25);
            menuToolStrip.Text = "Menu";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroUsuarioBtnMenuItem, cadastroJardimBtnMenuItem, cadastroPlantaBtnMenuItem, cadastroProdutoBtnMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(149, 26);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroUsuarioBtnMenuItem
            // 
            cadastroUsuarioBtnMenuItem.Name = "cadastroUsuarioBtnMenuItem";
            cadastroUsuarioBtnMenuItem.Size = new Size(136, 26);
            cadastroUsuarioBtnMenuItem.Text = "Usuário";
            cadastroUsuarioBtnMenuItem.Click += usuarioBtnMenuItem_Click;
            // 
            // cadastroJardimBtnMenuItem
            // 
            cadastroJardimBtnMenuItem.Name = "cadastroJardimBtnMenuItem";
            cadastroJardimBtnMenuItem.Size = new Size(136, 26);
            cadastroJardimBtnMenuItem.Text = "Jardim";
            cadastroJardimBtnMenuItem.Click += jardimBtnMenuItem_Click;
            // 
            // cadastroPlantaBtnMenuItem
            // 
            cadastroPlantaBtnMenuItem.Name = "cadastroPlantaBtnMenuItem";
            cadastroPlantaBtnMenuItem.Size = new Size(136, 26);
            cadastroPlantaBtnMenuItem.Text = "Planta";
            cadastroPlantaBtnMenuItem.Click += plantaBtnMenuItem_Click;
            // 
            // cadastroProdutoBtnMenuItem
            // 
            cadastroProdutoBtnMenuItem.Name = "cadastroProdutoBtnMenuItem";
            cadastroProdutoBtnMenuItem.Size = new Size(136, 26);
            cadastroProdutoBtnMenuItem.Text = "Produto";
            cadastroProdutoBtnMenuItem.Click += produtoBtnMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultaUsuarioBtnMenuItem, consultaPlantaBtnMenuItem, consultaProdutoBtnMenuItem, consultaCronogramaBtnMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(149, 26);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaUsuarioBtnMenuItem
            // 
            consultaUsuarioBtnMenuItem.Name = "consultaUsuarioBtnMenuItem";
            consultaUsuarioBtnMenuItem.Size = new Size(168, 26);
            consultaUsuarioBtnMenuItem.Text = "Usuários";
            consultaUsuarioBtnMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // consultaPlantaBtnMenuItem
            // 
            consultaPlantaBtnMenuItem.Name = "consultaPlantaBtnMenuItem";
            consultaPlantaBtnMenuItem.Size = new Size(168, 26);
            consultaPlantaBtnMenuItem.Text = "Plantas";
            consultaPlantaBtnMenuItem.Click += consultaPlantaBtnMenuItem_Click;
            // 
            // consultaProdutoBtnMenuItem
            // 
            consultaProdutoBtnMenuItem.Name = "consultaProdutoBtnMenuItem";
            consultaProdutoBtnMenuItem.Size = new Size(168, 26);
            consultaProdutoBtnMenuItem.Text = "Produtos";
            consultaProdutoBtnMenuItem.Click += consultaProdutoBtnMenuItem_Click;
            // 
            // consultaCronogramaBtnMenuItem
            // 
            consultaCronogramaBtnMenuItem.Name = "consultaCronogramaBtnMenuItem";
            consultaCronogramaBtnMenuItem.Size = new Size(168, 26);
            consultaCronogramaBtnMenuItem.Text = "Cronograma";
            consultaCronogramaBtnMenuItem.Click += consultaCronogramaBtnMenuItem_Click;
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
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSair.ForeColor = Color.DarkOliveGreen;
            btnSair.Location = new Point(945, 9);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(59, 32);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1016, 624);
            Controls.Add(LayoutPanelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ToolStripMenuItem menuToolStrip;
        private Panel mainPanel;
        private TableLayoutPanel LayoutPanelMain;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem cadastroUsuarioBtnMenuItem;
        private ToolStripMenuItem cadastroJardimBtnMenuItem;
        private ToolStripMenuItem cadastroPlantaBtnMenuItem;
        private ToolStripMenuItem cadastroProdutoBtnMenuItem;
        private ToolStripMenuItem consultaUsuarioBtnMenuItem;
        private ToolStripMenuItem consultaPlantaBtnMenuItem;
        private ToolStripMenuItem consultaProdutoBtnMenuItem;
        private ToolStripMenuItem consultaCronogramaBtnMenuItem;
        private Button btnSair;
    }
}