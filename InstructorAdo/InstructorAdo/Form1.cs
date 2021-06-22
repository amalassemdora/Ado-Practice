using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace InstructorAdo
{
	public partial class Form1 : Form
	{
		SqlConnection con;

		public Form1()
		{
			InitializeComponent();
			//define connection
			fillgrid();
			//btn_insert.Enabled = true;
			//btn2.Enabled = false;
			//btn_update.Enabled = false;
		}
		void fillgrid()
		{
			con = new SqlConnection(@"Data Source=DESKTOP-QME387U\MSSQLSERVER01;Initial Catalog=ITI;Integrated Security=True");

			//define command 
			SqlCommand cmd = new SqlCommand("select I.*,d.dept_name from instructor I ,department d where I.dept_id = d.dept_id", con);
			SqlCommand cmd_dept = new SqlCommand("select dept_id,dept_name from department", con);

			//open connection
			con.Open();

			//execute query
			SqlDataReader dr = cmd.ExecuteReader();

			List<Instructor> inst = new List<Instructor>();
			while (dr.Read())
			{
				Instructor i = new Instructor();
				i.Id = int.Parse(dr["ins_id"].ToString());
				i.name = dr["ins_name"].ToString();
				i.dgree = dr["ins_degree"].ToString();
				i.salary = double.Parse(dr["salary"].ToString());
				i.department = dr["dept_name"].ToString();

				inst.Add(i);
			}
			
			//display result on grid
			dgv_instructor.DataSource = inst;
			dr.Close();
			dr = cmd_dept.ExecuteReader();
			List<department> depts = new List<department>();
			while (dr.Read())
			{
				department dept = new department();
				dept.d_id = (int)dr["dept_id"];
				dept.d_name =dr["dept_name"].ToString();

				depts.Add(dept);
			}
			
			cb_dept.DataSource = depts;
			cb_dept.DisplayMember = "d_name";
			cb_dept.ValueMember = "d_id";
			con.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
				SqlCommand cmd = new SqlCommand($"insert into instructor(ins_id,ins_name,ins_degree,salary,dept_id) values(@I_id,@I_name,@I_degree,@I_salary,@dept)", con);
				cmd.Parameters.AddWithValue("@I_id", txt_id.Text);
				cmd.Parameters.AddWithValue("@I_name", txt_name.Text);
				cmd.Parameters.AddWithValue("@I_degree", txt_degree.Text);
				cmd.Parameters.AddWithValue("@I_salary", txt_salary.Text);
				cmd.Parameters.AddWithValue("@dept", cb_dept.SelectedValue);


				con.Open();
				int RowEffected = cmd.ExecuteNonQuery();
				con.Close();
				if (RowEffected > 0)
				{
					txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";
					l_show.ForeColor = Color.Green;
					l_show.Text = "Instructor added successfully.";
					fillgrid();
				}
				else
				{
					l_show.ForeColor = Color.Red;
					l_show.Text = "Error: No date added.";
				}
		
			
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			int id = (int)dgv_instructor.SelectedRows[0].Cells["id"].Value;
			SqlCommand cmd = new SqlCommand("delete from instructor where ins_id = @id", con);
			cmd.Parameters.AddWithValue("@id", id);
			con.Open();
			int RowEffected = cmd.ExecuteNonQuery();
			con.Close();
			if (RowEffected>0)
			{
				txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";
				txt_id.Enabled = true;
				l_show.ForeColor = Color.Red;
				l_show.Text = "Instructor deleted successfully.";
				fillgrid();
			}
		}
		//update 
		//retrive date of selected row into textbox and combobox
		private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			l_show.Text = "";
			int IId = (int)dgv_instructor.SelectedRows[0].Cells["id"].Value;
			txt_id.Text = IId.ToString();
			string name = (string)dgv_instructor.SelectedRows[0].Cells["name"].Value;
			txt_name.Text = name.ToString();
			string degree = (string)dgv_instructor.SelectedRows[0].Cells["dgree"].Value;
			txt_degree.Text = degree.ToString();
			double salary = (double)dgv_instructor.SelectedRows[0].Cells["salary"].Value;
			txt_salary.Text = salary.ToString();
			string dept = (string)dgv_instructor.SelectedRows[0].Cells["department"].Value;
			cb_dept.Text = dept.ToString();
			//disable change in id
			txt_id.Enabled = false;
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("update instructor set ins_name = @name ,ins_degree = @degree,salary = @salary,dept_id = @dept where ins_id = @id", con);
			cmd.Parameters.AddWithValue("@id", txt_id.Text);
			cmd.Parameters.AddWithValue("@name", txt_name.Text);
			cmd.Parameters.AddWithValue("@degree", txt_degree.Text);
			cmd.Parameters.AddWithValue("@salary", txt_salary.Text);
			cmd.Parameters.AddWithValue("@dept", cb_dept.SelectedValue);
			con.Open();
			int RowEffected = cmd.ExecuteNonQuery();
			con.Close();
			if(RowEffected > 0)
			{
				txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";
				txt_id.Enabled = true;
				l_show.ForeColor = Color.Green;
				l_show.Text = "Instructor updated successfully.";
				fillgrid();
				
			}
			else
			{
				l_show.ForeColor = Color.Red;
				l_show.Text = "Update faild.";
			}
		}

		
	}
}