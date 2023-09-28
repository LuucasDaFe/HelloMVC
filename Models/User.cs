using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Passaword { get; set; }
    }
}
