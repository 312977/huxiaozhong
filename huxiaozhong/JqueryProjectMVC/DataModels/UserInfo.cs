using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 用户详细信息
    /// </summary>
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }
        [StringLength(50)]
        /// <summary>
        /// 用户真名
        /// </summary>
        public string UserInfoRealName { get; set; }
        [Required]
        [StringLength(50)]
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserInfoNickName { get; set; }
        [Required]
        /// <summary>
        /// 用户生日
        /// </summary>
        public DateTime UserInfoBirthday { get; set; }
        [Required]
        [StringLength(10)]
        /// <summary>
        /// 用户性别
        /// </summary>
        public string UserInfoSex { get; set; }
        [Required]
        [StringLength(100)]
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserInfoEmail { get; set; }
        [Required]
        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime UserInfoRegisterTime { get; set; }
        /// <summary>
        /// 会员积分
        /// </summary>
        public int UserInfoPoints{get;set;}
        /// <summary>
        /// 会员头像
        /// </summary>
        public string UserInfoPhoto { get; set; }
    }
}