using AutoMapper;
using System;

namespace AutoMapperPractice.DifferentPropertyMapping
{
    class MappingDifferentProperty
    {
        static void Main()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>()
             .ForMember(destinationMember => destinationMember.FullName, act => act
                .MapFrom(sourceMember => sourceMember.Name))
             .ForMember(destinationMember => destinationMember.Depart, act => act
                .MapFrom(sourceMember => sourceMember.Department))
            );

            var employee = new Employee()
            {
                Id = 1,
                Name = "farhan ahmed",
                Position = "Software Engineer",
                Office = "Bangalore",
                Salary = 80000,
                Department = "IT"
            };

            var mapper = new Mapper(config);
            var employeeDto = mapper.Map<Employee, EmployeeDTO>(employee);

            Console.WriteLine("Id:{0}", employeeDto.Id);
            Console.WriteLine("Name:{0}", employeeDto.FullName);
            Console.WriteLine("Position:{0}", employeeDto.Position);
            Console.WriteLine("Office:{0}", employeeDto.Office);
            Console.WriteLine("Salary:{0}", employeeDto.Salary);
            Console.WriteLine("Department:{0}", employeeDto.Depart);
            Console.ReadLine();
        }
    }
}
