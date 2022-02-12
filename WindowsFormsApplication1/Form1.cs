using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows;
using System.Web;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=lp50-k4g-ind;Initial Catalog=HR1;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.hR1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR1DataSet.Empdetails' table. You can move, or remove it, as needed.
            this.empdetailsTableAdapter.Fill(this.hR1DataSet.Empdetails);
           con.Open();
           disp_data();

            // TODO: This line of code loads data into the 'hRDataSet.Employee' table. You can move, or remove it, as needed.
           // this.employeeTableAdapter.Fill(this.hR1DataSet.Empdetails);
        

        }

        public void subtn_Click(object sender, EventArgs e)
        {
            con.Open();
          //  SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (rdb1.Checked)
            {
                rdb1.Text = rdb1.Text;
            }
            else
            {
                rdb2.Text = rdb2.Text;

            }
            cmd.CommandText = "insert into Empdetails values('" + Empcodetxt.Text + "','" + nametxt.Text + "','" +depttxt.Text + "','" + rdb1.Checked + "','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"','" + pexptxt.Text + "','" + saltxt.Text + "','" + addrichtxt.Text + "')";
           // cmd.CommandText = "insert into Empdetails values('" + Empcodetxt.Text + "','" + nametxt.Text + "','" + depttxt.Text + "','" + pexptxt.Text + "','" + saltxt.Text + "','" + addrichtxt.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Reord added succesfully");


          //  con.Open();
            //con  = new SqlCommand("insert into Empdetails values('" + Empcodetxt.Text + "','" + nametxt.Text + "','"+depttxt.Text"','"+rdb1.Checked+"','"+rdb2.Checked+"','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"','"+pexptxt.Text+"','"+saltxt.Text+"','"+addrichtxt.Text+"')",con);

        }

        public void disp_data()
        {

           con.Open();
            // cmd = con.CreateCommand();
         
            cmd= new SqlCommand ("select * from Empdetails");
            dr = cmd.ExecuteReader();
            employeeDataGridView.DataSource = dr;
            employeeDataGridView.DataBind();
            con.Close();
            
         
        
            

        }

       /* private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.SearchName(this.hR1DataSet.Empdetails, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/


        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      /*  private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.empdetailsTableAdapter.FillBy(this.hR1DataSet.Empdetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        
    }
}
