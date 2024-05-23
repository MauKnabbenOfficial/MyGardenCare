namespace Teste
{
    partial class CuidadosAtividades
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
            groupBox2 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox4 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(258, 23);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 1;
            label1.Text = "CUIDADOS e ATIVIDADES";
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
            groupBox2.Location = new Point(12, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 201);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "FILTROS";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(294, 27);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(156, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.No;
            checkBox1.Size = new Size(110, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Realizadas";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 96);
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
            textBox1.Location = new Point(156, 49);
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
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Atividade";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(551, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 201);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cuidados";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(6, 30);
            button2.Name = "button2";
            button2.Size = new Size(102, 21);
            button2.TabIndex = 6;
            button2.Text = "ADICIONAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(6, 57);
            button1.Name = "button1";
            button1.Size = new Size(102, 21);
            button1.TabIndex = 7;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(6, 84);
            button3.Name = "button3";
            button3.Size = new Size(102, 21);
            button3.TabIndex = 8;
            button3.Text = "REMOVER";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(675, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 201);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Atividades";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(6, 84);
            button4.Name = "button4";
            button4.Size = new Size(102, 21);
            button4.TabIndex = 8;
            button4.Text = "REMOVER";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.MenuHighlight;
            button5.Location = new Point(6, 57);
            button5.Name = "button5";
            button5.Size = new Size(102, 21);
            button5.TabIndex = 7;
            button5.Text = "EDITAR";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.MenuHighlight;
            button6.Location = new Point(6, 30);
            button6.Name = "button6";
            button6.Size = new Size(102, 21);
            button6.TabIndex = 6;
            button6.Text = "ADICIONAR";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ControlLight;
            groupBox4.Location = new Point(12, 276);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(781, 162);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lista";
            // 
            // CuidadosAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "CuidadosAtividades";
            Text = "CuidadosAtividades";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox4;
    }
}