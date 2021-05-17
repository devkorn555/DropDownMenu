using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropDownMenu
{
    public partial class Form1 : Form
    {

        Boolean menu1 = true;
        //Boolean menu2;
       // Boolean menu3;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (menu1)
            {
                PMenu1.Height += 10;
                if (PMenu1.MaximumSize.Height == PMenu1.MaximumSize.Height)
                {
                    menu1 = false;
                    timer1.Stop();
                   
                }
            }
            else
            {
                PMenu1.Height -= 10;
                if (PMenu1.MinimumSize.Height == PMenu1.MinimumSize.Height)
                {
                    menu1 = true;
                    timer1.Stop();
                  
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // menu1 = false;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PMenu1.Size = PMenu1.MinimumSize;
        }
    }
}
