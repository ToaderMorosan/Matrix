using AutoMapper;
using Matrix.Helpers;

namespace Matrix.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Entities.Employee, Models.EmployeeDto>();
            CreateMap<Models.EmployeeForCreationDto, Entities.Employee>();
        }
    }
}
