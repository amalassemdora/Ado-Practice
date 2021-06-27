using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Instructor_Layer.Entities;

namespace Instructor_Layer.BusinessLayer
{
	class InstructorBusiness
	{
		//Select All Instructor
		public static DataTable getAll()
		{
			return DBLayer.Select("select * from instructor");
		}
		//Select Instructor By Id
		public static DataTable getById(int id)
		{
			return DBLayer.Select("select * from instructor where ins_id =id ");
		}
		//Add New  Instructor 
		public static int add(Instructor Inst)
		{
			return DBLayer.DML($"insert into instructor values ({Inst.Id},'{Inst.Name}','{Inst.Degree}',{Inst.Salary},{Inst.Dept_Id})");
		}
		//Update Instructor by id
		public static int update(Instructor Inst)
		{
			return DBLayer.DML($"update instructor set ins_name='{Inst.Name}',ins_degree='{Inst.Degree}',salary={Inst.Salary},dept_id={Inst.Dept_Id} where ins_id={Inst.Id}");
		}
		//Delete Instructor by id
		public static int delete(int id)
		{
			return DBLayer.DML($"delete instructor where ins_id={id}");
		}
	}
}
