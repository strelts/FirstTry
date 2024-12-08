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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace FirstTry
{
    public partial class FOfferGoldCredit : Form
    {
        private FPromoCard promoPage;
        private FSuccess fSuccess;
      
        public FOfferGoldCredit()
        {
            InitializeComponent();
        }

        private void PayButton_MouseLeave(object sender, EventArgs e)
        {
            PayButton.Image = FirstTry.Properties.Resources.button_otpravit_zayavku;
        }

        private void PayButton_MouseMove(object sender, MouseEventArgs e)
        {
            PayButton.Image = FirstTry.Properties.Resources.button_otpravit_zayavku_active;
        }
        private readonly string connectionStringClients = System.Configuration.ConfigurationManager.ConnectionStrings["DBClients"].ConnectionString;
      
        private void PayButton_Click(object sender, EventArgs e)
        {


            string query = "INSERT INTO [dbo].[ClientsOfferedCard] (Name, Phone) VALUES (@Name, @Phone)";
            using (SqlConnection connection = new SqlConnection(connectionStringClients))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Phone", textBox1.Text);
                    command.ExecuteNonQuery();
                }
            }
          
            fSuccess = new FSuccess();
            
            fSuccess.Show();
            // Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            promoPage = new FPromoCard();
            promoPage.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTimeSpan = DateTime.Now;


            //TimeSpan currentTimeSpan = DateTime.Now.TimeOfDay;

            Time.Text = currentTimeSpan.ToString("Дата: dd Мая yyyy\n\nВремя: HH:mm:ss");
        }

        private void FOfferGoldCredit_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }
    }
}
