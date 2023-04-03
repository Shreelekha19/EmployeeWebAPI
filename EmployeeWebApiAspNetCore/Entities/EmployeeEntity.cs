namespace EmployeeWebApiAspNetCore.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? CityName { get; set; }
        public DateTime YearOfJoining { get; set; }
    }
}
