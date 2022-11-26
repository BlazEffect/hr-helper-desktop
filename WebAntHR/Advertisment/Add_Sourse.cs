using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAntHR.Advertisment
{
    public partial class Add_Sourse : Form
    {
        public Add_Sourse()
        {
            InitializeComponent();
        }

        private void Add_Sourse_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            HR_admin_panel hr = new HR_admin_panel();
            hr.Show();
        }
    }
}
