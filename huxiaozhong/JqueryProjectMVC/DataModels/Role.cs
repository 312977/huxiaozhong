using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 角色名
        /// </summary>
        public string RoleName { get; set; }
        [Required]
        /// <summary>
        /// 角色描述
        /// </summary>
        public string RoleDescription { get; set; }
    }
}