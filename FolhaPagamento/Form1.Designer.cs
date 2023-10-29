namespace FolhaPagamento
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            textBox11 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 33);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 109);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 228);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 255);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Salario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 144);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 179);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefone:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 215);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Endereço:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 109);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 8;
            label9.Text = "Data de Admissão:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 149);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 11;
            label12.Text = "Departamento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(418, 187);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 12;
            label13.Text = "Data de Nascimento:";
            // 
            // button1
            // 
            button1.Location = new Point(656, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(62, 387);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(541, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(145, 212);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(208, 23);
            textBox7.TabIndex = 21;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(541, 141);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(145, 144);
            maskedTextBox2.Mask = "000.000.000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 28;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(145, 179);
            maskedTextBox1.Mask = "00 000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 29;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(541, 103);
            maskedTextBox4.Mask = "00/00/0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(541, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(145, 247);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 23);
            numericUpDown2.TabIndex = 34;
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Location = new Point(38, 78);
            label14.Name = "label14";
            label14.Size = new Size(727, 1);
            label14.TabIndex = 35;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(37, 347);
            label15.Name = "label15";
            label15.Size = new Size(727, 1);
            label15.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(numericUpDown2);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBox2);
            Controls.Add(textBox11);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox4;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown2;
        private Label label14;
        private Label label15;
    }
}