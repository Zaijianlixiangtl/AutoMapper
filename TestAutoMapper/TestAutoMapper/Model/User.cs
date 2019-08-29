using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAutoMapper.Model
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Date { get; set; }

		public Adress Adress { get; set; }
	}

	public class UserDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Date { get; set; }

		public string Provice { get; set; }
	}

	public class Adress
	{
		public string Provice { get; set; }
	}
}
