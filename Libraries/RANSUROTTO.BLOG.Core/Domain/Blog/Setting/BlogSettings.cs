using RANSUROTTO.BLOG.Core.Configuration;

namespace RANSUROTTO.BLOG.Core.Domain.Blog.Setting
{

    /// <summary>
    /// 博客设置
    /// </summary>
    public class BlogSettings : ISettings
    {

        /// <summary>
        /// 获取或设置是否允许未注册用户(游客)进行评论
        /// </summary>
        public bool AllowNotRegisteredUserToLeaveComments { get; set; }

        /// <summary>
        /// 获取或设置博文可有最多标签个数
        /// </summary>
        public int MaxNumberOfTags { get; set; }

        /// <summary>
        /// 获取或设置博客评论是否需要经过审批
        /// </summary>
        public bool BlogCommentsMustBeApproved { get; set; }

    }

}
