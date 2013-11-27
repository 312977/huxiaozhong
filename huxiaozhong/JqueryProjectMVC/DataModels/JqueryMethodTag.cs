using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// jquery方法标签
    /// </summary>
    public class JqueryMethodTag 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 标签ID
        /// </summary>
        public int MethodTagId { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 标签名称
        /// </summary>
        public string MethodTagName { get; set; }
        [Required]
        [StringLength(1000)]
        /// <summary>
        /// 标签提示信息
        /// </summary>
        public string MethodTagPromptInfo { get; set; }

    }
}