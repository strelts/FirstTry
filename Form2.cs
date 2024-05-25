using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using Newtonsoft.Json;

namespace FirstTry
{
   
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        HttpR http_R = new HttpR();
        public Form2()
        {
            InitializeComponent();
        
              
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            mainForm.Show();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mainForm = new Form1();
            mainForm.Hide();
        }

        private async void button2_Click(object sender, EventArgs e)
        {



            http_R.SendHttp(textBox1);
        }
    }
}
