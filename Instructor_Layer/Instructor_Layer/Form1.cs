using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Instructor_Layer.BusinessLayer;
using Instructor_Layer.Entities;

namespace Instructor_Layer
{
	public partial class Form1 : Form
	{
		DataTable dt;
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
		public Form1()
		{
			InitializeComponent();

			ReloadGrid();
			//Fill department dropdown
			DataTable dt_dept = new DataTable();
			dt_dept = DepartmentBusiness.getDept();
			cb_dept.DataSource = dt_dept;
			cb_dept.DisplayMember = "dept_name";
			cb_dept.ValueMember = "dept_id";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;
			lbl_status.Text = "";
		}
		public void ReloadGrid ()
		{
				dt = InstructorBusiness.getAll();
				dgv_instructor.DataSource = dt;
		}
		private void btn_Add_Click(object sender, EventArgs e)
		{
			//Check id
			if (CheckId(int.Parse(txt_id.Text)))
			{
				//Retrive date from input field
				Instructor Inst = new Instructor();
				Inst.Id = int.Parse(txt_id.Text);
				Inst.Name = txt_name.Text;
				Inst.Degree = txt_degree.Text;
				Inst.Salary = decimal.Parse(txt_salary.Text);
				Inst.Dept_Id = (int)cb_dept.SelectedValue;
				
				//Add date 
			    InstructorBusiness.add(Inst);

				//Reload grideview
				ReloadGrid();
				lbl_status.ForeColor = Color.Green;
				lbl_status.Text = "Successfully Added";
				txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";
				cb_dept.SelectedIndex = 0;

			}
			else
			{
				lbl_status.ForeColor = Color.Red;
				lbl_status.Text = "This id is exist, try another id. ";
				txt_id.Text = "";
			}
		}

		private void dgv_instructor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
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

		private void btn_update_Click(object sender, EventArgs e)
		{
			//Retrive date from input field
			Instructor Inst = new Instructor();
			Inst.Id = int.Parse(txt_id.Text);
			Inst.Name = txt_name.Text;
			Inst.Degree = txt_degree.Text;
			Inst.Salary = decimal.Parse(txt_salary.Text);
			Inst.Dept_Id = (int)cb_dept.SelectedValue;

			//Add date 
			InstructorBusiness.update(Inst);

			//Reload grideview
			ReloadGrid();
			lbl_status.ForeColor = Color.Green;
			lbl_status.Text = "Successfully updated";
			txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;
			cb_dept.SelectedIndex = 0;

			//Enable Id field
			txt_id.Enabled = true;
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txt_id.Text);
			InstructorBusiness.delete(Id);

			//Reload grideview
			ReloadGrid();
			lbl_status.ForeColor = Color.Red;
			lbl_status.Text = "Successfully deleted";
			txt_id.Text = txt_name.Text = txt_degree.Text = txt_salary.Text = "";

			//change the status of button and lable 
			btn_insert.Enabled = true;
			btn_update.Enabled = false;
			btn_delete.Enabled = false;
			cb_dept.SelectedIndex = 0;
			//Enable Id field
			txt_id.Enabled = true;
		}
	}
}
