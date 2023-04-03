using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApiAspNetCore.Dtos
{
    public class EmployeeCreateDto
    {
        [Required]
        public string? FirstName { get; set; }
        public string? CityName { get; set; }
        public DateTime YearOfJoining { get; set; }
    }
}
