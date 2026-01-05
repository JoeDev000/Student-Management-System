using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.Entities
{
    public enum Department
    {
        [Display(Name = "Computer Science - علوم الحاسب")]
        ComputerScience = 1,

        [Display(Name = "Software Engineering - هندسة البرمجيات")]
        SoftwareEngineering = 2,

        [Display(Name = "Artificial Intelligence - الذكاء الاصطناعي")]
        ArtificialIntelligence = 3,

        [Display(Name = "Data Science - علوم البيانات")]
        DataScience = 4,

        [Display(Name = "Cybersecurity - الامن السبراني")]
        Cybersecurity = 5
    }

    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 100 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [StringLength(150, ErrorMessage = "Email cannot exceed 150 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Phone number must be in valid format (e.g., +1234567890)")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Phone number must be between 10 and 20 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public Department Department { get; set; }
    }
}