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
    

  

      

     

      

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            PayButton.BackColor = Color.Transparent;
        }
        
        

        private void PayButton_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("asas");
        }

        private void PayButton_MouseHover(object sender, EventArgs e)
        {
            PayButton.BackgroundImage = FirstTry.Properties.Resources.button_platezhi_;
        }

        private void PayButton_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_MouseLeave(object sender, EventArgs e)
        {
            PayButton.BackgroundImage = FirstTry.Properties.Resources.button_platezhi;
            
        }
    }
}
