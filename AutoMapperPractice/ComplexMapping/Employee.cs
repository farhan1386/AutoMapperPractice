﻿namespace AutoMapperPractice.ComplexMapping
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }
    }
}
