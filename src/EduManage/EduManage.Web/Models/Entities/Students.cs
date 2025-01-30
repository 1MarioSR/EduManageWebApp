using System.ComponentModel.DataAnnotations;

namespace EduManage.Web.Models.Entities
{
    public class Students
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }

        public string dateofbirth { get; set; }

        public string gender { get; set; }
        public string email { get; set; }

        public string phonenumber { get; set; }

        public string profilepicture { get; set; }

        public string createdat { get; set; }
        public string uptdatedat { get; set; }



    }
}
