using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace check_internet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int con = check_connection();
            if (con == 0)
            {
                MessageBox.Show("Check The Internet Connection :(");
            }
            else
            {
                MessageBox.Show("You have the perfect inernet Connection !");
            }
            
        }


        public int check_connection(){
            int val = 0;
        bool conn = NetworkInterface.GetIsNetworkAvailable();
            if (conn == true)
            {
                val = 1;
            }
            else
            {
                val = 0;
            }

            return val;
        }

    }
}
