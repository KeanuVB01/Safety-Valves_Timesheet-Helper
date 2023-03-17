using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JVBTimeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 1;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            string output = count + ") " + calc() + "\n";
            txtOutput.AppendText(output);

            if(output.Contains("= - "))
            {
                txtOutput.SelectionStart = txtOutput.Text.Length - output.Length;
                txtOutput.SelectionLength = txtOutput.Text.Length;
                txtOutput.SelectionColor = Color.DarkRed;
            }
            
            count++;
            loadFunct();
        }

        void loadFunct()
        {
            txtStartH.Text = "07";
            txtStartMin.Text = "00";
            txtEndH.Text = "16";
            txtEndM.Text = "15";
            txtStartH.Focus();
            txtStartH.SelectAll();
            //cbxClose.Checked = false;
            cbxOpen.Checked = false;
            cbxFriday.Checked = false;
        }

        string calc()
        {
            int startTimeHour = 0, startTimeMin = 0, endTimeHour = 0, endTimeMin = 0, endTimeHour2, endTimeHour3;

            try
            {
                startTimeHour = int.Parse(txtStartH.Text);
                startTimeMin = int.Parse(txtStartMin.Text);
                endTimeHour = int.Parse(txtEndH.Text);
                endTimeHour2 = endTimeHour-1;
                endTimeMin = int.Parse(txtEndM.Text);
            }
            catch (FormatException)
            {
                return "Invalid";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
            if ((startTimeHour<0) || (startTimeHour > 23) || (startTimeHour > endTimeHour) || (endTimeHour < 0) || (endTimeHour > 23))
            {
                return "Invalid";
            }

            if ((startTimeMin < 0) || (startTimeMin > 59) || (endTimeMin < 0) || (endTimeMin > 59))
            {
                return "Invalid";
            }




            DateTime date1 = new DateTime(2022, 5, 5, startTimeHour,startTimeMin,0);
            DateTime date2 = new DateTime(2022, 5, 5, endTimeHour,endTimeMin,0);
            if ((date1 > date2))
            {
                return "Invalid";
            }
            TimeSpan ts = date2 - date1;

            string modifiers = "";

            if (cbxLunch.Checked)
            {
                modifiers = modifiers + " \t-Lunch";
                DateTime lunch1 = new DateTime(2022, 5, 5, 4, 0, 0);
                DateTime lunch2 = new DateTime(2022, 5, 5, 5, 15, 0);
                TimeSpan lunchdiff = lunch2 - lunch1;
                ts = ts.Subtract(lunchdiff);
            }

            if (cbxOpen.Checked)
            {
                modifiers = modifiers + " \t+Open";
                DateTime dateOpen1 = new DateTime(2022, 5, 5, 4, 0, 0);
                DateTime dateOpen2 = new DateTime(2022, 5, 5, 6, 0, 0);
                TimeSpan openDiff = dateOpen2 - dateOpen1;
                ts = ts.Add(openDiff);
            }

            //if (cbxClose.Checked)
            //{

            //    DateTime closeDT = new DateTime(2022, 5, 5, endTimeHour2, endTimeMin, 0);
            //    modifiers = modifiers + " \t+Close";
            //    TimeSpan opendiff = closeDT - date2;
            //    ts = ts.Add(opendiff);
            //}

            if (cbxFriday.Checked == false)
            {
                if (ts.Hours - 8 >= 0)
                {
                    return (date1.ToString("HH:mm") + "-" + date2.ToString("HH:mm") + "   Difference = + " + (ts.Hours - 8) + " : " + ts.Minutes + modifiers);
                }
                else
                {
                    //Get variable with 8 hours
                    DateTime lunch1 = new DateTime(2022, 5, 5, 8, 00, 0);
                    DateTime lunch2 = new DateTime(2022, 5, 5, 16, 00, 0);
                    TimeSpan lunchdiff = lunch2 - lunch1;

                    //Subtract ts from the 8 hours to get the difference
                    ts = lunchdiff.Subtract(ts);
                    return (date1.ToString("HH:mm") + "-" + date2.ToString("HH:mm") + "   Difference = - " + ts.Hours + " : " + ts.Minutes + modifiers);
                }
            }
            else
            {
                modifiers = modifiers + " \t+Friday";
                if (ts.Hours - 5 >= 0)
                {
                    return (date1.ToString("HH:mm") + "-" + date2.ToString("HH:mm") + "   Difference = + " + (ts.Hours - 5) + " : " + ts.Minutes + modifiers);
                }
                else
                {
                    //Get variable with 5 hours
                    DateTime lunch1 = new DateTime(2022, 5, 5, 8, 00, 0);
                    DateTime lunch2 = new DateTime(2022, 5, 5, 13, 00, 0);
                    TimeSpan lunchdiff = lunch2 - lunch1;

                    //Subtract ts from the 5 hours to get the difference
                    ts = lunchdiff.Subtract(ts);
                    return (date1.ToString("HH:mm") + "-" + date2.ToString("HH:mm") + "   Difference = - " + ts.Hours + " : " + ts.Minutes + modifiers);
                };
            }
            
            
                
            

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            count = 1;
            txtOutput.Clear();
            loadFunct();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFunct();
        }

        private void txtEndM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnCalc_Click(sender, e);
            }
        }

        private void cbxFriday_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFriday.Checked == true)
            {
                cbxLunch.Checked = false;
                cbxLunch.Enabled = false;
            }
            else
            {
                cbxLunch.Enabled = true;
            }
        }
    }
}
