using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAntHR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = Admin AND `pass` = 123", db.getConnection());

            command.Parameters.Add("Admin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("123", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            //adapter.Fill(table);

            /*if(table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
                MessageBox.Show("No");*/

            if (loginUser == "Admin" && passUser == "123")
            {
                //MessageBox.Show("Yes");
                this.Hide();
                HR_admin_panel hr = new HR_admin_panel();
                hr.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
