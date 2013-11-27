using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// Jquery方法
    /// </summary>
    public class JqueryMethod 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        ///方法 ID
        /// </summary>
        public int MethodId { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 名称
        /// </summary>
        public string MethodName { get; set; }
        [Required]
        [StringLength(1000)]
        /// <summary>
        /// 提示信息
        /// </summary>
        public string MethodPromptInfo { get; set; }
        [Required]
        /// <summary>
        /// 方法功能描述
        /// </summary>
        public string MethodFunctionDescription;
        /// <summary>
        /// 排序值
        /// </summary>
        public int MethodSort { get; set; }
        public virtual ICollection<JqueryMethodExample> JqueryMethodExamples { get; set; }
        public virtual ICollection<JqueryMethodTag> JqueryMethodTags { get; set; }
        public virtual ICollection<MethodComment> MethodComments { get; set; }

    }
}