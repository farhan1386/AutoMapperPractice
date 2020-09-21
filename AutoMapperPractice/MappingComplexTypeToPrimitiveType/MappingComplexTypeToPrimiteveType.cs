using AutoMapper;
using System;

namespace AutoMapperPractice.MappingComplexTypeToPrimitiveType
{
    class MappingComplexTypeToPrimiteveType
    {
        static void Main()
        {
            var address = new Address()
            {
                Id = 1,
                City = "Bangalore",
                State = "Karnataka",
                Country = "India"
            };

            var employee = new Employee()
            {
                Name = "farhan Ahmed",
                Position = "Software Engineer",
                Office = "Bangalore",
                Salary = 80000,
                Address = address
            };

            var mapper = InitializeAutomapper();
            var employeeDto = mapper.Map<EmployeeDTO>(employee);

            Console.WriteLine("Employee Name:{0}", employeeDto.Name);
            Console.WriteLine("Employee Name:{0}", employeeDto.Position);
            Console.WriteLine("Employee Name:{0}", employeeDto.Office);
            Console.WriteLine("Employee Name:{0}", employeeDto.Salary);
            Console.WriteLine("Employee Name:{0}", employeeDto.City);
            Console.WriteLine("Employee Name:{0}", employeeDto.State);
            Console.WriteLine("Employee Name:{0}", employeeDto.Country);
            Console.ReadLine();
        }

        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cgf =>
            {
                cgf.CreateMap<Employee, EmployeeDTO>()
                .ForMember(destinationMember => destinationMember.City, act => act.MapFrom(sourceMember => sourceMember.Address.City))
                .ForMember(destinationMember => destinationMember.State, act => act.MapFrom(sourceMember => sourceMember.Address.State))
                .ForMember(destinationMember => destinationMember.Country, act => act.MapFrom(sourceMember => sourceMember.Address.Country));
            });
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
