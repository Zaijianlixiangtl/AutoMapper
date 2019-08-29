using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TestAutoMapper.Model;

namespace TestAutoMapper.AuotMapperProfile
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, UserDto>()
				.ForMember(x=>x.Provice,y=>y.MapFrom(h=>h.Adress.Provice));
			CreateMap<Student, StudentDto>();
		}
	}
}
