using System;
using RANSUROTTO.BLOG.Core.Domain.Localization;

namespace RANSUROTTO.BLOG.Core.Domain.Blog
{

    public class BlogPost
    {

        /// <summary>
        /// ��ȡ�����ö�Ӧ����ID
        /// </summary>
        public long LanguageId { get; set; }

        /// <summary>
        /// ��ȡ�����ñ���
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// ��ȡ�����ø���
        /// </summary>
        public string BodyOverview { get; set; }

        /// <summary>
        /// ��ȡ�����ñ�ǩ
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// ��ȡ�������Ƿ��������۱�ʶ
        /// </summary>
        public bool AllowComments { get; set; }

        /// <summary>
        /// ��ȡ������չʾ��ʼ��UTCʱ��
        /// </summary>
        public DateTime? StartDateUtc { get; set; }

        /// <summary>
        /// ��ȡ������չʾ������UTCʱ��
        /// </summary>
        public DateTime? EndDateUtc { get; set; }

        /// <summary>
        /// ��ȡ���������༭������UTCʱ��
        /// </summary>
        public DateTime LastEditorDateUtc { get; set; }

        #region Navigation Properties

        public virtual Language Language { get; set; }

        #endregion

    }

}