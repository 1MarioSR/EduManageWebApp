using EduManage.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduManage.Web.Data
{
    public class EduManageDbContext : DbContext
    {
        public EduManageDbContext(DbContextOptions<EduManageDbContext> options): base(options)
        {
        }
         
        public DbSet<Students> students { get; set; }
    } 
    
}

