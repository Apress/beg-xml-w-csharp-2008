using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
//using EmployeeLibrary;
using EmployeeClient.ServiceReference1;

namespace EmployeeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeClient.ServiceReference1.EmployeeServiceClient proxy = new EmployeeClient.ServiceReference1.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            DataSet ds = proxy.GetEmployees();
            listBox1.DataSource = ds.Tables[0].DefaultView;
            listBox1.DisplayMember = "FirstName";
            listBox1.ValueMember = "EmployeeID";
            proxy.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            EmployeeClient.ServiceReference1.EmployeeServiceClient proxy = new EmployeeClient.ServiceReference1.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            Employee emp = proxy.GetEmployee(int.Parse(listBox1.SelectedValue.ToString()));
            label5.Text = emp.EmployeeID.ToString();
            label6.Text = emp.FirstName;
            label7.Text = emp.LastName;
            proxy.Close();

        }
    }
}