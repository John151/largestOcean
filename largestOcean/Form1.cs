﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace largestOcean
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text;
            answer = answer.ToLower();

            //i thought contains would work better, accepts "pacific ocean" as answer, rejects
            //other oceans in case of cheating

            if (answer.Contains("southern"))
            {
                MessageBox.Show("Incorrect, the only answer is the \"Pacific\" Ocean", "Result"); ;
            }
            else if (answer.Contains("atlantic"))
            {
                MessageBox.Show("Incorrect, the only answer is the \"Pacific\" Ocean", "Result");
            }
            else if (answer.Contains("indian"))
            {
                MessageBox.Show("Incorrect, the only answer is the \"Pacific\" Ocean", "Result");
            }
            else if (answer.Contains("arctic"))
            {
                MessageBox.Show("Incorrect, the only answer is the \"Pacific\" Ocean", "Result");
            }
            else if (answer.Contains("pacific"))
            {
                MessageBox.Show("Correct!", "Result");
            }
            else
            {
                MessageBox.Show("Incorrect, the answer is the \"Pacific\" Ocean", "Result");
            }
        }
    }
}
