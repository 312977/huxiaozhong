using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 方法例子页面用户评论
    /// </summary>
    public class MethodComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 方法评论id
        /// </summary>
        public int MethodCommentId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
        [Required]
        /// <summary>
        /// 评论内容
        /// </summary>
        public string MethodCommentContent { get; set; }
        [Required]
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime MethodCommentTime { get; set; }
        /// <summary>
        /// 方法评论推荐指数
        /// </summary>
        public int MethodCommentRecommendationIndex { get; set; }
    }
}