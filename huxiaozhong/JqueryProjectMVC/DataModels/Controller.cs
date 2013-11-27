using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 所有控制器
    /// </summary>
    public class Controller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// Controller的id
        /// </summary>
        public int ControllerId { get; set; }
        [StringLength(100)]
        [Required]
        /// <summary>
        /// Controller的名称
        /// </summary>
        public string ControllerName { get; set; }
        [Required]
        /// <summary>
        /// 是否允许没有角色访问
        /// </summary>
        public bool IsAllowedNoneRoles { get; set; }
        [Required]
        /// <summary>
        /// 是否允许所有角色访问
        /// </summary>
        public bool IsAllowedAllRoles { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}