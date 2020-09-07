using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BashBlack
{
    public partial class Form1 : Form
    {
       
        int PanelWidth;
        bool Hidden;

        public Form1()
        {
            InitializeComponent();
            PanelWidth = panelFlowLayout.Width;
            Hidden = false;
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden) 
            {
                panelFlowLayout.Width = panelFlowLayout.Width + 25;
                if (panelFlowLayout.Width>= PanelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelFlowLayout.Width = panelFlowLayout.Width - 25;
                if (panelFlowLayout.Width<=10)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
