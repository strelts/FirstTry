using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTry
{
    public partial class FSuccess : Form
    {
        private FOfferGoldCredit fOffer;
        public FSuccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.OpenForms["FOfferGoldCredit"].Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FOfferGoldCredit"].Close();
            Close();
        }
    }
}
