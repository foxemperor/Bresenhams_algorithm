
namespace AKG_lab01
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RadiusBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.circle_y = new System.Windows.Forms.TextBox();
            this.circle_x = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 503);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Линия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Точка А:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Точка Б:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "X:Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "X:Y";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(775, 49);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(30, 22);
            this.X1.TabIndex = 6;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(810, 49);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(30, 22);
            this.Y1.TabIndex = 7;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(775, 111);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(30, 22);
            this.X2.TabIndex = 8;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(811, 111);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(30, 22);
            this.Y2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Окружность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(775, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Радиус:";
            // 
            // RadiusBox
            // 
            this.RadiusBox.Location = new System.Drawing.Point(775, 283);
            this.RadiusBox.Name = "RadiusBox";
            this.RadiusBox.Size = new System.Drawing.Size(59, 22);
            this.RadiusBox.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(775, 439);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Линии";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(775, 466);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Эллипсы";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Построение";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(803, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "мышью:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(775, 494);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 21);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Квадраты";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // circle_y
            // 
            this.circle_y.Location = new System.Drawing.Point(810, 239);
            this.circle_y.Name = "circle_y";
            this.circle_y.Size = new System.Drawing.Size(30, 22);
            this.circle_y.TabIndex = 21;
            // 
            // circle_x
            // 
            this.circle_x.Location = new System.Drawing.Point(775, 239);
            this.circle_x.Name = "circle_x";
            this.circle_x.Size = new System.Drawing.Size(30, 22);
            this.circle_x.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(772, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "X:Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(772, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Центр круга:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.circle_y);
            this.Controls.Add(this.circle_x);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RadiusBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RadiusBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox circle_y;
        private System.Windows.Forms.TextBox circle_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

