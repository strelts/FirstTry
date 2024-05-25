namespace FirstTry
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
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenText = new System.Windows.Forms.Label();
            this.PassED = new System.Windows.Forms.TextBox();
            this.Logintxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(154, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScreenText
            // 
            this.ScreenText.AutoSize = true;
            this.ScreenText.ForeColor = System.Drawing.Color.LightGray;
            this.ScreenText.Location = new System.Drawing.Point(177, 124);
            this.ScreenText.Name = "ScreenText";
            this.ScreenText.Size = new System.Drawing.Size(129, 13);
            this.ScreenText.TabIndex = 1;
            this.ScreenText.Text = "Введите логин и пароль";
            this.ScreenText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScreenText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassED
            // 
            this.PassED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.PassED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PassED.Location = new System.Drawing.Point(126, 258);
            this.PassED.Name = "PassED";
            this.PassED.PasswordChar = '*';
            this.PassED.Size = new System.Drawing.Size(221, 13);
            this.PassED.TabIndex = 2;
            this.PassED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassED.TextChanged += new System.EventHandler(this.PassED_TextChanged);
            // 
            // Logintxt
            // 
            this.Logintxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.Logintxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logintxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Logintxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Logintxt.Location = new System.Drawing.Point(126, 204);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(221, 13);
            this.Logintxt.TabIndex = 4;
            this.Logintxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Logintxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(225, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(218, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохраненный пароль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(489, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logintxt);
            this.Controls.Add(this.PassED);
            this.Controls.Add(this.ScreenText);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Авторизация пользователя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ScreenText;
        private System.Windows.Forms.TextBox PassED;
        private System.Windows.Forms.TextBox Logintxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

