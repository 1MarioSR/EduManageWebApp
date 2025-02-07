using System.ComponentModel.DataAnnotations;
namespace EduManage.Web.Models.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Credits { get; set; }
        public required string Teachername { get; set; }
        
    }
}
