using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Interview_Registration
    {
        [Required]
        public string Name { get; set; }
        
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public string Experience { get; set; }

        public string JobRole {get;set;}

        public string City { get; set; }

        
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum City
    {
        Chennai,
        Delhi,
        Kolkata,
        Bangalore,
        Mumbai,
        

    }
}
