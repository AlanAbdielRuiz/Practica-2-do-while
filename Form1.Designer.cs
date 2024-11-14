namespace Practica_2_do_while
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 39);
            label1.Name = "label1";
            label1.Size = new Size(339, 33);
            label1.TabIndex = 0;
            label1.Text = "TABLA DE MULTIPLICACIÓN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 136);
            label2.Name = "label2";
            label2.Size = new Size(296, 19);
            label2.TabIndex = 1;
            label2.Text = "Introduce el valor de la tabla de multiplicar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(477, 136);
            label3.Name = "label3";
            label3.Size = new Size(317, 19);
            label3.TabIndex = 2;
            label3.Text = "Límite máximo para la tabla de multiplicación";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(92, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(586, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(325, 168);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(154, 257);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(609, 362);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tablas de multiplicar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
    }
}