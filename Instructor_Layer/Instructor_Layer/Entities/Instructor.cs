using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructor_Layer.Entities
{
	class Instructor
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Degree { get; set; }

		public decimal Salary { get; set; }
		public int Dept_Id { get; set; }

	}
}
