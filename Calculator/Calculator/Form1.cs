using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            
        }
       

        private void Nhapso(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Nhapso(btn.Text);
         }

        bool isTypingNumber = false;
        private void Nhapso(string so)
        {
            if (isTypingNumber)
                lblDisplay.Text = lblDisplay.Text + SO;
            else
                lblDisplay.Text = SO;
            isTypingNumber = true;

        }

        private void frmMain_Click(object sender, EventArgs e)
        {

        }
    }
}
