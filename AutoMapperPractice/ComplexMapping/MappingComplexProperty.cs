using AutoMapper;
using System;

namespace AutoMapperPractice.ComplexMapping
{
    class MappingComplexProperty
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
                Id = 1,
                Name = "farhan ahmed",
                Position = "Software Engineer",
                Office = "Bangalore",
                Salary = 80000,
                Address = address

            };

            var mapper = InitializeAutomapper();
            var employeeDto = mapper.Map<EmployeeDTO>(employee);

            Console.WriteLine("Name:" + employeeDto.Name + ", Position:" + employeeDto.Position + ", Office:" + employeeDto.Office + ", Salary:" + employeeDto.Salary);
            Console.WriteLine("City:" + employeeDto.Address.City + ", State:" + employeeDto.Address.State + ", Country:" + employeeDto.Address.Country);
            Console.ReadLine();
        }

        static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Address, AddressDTO>();
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
