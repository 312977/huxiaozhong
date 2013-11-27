using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JqueryProjectMVC.DataModels
{
    /// <summary>
    /// 会员等级制度
    /// </summary>
    public class MemberShipGradingSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 等级名称
        /// </summary>
        public string GradingSystemName{get;set;}
        /// <summary>
        /// 等级要求积分(大于等于)
        /// </summary>
        public int GradingSystemPoints{get;set;}
        /// <summary>
        /// 等级图片
        /// </summary>
        public string GradingSystemPicture{get;set;}

    }
}