using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controller;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
         Query controller; public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr); //строка подключения 
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.upDatePerson();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            controller.Add(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }
    }
}
