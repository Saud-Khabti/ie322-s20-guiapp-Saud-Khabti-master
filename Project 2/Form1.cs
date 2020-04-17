using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Saud")
            {
                if (TxtPW.Text == "1846217")
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {

                    MessageBox.Show("Invalid Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username");

            }



        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();



        }

        private void BtnCombo_Click_1(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click_1(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void BtnPic01_Click(object sender, EventArgs e)
        {
            frmPic01cs frm = new frmPic01cs();
            frm.ShowDialog();
        }

        private void BtnRandom_Click_1(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCam_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
