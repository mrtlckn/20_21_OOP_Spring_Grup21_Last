using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void zorluk_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = false;


        }

      
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string difSecim = null;
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        difSecim = radio.Text;
                      
                    }
                }
            }

            string shapeSecim = null;
            foreach (Control control2 in this.groupBox3.Controls)
            {
                if (control2 is RadioButton)
                {
                    RadioButton radio2 = control2 as RadioButton;
                    if (radio2.Checked)
                    {
                        shapeSecim = radio2.Text;
                        
                    }
                }
            }
            string adet;
            adet = shapeTxt.Text;
            
            

            Write yazdir = new Write();
            //yazdir.dosyayaYaz(difSecim,shapeSecim);
            yazdir.NotCustom(difSecim, shapeSecim, adet);

            if(difRdBtn4.Checked == true)
            {
                string row, colm;
                row = txtRow.Text;
                colm = txtColm.Text;
                yazdir.Custom(row,colm, adet);
            }

       
            //Renk Secici
            string color = null , color2 = null, color3 = null;
           if(checkBox1.Checked == true)
            {
                color = "Red";               
            }
            if (checkBox2.Checked == true)
            {
                color2 = "Blue";
            }
            if (checkBox3.Checked == true)
            {
                color3 = "Yellow";
            }

            yazdir.Renk(color, color2,color3);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Name\n AhmetTelçeken MehmetCemilKaradaş \n OOP2 Lab \n 2022");
        }
    }
}
