using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 用户角色id
        /// </summary>
        public int UserRoleId { get; set; }
        [Required]
        /// <summary>
        /// 用户id
        /// </summary>
        public int RoleUserId { get; set; }
        [Required]
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 一个用户有多个角色
        /// </summary>
        public Role Roles { get; set; }
        /// <summary>
        /// 一个角色有多个用户
        /// </summary>
        public ICollection<User> User{get;set;}
    }
}