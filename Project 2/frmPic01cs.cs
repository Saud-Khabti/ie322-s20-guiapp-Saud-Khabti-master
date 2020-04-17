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
    public partial class frmPic01cs : Form
    {
        public frmPic01cs()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                // picTry.Image = Image.FromFile("I:\\DrAtif_IE_KAU\\20180322\\IE322_S18_KAU\\IE322_S18_KAU\\res\\A.jpg");
                // picTry.Image = Image.FromFile("C: \\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"); // This may not work if you change the computer, Then you have to change this line
                // picTry.Image = Image.FromFile("G:\\IE322_ALL\\_IE322_S20\\20180404\\tiny_cc_jaixjz.png"); //absolute path

                picTry.Image = Image.FromFile("C:/Users/saaud/Pictures/ie 201 3D sketch/G class car.png"); // relative path
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
