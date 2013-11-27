using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// mvc代码中的action方法
    /// </summary>
    public class Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// Action的id
        /// </summary>
        public int ActionId { get; set; }
        [StringLength(100)]
        [Required]
        /// <summary>
        /// Action的名称
        /// </summary>
        public string ActionName { get; set; }
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
        public Controller ControllerId { get; set; }

    }
}