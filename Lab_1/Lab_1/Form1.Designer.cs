namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonMRV = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonSuprise = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.buttonMOD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.buttonMRC = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox1.MaxLength = 17;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 45);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonMRV
            // 
            this.buttonMRV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMRV.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMRV.Location = new System.Drawing.Point(103, 129);
            this.buttonMRV.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMRV.Name = "buttonMRV";
            this.buttonMRV.Size = new System.Drawing.Size(86, 45);
            this.buttonMRV.TabIndex = 2;
            this.buttonMRV.Text = "MRV";
            this.buttonMRV.UseVisualStyleBackColor = true;
            this.buttonMRV.Click += new System.EventHandler(this.buttonMRV_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMPlus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMPlus.Location = new System.Drawing.Point(193, 129);
            this.buttonMPlus.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(86, 45);
            this.buttonMPlus.TabIndex = 3;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMMinus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMMinus.Location = new System.Drawing.Point(283, 129);
            this.buttonMMinus.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(86, 45);
            this.buttonMMinus.TabIndex = 4;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = true;
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMul.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.Location = new System.Drawing.Point(283, 192);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(86, 45);
            this.buttonMul.TabIndex = 8;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(283, 255);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(86, 45);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(283, 318);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(86, 45);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonSuprise
            // 
            this.buttonSuprise.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSuprise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSuprise.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuprise.Location = new System.Drawing.Point(103, 381);
            this.buttonSuprise.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.buttonSuprise.Name = "buttonSuprise";
            this.buttonSuprise.Size = new System.Drawing.Size(86, 45);
            this.buttonSuprise.TabIndex = 18;
            this.buttonSuprise.Text = ":)";
            this.buttonSuprise.UseVisualStyleBackColor = false;
            this.buttonSuprise.Click += new System.EventHandler(this.buttonSuprise_Click);
            // 
            // button0
            // 
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(13, 381);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(86, 45);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDIV.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDIV.Location = new System.Drawing.Point(283, 66);
            this.buttonDIV.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(86, 45);
            this.buttonDIV.TabIndex = 24;
            this.buttonDIV.Text = "/";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.buttonDIV_Click);
            // 
            // buttonMOD
            // 
            this.buttonMOD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMOD.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMOD.Location = new System.Drawing.Point(193, 66);
            this.buttonMOD.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMOD.Name = "buttonMOD";
            this.buttonMOD.Size = new System.Drawing.Size(86, 45);
            this.buttonMOD.TabIndex = 23;
            this.buttonMOD.Text = "MOD";
            this.buttonMOD.UseVisualStyleBackColor = true;
            this.buttonMOD.Click += new System.EventHandler(this.buttonMOD_Click);
            // 
            // buttonC
            // 
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(103, 66);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(86, 45);
            this.buttonC.TabIndex = 22;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOFF.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOFF.Location = new System.Drawing.Point(13, 66);
            this.buttonOFF.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(86, 45);
            this.buttonOFF.TabIndex = 21;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // buttonMRC
            // 
            this.buttonMRC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMRC.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMRC.Location = new System.Drawing.Point(13, 129);
            this.buttonMRC.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.buttonMRC.Name = "buttonMRC";
            this.buttonMRC.Size = new System.Drawing.Size(86, 45);
            this.buttonMRC.TabIndex = 25;
            this.buttonMRC.Text = "MRC";
            this.buttonMRC.UseVisualStyleBackColor = true;
            this.buttonMRC.Click += new System.EventHandler(this.buttonMRC_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(196, 381);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(176, 45);
            this.buttonResult.TabIndex = 27;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(193, 192);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 45);
            this.button9.TabIndex = 28;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 255);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 45);
            this.button4.TabIndex = 28;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(103, 255);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 45);
            this.button5.TabIndex = 28;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(193, 255);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 45);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(193, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 45);
            this.button2.TabIndex = 28;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(103, 192);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 45);
            this.button8.TabIndex = 28;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 192);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 0, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 45);
            this.button7.TabIndex = 28;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 436);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonMRC);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.buttonMOD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonSuprise);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMRV);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonMRV;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonSuprise;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Button buttonMOD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Button buttonMRC;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}

