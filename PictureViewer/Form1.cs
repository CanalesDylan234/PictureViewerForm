using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        // Field to store original background color 
        private Color originalBackColor;

        public Form1()
        {
            InitializeComponent();
            // Store the original background color 
            originalBackColor = pictureBox1.BackColor;
        }
        // Changes
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Button Events 
        private void ShowButton_Click_1(object sender, EventArgs e)
        {
            // provices the components properties and methods while showing the open file dialog
            // Show the open file dialog, if the user clicks OK, load the picture that the user chose
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           // Clears the picture
           pictureBox1.Image = null;
           pictureBox1.BackColor = originalBackColor;
        }

        private void BackgroundButton_Click_1(object sender, EventArgs e)
        {
            /*
             * Show the color dialog box. If the user clicks OK, 
             * change the picturebox control's background to the color user chooses 
             */
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the form 
            this.Close();
        }

        // Stretch Box
        private void StretchBox_CheckedChanged(object sender, EventArgs e)
        {
            /* 
             * If the user selects the Stretch box, change the Picturebox's size
             * SizeMode property to "Stretch" the picturebox and if the user clears the check box, it will be normal again 
             */
            if (StretchBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
