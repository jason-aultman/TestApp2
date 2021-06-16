using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp2
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            ProcessArgs(args);
            
        }

        private void btnActivateTextBoxText_Click(object sender, EventArgs e)
        {
            UpdateTextBoxText("Textbox Updated");
        }

        private void UpdateTextBoxText(string text)
        {
            this.rtbOne.Text = text;
        }
        private void ProcessArgs(string[] args)
        {
            if (args.Length > 0)
            {
                if(args.Contains("autorun"))
                {
                UpdateTextBoxText(args[0]);
                }
                else if (args.Contains("fail"))
                {
                    UpdateTextBoxText("Load Failed");
                }

            }
        }
    }
}
