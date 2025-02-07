using System.ComponentModel.DataAnnotations;

namespace EduManage.Web.Models.Entities
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Enrollment_date { get; set; }
        public int Grade { get; set; }


    }
}