namespace AutoMapperPractice.ComplexMapping
{
    class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Salary { get; set; }
        public AddressDTO Address { get; set; }
    }
}
