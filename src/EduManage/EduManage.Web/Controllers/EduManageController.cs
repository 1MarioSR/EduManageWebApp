using EduManage.Web.Data;

namespace EduManage.Web.Controllers
{
    internal class EduManageController
    {
        private EduManageDbContext db;

        public EduManageController(EduManageDbContext db)
        {
            this.db = db;
        }
    }
}