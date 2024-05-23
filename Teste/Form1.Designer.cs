namespace Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbx1Teste = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbx1Teste
            // 
            cbx1Teste.FormattingEnabled = true;
            cbx1Teste.Location = new Point(72, 37);
            cbx1Teste.Name = "cbx1Teste";
            cbx1Teste.Size = new Size(170, 23);
            cbx1Teste.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(132, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(549, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(248, 187);
            button1.Name = "button1";
            button1.Size = new Size(343, 132);
            button1.TabIndex = 2;
            button1.Text = "Gerar Dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 481);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbx1Teste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbx1Teste;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
