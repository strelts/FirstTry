﻿namespace FirstTry
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Promocard = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PayButton = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.offer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CashOutButton = new System.Windows.Forms.PictureBox();
            this.CashInButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Promocard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marte BANK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 82);
            this.panel1.TabIndex = 2;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(723, 13);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(58, 20);
            this.Time.TabIndex = 7;
            this.Time.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(358, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "+7 (999) 000 - 111 - 204";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Круглосуточная помощь клинтам";
            // 
            // Promocard
            // 
            this.Promocard.Image = global::FirstTry.Properties.Resources.cardsPromo;
            this.Promocard.Location = new System.Drawing.Point(386, 6);
            this.Promocard.Name = "Promocard";
            this.Promocard.Size = new System.Drawing.Size(114, 73);
            this.Promocard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Promocard.TabIndex = 7;
            this.Promocard.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Promocard);
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Location = new System.Drawing.Point(-1, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 96);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstTry.Properties.Resources._0b0b27d5f6aca7ab72eaa0ee4a3ade0b;
            this.pictureBox1.Location = new System.Drawing.Point(727, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PayButton
            // 
            this.PayButton.Image = global::FirstTry.Properties.Resources.button_platezhi;
            this.PayButton.Location = new System.Drawing.Point(19, 6);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(194, 66);
            this.PayButton.TabIndex = 7;
            this.PayButton.TabStop = false;
            this.PayButton.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.PayButton.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstTry.Properties.Resources.gold_card;
            this.pictureBox2.Location = new System.Drawing.Point(-42, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(529, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.offer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 386);
            this.panel3.TabIndex = 9;
            // 
            // offer
            // 
            this.offer.BackColor = System.Drawing.Color.Transparent;
            this.offer.Image = global::FirstTry.Properties.Resources.button_perejti_k_oformleniyu1;
            this.offer.Location = new System.Drawing.Point(132, 339);
            this.offer.Name = "offer";
            this.offer.Size = new System.Drawing.Size(171, 47);
            this.offer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.offer.TabIndex = 9;
            this.offer.TabStop = false;
            this.offer.Click += new System.EventHandler(this.offer_Click);
            this.offer.MouseLeave += new System.EventHandler(this.offer_MouseLeave);
            this.offer.MouseHover += new System.EventHandler(this.offer_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оформите бесплатную золотую карту";
            // 
            // CashOutButton
            // 
            this.CashOutButton.BackColor = System.Drawing.Color.Transparent;
            this.CashOutButton.Image = global::FirstTry.Properties.Resources.button_snyat_nalichnye;
            this.CashOutButton.Location = new System.Drawing.Point(491, 463);
            this.CashOutButton.Name = "CashOutButton";
            this.CashOutButton.Size = new System.Drawing.Size(355, 80);
            this.CashOutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CashOutButton.TabIndex = 10;
            this.CashOutButton.TabStop = false;
            this.CashOutButton.MouseLeave += new System.EventHandler(this.CashOutButton_MouseLeave);
            this.CashOutButton.MouseHover += new System.EventHandler(this.CashOutButton_MouseHover);
            // 
            // CashInButton
            // 
            this.CashInButton.BackColor = System.Drawing.Color.Transparent;
            this.CashInButton.Image = global::FirstTry.Properties.Resources.button_vnesti_nalichnye;
            this.CashInButton.Location = new System.Drawing.Point(491, 332);
            this.CashInButton.Name = "CashInButton";
            this.CashInButton.Size = new System.Drawing.Size(355, 80);
            this.CashInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CashInButton.TabIndex = 11;
            this.CashInButton.TabStop = false;
            this.CashInButton.MouseLeave += new System.EventHandler(this.CashInButton_MouseLeave);
            this.CashInButton.MouseHover += new System.EventHandler(this.CashInButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FirstTry.Properties.Resources.wL1RUC_XUeU;
            this.ClientSize = new System.Drawing.Size(877, 656);
            this.Controls.Add(this.CashInButton);
            this.Controls.Add(this.CashOutButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Logic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Promocard)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashOutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashInButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PayButton;
        private System.Windows.Forms.PictureBox Promocard;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox offer;
        private System.Windows.Forms.PictureBox CashOutButton;
        private System.Windows.Forms.PictureBox CashInButton;
    }
}

