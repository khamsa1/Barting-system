using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barting_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTransition_Tick(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 10;
                if (sidebar.Width <= 57) { 
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 157 )
                {
                    sidebarExpand= true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
