using System.ComponentModel.DataAnnotations;

namespace EduManage.Web.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Lastname { get; set; }
        public required string Gender { get; set; }
        public required string Email { get; set; }
        public required bool IsActive { get; set; }

    }
}
