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

namespace FirstTry
{
    public partial class Form1 : Form
    {
        private Form2 authForm;
       
      
        public Form1()
        {
            authForm = new Form2();
            InitializeComponent();
         

           
        }
    

  

        private void button1_Click(object sender, EventArgs e)
        {
            Auth SystemAuth = new Auth();
            string username = Logintxt.Text;
            string password = PassED.Text;
           
            if (SystemAuth.ValidateCredentials(username, password))//ValidateCredentials(username, password))
            {


                authForm.Show();

              
                this.Hide();


            }
            else
            {
                ScreenText.Text = "Неправильный логин или пароль";
                ScreenText.ForeColor = Color.Red;
                
               
               
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassED_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logintxt.Text = "artem"; PassED.Text = "parol";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

   
     
       
    }
}
