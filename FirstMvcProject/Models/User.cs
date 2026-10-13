using System.ComponentModel.DataAnnotations;
namespace FirstMvcProject.Models

{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; } = null!;
        public String Email { get; set; } = null!;
        public String Password { get; set; } = null!;


    }
}
