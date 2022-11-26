using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAntHR.Advertisment;

namespace WebAntHR
{
    public partial class HR_admin_panel : Form
    {
        public HR_admin_panel()
        {
            InitializeComponent();
        }

        //private void addUserControl(Control uc)
        //{
            //addUserControl(uc, Controls);
        //}

        /*private void addUserControl(Control uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc);
        }*/
        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            //Add_Sourse adv = new Add_Sourse();
            //addUserControl(adv);
            this.Hide();
            Add_Sourse hr = new Add_Sourse();
            hr.Show();
        }

        private void movesidepanel(Button btn)
        {
            
        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
