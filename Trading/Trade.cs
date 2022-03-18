using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Trading
{
    public partial class Trade : Form
    {
        public Trade()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        private void Trade_Load(object sender, EventArgs e)
        {
            exchange_Click.Enabled = false;

        }

        private void controlButton()
        {
            while(yourAccount.Text.Trim().Length != string.Empty && yourAccount.Text.All(Char.IsLetter))




        }






        private void yourAccount_TextChanged(object sender, EventArgs e)
        {
            controlButton(); 
        }

        private void exchange_Click(object sender, EventArgs e)
        {

        }
    }
}

