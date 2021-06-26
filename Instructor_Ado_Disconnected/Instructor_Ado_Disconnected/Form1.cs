using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Instructor_Ado_Disconnected
{
	public partial class Instructor : Form
	{
		SqlConnection con;
		DataTable dt;
		DataTable dt1;
		SqlDataAdapter adapter;
		public bool CheckId(int id)
		{
			foreach (DataRow item in dt.Rows)
			{
				if (int.Parse(item["ins_id"].ToString()) == id)
				{
					return false;
				}
			}
			return true;
		}
		public Instructor()
		{
			InitializeComponent();
			con = new SqlConnection(@"Data Source=DESKTOP-QME387U\MSSQLSERVER01;Initial Catalog=ITI;Integrated Security=True");
			SqlCommand cmd = new SqlCommand("select * from instructor", con);
			SqlCommand cmd_dept = new SqlCommand("select dept_id,dept_name from department", con);
			SqlDataAdapter adapt = new SqlDataAdapter();
			adapt.SelectCommand = cmd;
			dt = new DataTable();
			adapt.Fill(dt);
			dgv_instructor.DataSource = dt;


			//Fill department dropdown
			dt1 = new DataTable();
			adapt.SelectCommand = cmd_dept;
			adapt.Fill(dt1);
			cb_dept.DataSource = dt1;
			cb_dept.DisplayMember = "dept_name";
			cb_dept.ValueMember = "dept_id";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;
			lbl_status.Text = "";
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			DataRow dr = dt.NewRow();
			//Check id
			if (CheckId(int.Parse(txt_id.Text)))
			{
				//Retrive date from input field
				dr["ins_id"] = int.Parse(txt_id.Text);
				dr["ins_name"] = txt_name.Text;
				dr["ins_degree"] = txt_degree.Text;
				dr["Salary"] = double.Parse(txt_salary.Text);
				dr["dept_id"] = cb_dept.SelectedValue;
				
				//Add data
				dt.Rows.Add(dr);

				//Reload grideview
				dgv_instructor.DataSource = dt;
				lbl_status.ForeColor = Color.Green;
				lbl_status.Text = "Successfully Added";
				txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";
			}
			else
			{
				lbl_status.ForeColor = Color.Red;
				lbl_status.Text = "This id is exist, try another id. ";
				txt_id.Text = "";
			}
		}
		//Select row 
		private void dgv_instructor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Retrive dta from selected row to the inputs
			txt_id.Text = dgv_instructor.SelectedRows[0].Cells[0].Value.ToString();
			txt_name.Text = dgv_instructor.SelectedRows[0].Cells[1].Value.ToString();
			txt_degree.Text = dgv_instructor.SelectedRows[0].Cells[2].Value.ToString();
			txt_salary.Text = dgv_instructor.SelectedRows[0].Cells[3].Value.ToString();
			cb_dept.SelectedValue = dgv_instructor.SelectedRows[0].Cells[4].Value.ToString();

			//change the status of button and lable 
			btn_insert.Enabled = false;
			btn_update.Enabled = true;
			btn_delete.Enabled = true;
			lbl_status.Text = "";

			//Disable change in id field
			txt_id.Enabled = false;
		}
		//Update Button
		private void btn_update_Click(object sender, EventArgs e)
		{
			foreach (DataRow item in dt.Rows)
			{
				//get the row by id
				if (int.Parse(item["ins_id"].ToString()) == int.Parse(txt_id.Text))
				{
					item["ins_name"] = txt_name.Text;
					item["ins_degree"] = txt_degree.Text;
					item["Salary"] = double.Parse(txt_salary.Text);
					item["dept_id"] = cb_dept.SelectedValue;
				}
			}
			//Reload gridview
			dgv_instructor.DataSource = dt;
			lbl_status.ForeColor = Color.Green;
			lbl_status.Text = "Successfully updated";
			txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;

			//Enable Id field
			txt_id.Enabled = true;

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DataRow dr = dt.Rows[dgv_instructor.CurrentRow.Index];
			dr.Delete();
			//Reload gridview
			dgv_instructor.DataSource = dt;
			lbl_status.ForeColor = Color.Red;
			lbl_status.Text = "Successfully deleted";
			txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;

			//Enable Id field
			txt_id.Enabled = true;
		}

		private void Instructor_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Insert command
			SqlCommand cmd_Insert = new SqlCommand("insert into instructor values(@id,@name,@degree,@salary,@deptId)",con);
			cmd_Insert.Parameters.Add("@id", SqlDbType.Int, 4, "ins_id");
			cmd_Insert.Parameters.Add("@name", SqlDbType.NVarChar, 50, "ins_name");
			cmd_Insert.Parameters.Add("@degree", SqlDbType.NVarChar, 50, "ins_degree");
			cmd_Insert.Parameters.Add("@salary", SqlDbType.Decimal, 9, "Salary");
			cmd_Insert.Parameters.Add("@deptId", SqlDbType.Int, 4, "dept_id");

			//Update command
			SqlCommand cmd_update= new SqlCommand("update instructor set ins_name=@name,ins_degree=@degree,Salary=@salary,dept_id=@deptId where ins_id=@id", con);
			cmd_update.Parameters.Add("@id", SqlDbType.Int, 4, "ins_id");
			cmd_update.Parameters.Add("@name", SqlDbType.NVarChar, 50, "ins_name");
			cmd_update.Parameters.Add("@degree", SqlDbType.NVarChar, 50, "ins_degree");
			cmd_update.Parameters.Add("@salary", SqlDbType.Decimal, 9, "Salary");
			cmd_update.Parameters.Add("@deptId", SqlDbType.Int, 4, "dept_id");

			//Delete
			SqlCommand cmd_delete = new SqlCommand("delete from instructor where ins_id=@id", con);
			cmd_delete.Parameters.Add("@id", SqlDbType.Int, 4, "ins_id");

			adapter = new SqlDataAdapter();
			adapter.InsertCommand = cmd_Insert;
			adapter.UpdateCommand = cmd_update;
			adapter.DeleteCommand = cmd_delete;
			adapter.Update(dt);

		}
	}
}
