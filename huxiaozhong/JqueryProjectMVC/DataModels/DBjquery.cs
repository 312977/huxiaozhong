using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace JqueryProjectMVC.DataModels
{
    public class DBjquery : DbContext
    {
        DbSet<Action> Actions { get; set; }
        DbSet<Controller> Actions { get; set; }
        DbSet<JqueryFunctionType> Actions { get; set; }
        DbSet<JqueryMethod> Actions { get; set; }
        DbSet<JqueryMethodExample> Actions { get; set; }
        DbSet<JqueryMethodTag> Actions { get; set; }
        DbSet<MemberShipGradingSystem> Actions { get; set; }
        DbSet<MethodComment> Actions { get; set; }
        DbSet<Role> Actions { get; set; }
        DbSet<RoleController> Actions { get; set; }
        DbSet<User> Actions { get; set; }
        DbSet<UserInfo> Actions { get; set; }
        DbSet<UserRole> Actions { get; set; }
        /// <summary>
        /// 初始化库表时候约束 POCO方式的 约束
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder b)
        {
            base.OnModelCreating(b);

            b.Entity<Action>().Property(c=>c.ActionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            b.Entity<Action>().Property(c=>c.ActionName).HasMaxLength(50).IsRequired();
        }
    }
}