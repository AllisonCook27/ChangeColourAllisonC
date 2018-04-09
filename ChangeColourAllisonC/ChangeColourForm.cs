/*
 * Created by: Allison Cook
 * Created on: 9 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Change colour
 * This program changes the colour of all objects when a button is clicked and changes
 * the colour of a label when clicked to a different colour than the button
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColourAllisonC
{
    public partial class frmChangeColour : Form
    {
        public frmChangeColour()
        {
            InitializeComponent();
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            //loop through each object and change the colour
            foreach (Control aControlObject in this.Controls)
            {

            }

        }

        private void lblChangeColour_Click(object sender, EventArgs e)
        {

        }
    }
}
