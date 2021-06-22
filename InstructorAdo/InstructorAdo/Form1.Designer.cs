
namespace InstructorAdo
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
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_degree = new System.Windows.Forms.TextBox();
			this.txt_salary = new System.Windows.Forms.TextBox();
			this.cb_dept = new System.Windows.Forms.ComboBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.l_show = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_instructor
			// 
			this.dgv_instructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_instructor.Location = new System.Drawing.Point(99, 223);
			this.dgv_instructor.Name = "dgv_instructor";
			this.dgv_instructor.Size = new System.Drawing.Size(564, 228);
			this.dgv_instructor.TabIndex = 0;
			this.dgv_instructor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
			// 
			// btn_insert
			// 
			this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_insert.Location = new System.Drawing.Point(136, 181);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(75, 23);
			this.btn_insert.TabIndex = 1;
			this.btn_insert.Text = "Insert";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(238, 181);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 23);
			this.btn2.TabIndex = 2;
			this.btn2.Text = "Delete";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(104, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(104, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Degree";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(104, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Salary";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(104, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Department";
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(195, 12);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(241, 20);
			this.txt_id.TabIndex = 8;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(195, 43);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(241, 20);
			this.txt_name.TabIndex = 9;
			// 
			// txt_degree
			// 
			this.txt_degree.Location = new System.Drawing.Point(195, 76);
			this.txt_degree.Name = "txt_degree";
			this.txt_degree.Size = new System.Drawing.Size(241, 20);
			this.txt_degree.TabIndex = 10;
			// 
			// txt_salary
			// 
			this.txt_salary.Location = new System.Drawing.Point(195, 111);
			this.txt_salary.Name = "txt_salary";
			this.txt_salary.Size = new System.Drawing.Size(241, 20);
			this.txt_salary.TabIndex = 11;
			// 
			// cb_dept
			// 
			this.cb_dept.FormattingEnabled = true;
			this.cb_dept.Location = new System.Drawing.Point(195, 142);
			this.cb_dept.Name = "cb_dept";
			this.cb_dept.Size = new System.Drawing.Size(243, 21);
			this.cb_dept.TabIndex = 12;
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(349, 181);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(75, 23);
			this.btn_update.TabIndex = 13;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// l_show
			// 
			this.l_show.AutoSize = true;
			this.l_show.ForeColor = System.Drawing.Color.Red;
			this.l_show.Location = new System.Drawing.Point(533, 186);
			this.l_show.Name = "l_show";
			this.l_show.Size = new System.Drawing.Size(0, 13);
			this.l_show.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.l_show);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.cb_dept);
			this.Controls.Add(this.txt_salary);
			this.Controls.Add(this.txt_degree);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.dgv_instructor);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Instructor";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_instructor;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_degree;
		private System.Windows.Forms.TextBox txt_salary;
		private System.Windows.Forms.ComboBox cb_dept;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Label l_show;
	}
}

