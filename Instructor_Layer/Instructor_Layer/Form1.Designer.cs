
namespace Instructor_Layer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv_instructor = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.lbl_status = new System.Windows.Forms.Label();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.txt_salary = new System.Windows.Forms.TextBox();
			this.txt_degree = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.cb_dept = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_instructor
			// 
			this.dgv_instructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_instructor.Location = new System.Drawing.Point(110, 270);
			this.dgv_instructor.Name = "dgv_instructor";
			this.dgv_instructor.Size = new System.Drawing.Size(562, 168);
			this.dgv_instructor.TabIndex = 0;
			this.dgv_instructor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instructor_RowHeaderMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(195, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(195, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(195, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Salary";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(195, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Degree";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(195, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Department";
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(189, 225);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(75, 23);
			this.btn_insert.TabIndex = 6;
			this.btn_insert.Text = "Save";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(286, 225);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(75, 23);
			this.btn_update.TabIndex = 7;
			this.btn_update.Text = "Edit";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(377, 225);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 8;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// lbl_status
			// 
			this.lbl_status.AutoSize = true;
			this.lbl_status.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_status.Location = new System.Drawing.Point(502, 226);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(0, 21);
			this.lbl_status.TabIndex = 9;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(304, 41);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(232, 20);
			this.txt_id.TabIndex = 10;
			// 
			// txt_salary
			// 
			this.txt_salary.Location = new System.Drawing.Point(304, 130);
			this.txt_salary.Name = "txt_salary";
			this.txt_salary.Size = new System.Drawing.Size(232, 20);
			this.txt_salary.TabIndex = 11;
			// 
			// txt_degree
			// 
			this.txt_degree.Location = new System.Drawing.Point(304, 102);
			this.txt_degree.Name = "txt_degree";
			this.txt_degree.Size = new System.Drawing.Size(232, 20);
			this.txt_degree.TabIndex = 12;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(304, 68);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(232, 20);
			this.txt_name.TabIndex = 13;
			// 
			// cb_dept
			// 
			this.cb_dept.FormattingEnabled = true;
			this.cb_dept.Location = new System.Drawing.Point(304, 166);
			this.cb_dept.Name = "cb_dept";
			this.cb_dept.Size = new System.Drawing.Size(232, 21);
			this.cb_dept.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cb_dept);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_degree);
			this.Controls.Add(this.txt_salary);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.lbl_status);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv_instructor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Instructor";
			((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_instructor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.TextBox txt_salary;
		private System.Windows.Forms.TextBox txt_degree;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.ComboBox cb_dept;
	}
}

