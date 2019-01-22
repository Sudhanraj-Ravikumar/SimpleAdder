using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adder
{
    public partial class AdderForm : Form
    {
        AdderLogic adderLogic = new AdderLogic();
        int counter = 0;
        string FinalResult;
        public AdderForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
                FinalResult = string.Empty;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber1();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber2();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber3();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }

            if (string.IsNullOrEmpty(labelDisplay.Text))
                    labelDisplay.Text = adderLogic.GetNNumber4();
                else
                    labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber4();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber5();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber6();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber6();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber7();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber7();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber8();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber8();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber9();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber9();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (adderLogic.ResetCounter(counter))
            {
                adderLogic.Add(FinalResult);
                labelDisplay.Text = " ";
                counter = 0;
            }
            if (string.IsNullOrEmpty(labelDisplay.Text))
                labelDisplay.Text = adderLogic.GetNNumber0();
            else
                labelDisplay.Text = labelDisplay.Text + adderLogic.GetNNumber0();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FinalResult = string.Empty;
            labelDisplay.Text = adderLogic.Cancel();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            counter = 1;

            if (string.IsNullOrEmpty(labelDisplay.Text)||labelDisplay.Text=="0")
            {
                labelDisplay.Text = adderLogic.GetNNumber0();
            }
            string currentvale = labelDisplay.Text;
            string result = adderLogic.Add(currentvale);
            labelDisplay.Text = result;
            FinalResult = result;
            
            
        }
    }
}
