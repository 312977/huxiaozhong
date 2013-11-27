using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 用户登录信息
    /// </summary>
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 用户登录名
        /// </summary>
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassWord { get; set; }
        [Required]
        /// <summary>
        /// 用户最后一次登录时间
        /// </summary>
        public DateTime UserLastLoginTime { get; set; }
        public UserInfo UserInfos { get; set; }
        /// <summary>
        /// 一个用户有多个角色
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }
}