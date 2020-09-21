using AutoMapper;
using System;

namespace AutoMapperPractice.SamePropertyMapping
{
    class MappingSameProperty
    {
        static void Main()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());

            var employee = new Employee()
            {
                Id = 1,
                Name = "farhan ahmed",
                Position = "Software Engineer",
                Office = "Bangalore",
                Salary = 80000
            };

            var mapper = new Mapper(config);
            var employeeDto = mapper.Map<EmployeeDTO>(employee);

            Console.WriteLine("Id:{0}", employeeDto.Id);
            Console.WriteLine("Name:{0}", employeeDto.Name);
            Console.WriteLine("Position:{0}", employeeDto.Position);
            Console.WriteLine("Office:{0}", employeeDto.Office);
            Console.WriteLine("Salary:{0}", employeeDto.Salary);
        }
    }
}
