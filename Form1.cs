using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.cpu;
            lblComponentInfo.Text = "The central processing unit (CPU) is often labeled as the \"brain\" of the computer, processing data and executing all other hardware actions";
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.ram;
            lblComponentInfo.Text = "The random access memory (RAM) is a form of extremely fast storage that stores the data that is being used now";
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.ssd;
            lblComponentInfo.Text = "The solid state drive (SSD) is a slower kind of storage that stores the data that we want to use later";
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.psu;
            lblComponentInfo.Text = "The power supply (PSU) takes power from the wall, transforms it into the correct kind of current for the computer to use, then supplies it throughout the computer";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.peripherals;
            lblComponentInfo.Text = "An input peripheral is an external, separate device that takes user input and puts it into a language that the computer can understand";
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            imgComponents.Image = Properties.Resources.peripherals;
            lblComponentInfo.Text = "An output peripheral is an external, separate device that takes data from the computer and outputs it either visually or audibly";
        }
    }
}
