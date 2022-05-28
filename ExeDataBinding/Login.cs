using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataBinding
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "Nabila" && textBox2.Text == "nabila12345" && checkBox1.Checked)
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }
    }
}
