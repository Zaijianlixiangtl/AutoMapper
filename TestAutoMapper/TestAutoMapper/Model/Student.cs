using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAutoMapper.Model
{
	public class Student
	{
		public int Id { get; set; }

		public int Age { get; set; }
	}

	public class StudentDto
	{
		public int Id { get; set; }

		public int Age { get; set; }
	}
}
