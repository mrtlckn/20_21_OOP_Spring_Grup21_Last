using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';

            this.AcceptButton = button1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lblFinal.Visible = true;
            
            User isim = new User();

            if (isim.Control(txtUsername.Text, txtPass.Text) == true)
            {
                lblFinal.Text = "Succesful";
                lblFinal.BackColor = Color.Green;
                MessageBox.Show("Giris Basarili");         
                this.Hide();
                MainGame newMainGame = new MainGame();
                newMainGame.ShowDialog();
            }

            else
            {
                lblFinal.Text = "Yanlis";
                lblFinal.BackColor = Color.Red;
            }
        }

        private void t_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
     
}
