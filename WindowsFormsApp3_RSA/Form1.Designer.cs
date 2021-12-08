namespace WindowsFormsApp3_RSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMsgEncript = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxMsgDecript = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEncript = new System.Windows.Forms.Button();
            this.buttonDecript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "p=";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(107, 12);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ShortcutsEnabled = false;
            this.textBoxP.Size = new System.Drawing.Size(100, 20);
            this.textBoxP.TabIndex = 1;
            this.textBoxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(107, 35);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ.TabIndex = 3;
            this.textBoxQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "q=";
            // 
            // textBoxMsgEncript
            // 
            this.textBoxMsgEncript.Location = new System.Drawing.Point(441, 39);
            this.textBoxMsgEncript.Name = "textBoxMsgEncript";
            this.textBoxMsgEncript.Size = new System.Drawing.Size(100, 20);
            this.textBoxMsgEncript.TabIndex = 5;
            this.textBoxMsgEncript.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сообщение(m):";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(242, 24);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 7;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "e=";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(107, 65);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "n=";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(242, 50);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 11;
            this.textBoxD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "d=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Криптограмма(с):";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(192, 91);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 13;
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxMsgDecript
            // 
            this.textBoxMsgDecript.Location = new System.Drawing.Point(411, 91);
            this.textBoxMsgDecript.Name = "textBoxMsgDecript";
            this.textBoxMsgDecript.Size = new System.Drawing.Size(100, 20);
            this.textBoxMsgDecript.TabIndex = 15;
            this.textBoxMsgDecript.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Рассшифровка(M):";
            // 
            // buttonEncript
            // 
            this.buttonEncript.Location = new System.Drawing.Point(242, 138);
            this.buttonEncript.Name = "buttonEncript";
            this.buttonEncript.Size = new System.Drawing.Size(87, 23);
            this.buttonEncript.TabIndex = 16;
            this.buttonEncript.Text = "Зашифровать";
            this.buttonEncript.UseVisualStyleBackColor = true;
            this.buttonEncript.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDecript
            // 
            this.buttonDecript.Location = new System.Drawing.Point(335, 138);
            this.buttonDecript.Name = "buttonDecript";
            this.buttonDecript.Size = new System.Drawing.Size(100, 23);
            this.buttonDecript.TabIndex = 17;
            this.buttonDecript.Text = "Расшифровать";
            this.buttonDecript.UseVisualStyleBackColor = true;
            this.buttonDecript.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 173);
            this.Controls.Add(this.buttonDecript);
            this.Controls.Add(this.buttonEncript);
            this.Controls.Add(this.textBoxMsgDecript);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMsgEncript);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMsgEncript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxMsgDecript;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEncript;
        private System.Windows.Forms.Button buttonDecript;
    }
}

