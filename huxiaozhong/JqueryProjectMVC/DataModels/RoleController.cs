using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 角色管辖的控制器Action是否允许通过
    /// </summary>
    public class RoleController
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 角色控制id
        /// </summary>
        public int RoleControllerActionId { get; set; }
        [Required]
        /// <summary>
        /// 控制器或的id
        /// </summary>
        public int ControllerId { get; set; }
        [Required]
        /// <summary>
        /// Action的id
        /// </summary>
        public int ActionId { get; set; }
        [Required]
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        [Required]
        /// <summary>
        /// 是否允许访问
        /// </summary>
        public bool ControllerActionIsAllowed { get; set; }
    }
}