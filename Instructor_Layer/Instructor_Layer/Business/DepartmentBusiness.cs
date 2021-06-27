using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Instructor_Layer.BusinessLayer
{
	class DepartmentBusiness
	{
		public static DataTable getDept()
		{
			return DBLayer.Select("select dept_id,dept_name from department");
		}
	}
}
