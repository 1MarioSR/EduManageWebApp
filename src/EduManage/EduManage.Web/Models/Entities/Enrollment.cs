using System.ComponentModel.DataAnnotations;

namespace EduManage.Web.Models.Entities
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Lastname { get; set; }
        public required string Gender { get; set; }

    }
}