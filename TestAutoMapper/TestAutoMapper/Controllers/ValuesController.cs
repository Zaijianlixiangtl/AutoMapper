using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestAutoMapper.Model;

namespace TestAutoMapper.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly IMapper mapper;

		public ValuesController(IMapper mapper)
		{
			this.mapper = mapper;
		}
		// GET api/values
		[HttpGet]
		public void Get()
		{
			var user = new User() { Id = 2,Name = "jason",Adress = new Adress() { Provice = "北京市"} };
			var userDto = mapper.Map<UserDto>(user);
			var student = new Student() { Id = 3 ,Age = 3};
			var studentDto = mapper.Map<StudentDto>(student);
		}
	}
}
