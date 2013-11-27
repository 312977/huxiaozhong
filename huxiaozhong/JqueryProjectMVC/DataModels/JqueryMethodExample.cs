using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// Jquery方法具体使用以及分类等信息
    /// </summary>
    public class JqueryMethodExample 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 方法样例ID
        /// </summary>
        public string MethodExampleId { get; set; }
        /// <summary>
        /// 推荐指数
        /// </summary>
        public int MethodExampleRecommendationIndex { get; set; }
        [Required]
        /// <summary>
        /// 方法例子
        /// </summary>
        public string MethodExample { get; set; }
        /// <summary>
        /// 用于例子的html代码(用于弹出另一个页面实现试一试功能)
        /// </summary>
        public string MethodExampleHtml { get; set; }
        /// <summary>
        /// 用于例子的jquery代码(用于弹出另一个页面实现试一试功能)
        /// </summary>
        public string MethodExampleJqueryCode { get; set; }
        /// <summary>
        /// 例子错误(用于用户自动上传例子自动审核后代码出错被人举报)
        /// </summary>
        public int MethodExampleError { get; set; }
        [Required]
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime MethodExampleCreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int MethodExampleCreator { get; set; }
    }
}