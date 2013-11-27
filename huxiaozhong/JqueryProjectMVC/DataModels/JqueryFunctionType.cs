using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// Jquery功能分类
    /// </summary>
    public class JqueryFunctionType : DbContext
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 功能分类ID
        /// </summary>
        public int FunctionTypeId { get; set; }
        [StringLength(100)]
        [Required]
        /// <summary>
        /// 名称
        /// </summary>
        public string FunctionTypeName { get; set; }
        [StringLength(1000)]
        [Required]
        /// <summary>
        /// 提示信息
        /// </summary>
        public string FunctionTypePromptInfo { get; set; }
        [Required]
        /// <summary>
        /// 排序值
        /// </summary>
        public int FunctionTypeSort { get; set; }
        /// <summary>
        /// JqueryMethod集合
        /// </summary>
        public virtual ICollection<JqueryMethod> JqueryMethod { get; set; }
    }
}