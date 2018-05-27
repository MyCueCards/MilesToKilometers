/********************************************************************
 * Assignment from SDEV 240                                         *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 134, Exercise 1):                             *
 * Write a GUI program named MilesToKilometersGUI that allows the   *
 * user to input a distance in miles and output the value in        *
 * kilometers. There are 1.6 kilometers in a mile.                  *
 ********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class MilesToKilometersGUI : Form
    {
        public MilesToKilometersGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //define variables
            const Double KilosPerMile = 1.6;
            double NumMiles, Factor;

            //set if to validate for numbers only in input
            if (double.TryParse(txtInput.Text, out NumMiles))
            {
                NumMiles = Convert.ToDouble(txtInput.Text);
                Factor = NumMiles * KilosPerMile;
                lblFactor.Text = NumMiles + " mile(s) is equal to " + Factor + " kilometer(s).";
            }
            else
            {
                lblFactor.Text = "ERROR! You must enter a number.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
