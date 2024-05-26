using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace FirstTry
{
    public partial class Form1 : Form
    {
        private Form2 authForm;
        private FPromoCard promoCard;
       
      
        public Form1()
        {
            authForm = new Form2();
            InitializeComponent(); timer1.Start();




        }
    

  

      

     

      

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            Promocard.BackColor = Color.Transparent;   
            Time.BackColor = Color.Transparent;
          
            
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
           PayButton.BackColor = Color.Transparent;
          //  helloText.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
           

        }
        
        

     

       

      
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PayButton.Image = FirstTry.Properties.Resources.button_platezhi;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PayButton.Image = FirstTry.Properties.Resources.button_platezhi_;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime currentTimeSpan = DateTime.Now;
           

            //TimeSpan currentTimeSpan = DateTime.Now.TimeOfDay;

            Time.Text = currentTimeSpan.ToString("Дата: yyyy-MM-dd \n\nВремя: HH:mm:ss");
        }

       

        private void offer_Click(object sender, EventArgs e)
        {
            promoCard  = new FPromoCard();
            promoCard.Activate();
            promoCard.Show();
        }

        private void offer_MouseLeave(object sender, EventArgs e)
        {
            offer.Image = FirstTry.Properties.Resources.button_perejti_k_oformleniyu1;
        }

        private void offer_MouseHover(object sender, EventArgs e)
        {
            offer.Image = FirstTry.Properties.Resources.button_perejti_k_oformleniyu;
        }

        private void CashInButton_MouseHover(object sender, EventArgs e)
        {
            CashInButton.Image = FirstTry.Properties.Resources.button_vnesti_nalichnye_active;
        }

        private void CashInButton_MouseLeave(object sender, EventArgs e)
        {
            CashInButton.Image = FirstTry.Properties.Resources.button_vnesti_nalichnye;
        }

        private void CashOutButton_MouseHover(object sender, EventArgs e)
        {
            CashOutButton.Image = FirstTry.Properties.Resources.button_snyat_nalichnye_active;
        }

        private void CashOutButton_MouseLeave(object sender, EventArgs e)
        {
            CashOutButton.Image = FirstTry.Properties.Resources.button_snyat_nalichnye;
        }
    }
}
