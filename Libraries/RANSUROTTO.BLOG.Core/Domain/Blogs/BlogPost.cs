using System;
using System.Collections.Generic;
using RANSUROTTO.BLOG.Core.Data;
using RANSUROTTO.BLOG.Core.Domain.Blogs.Enum;
using RANSUROTTO.BLOG.Core.Domain.Customers;
using RANSUROTTO.BLOG.Core.Domain.Localization;
using RANSUROTTO.BLOG.Core.Domain.Media;

namespace RANSUROTTO.BLOG.Core.Domain.Blogs
{
    /// <summary>
    /// 博客文章
    /// </summary>
    public class BlogPost : BaseEntity, ILocalizedEntity
    {

        private ICollection<BlogPostTag> _blogPostTags;
        private ICollection<Comment> _blogComments;
        private ICollection<BlogPostCategory> _blogCategories;

        /// <summary>
        /// 获取或设置作者ID
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// 获取或设置封面图片ID
        /// </summary>
        public int? CoverId { get; set; }

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 获取或设置正文内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 获取或设置概述
        /// </summary>
        public string BodyOverview { get; set; }

        /// <summary>
        /// 获取或设置格式ID
        /// </summary>
        public int FormatId { get; set; }

        /// <summary>
        /// 获取或设置是否允许评论标识
        /// </summary>
        public bool AllowComments { get; set; }

        /// <summary>
        /// 获取或设置展示开始的UTC时间
        /// </summary>
        public DateTime? AvailableStartDateUtc { get; set; }

        /// <summary>
        /// 获取或设置展示结束的UTC时间
        /// </summary>
        public DateTime? AvailableEndDateUtc { get; set; }

        /// <summary>
        /// 获取或设置 Meta Keywords
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// 获取或设置 Meta Description
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// 获取或设置 Meta Title
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// 获取或设置最后编辑结束的UTC时间
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// 获取或设置该文章是否已被主人删除
        /// </summary>
        public bool Deleted { get; set; }

        #region Navigation Properties

        /// <summary>
        /// 获取或设置博文格式
        /// </summary>
        public BlogPostFormat Format
        {
            get
            {
                return (BlogPostFormat)this.FormatId;
            }
            set { this.FormatId = (int)value; }
        }

        /// <summary>
        /// 获取或设置博文作者
        /// </summary>
        public virtual Customer Author { get; set; }

        /// <summary>
        /// 获取或设置封面
        /// </summary>
        public virtual Picture Cover { get; set; }

        /// <summary>
        /// 获取或设置对应的类目关联列表
        /// </summary>
        public virtual ICollection<BlogPostCategory> BlogCategories
        {
            get { return _blogCategories ?? (_blogCategories = new List<BlogPostCategory>()); }
            set { _blogCategories = value; }
        }

        /// <summary>
        /// 获取或设置关联标签列表
        /// </summary>
        public virtual ICollection<BlogPostTag> BlogPostTags
        {
            get { return _blogPostTags ?? (_blogPostTags = new List<BlogPostTag>()); }
            set { _blogPostTags = value; }
        }

        /// <summary>
        /// 获取或设置博文内评论列表
        /// </summary>
        public virtual ICollection<Comment> BlogComments
        {
            get { return _blogComments ?? (_blogComments = new List<Comment>()); }
            set { _blogComments = value; }
        }

        #endregion

    }

}
