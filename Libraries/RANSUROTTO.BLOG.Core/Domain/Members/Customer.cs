using System;
using RANSUROTTO.BLOG.Core.Data;

namespace RANSUROTTO.BLOG.Core.Domain.Members
{

    public class Customer : BaseEntity
    {

        /// <summary>
        /// ��ȡ�������û���/��¼��
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// ��ȡ�����õ�������
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// ��ȡ�����õ��������Ƿ���Ҫ�ٴ���֤
        /// </summary>
        public bool EmailToRevalidate { get; set; }

        /// <summary>
        /// ��ȡ�����ø��û����������Ե�½ʧ�ܴ��� (�������)
        /// </summary>
        public int FailedLoginAttempts { get; set; }

        /// <summary>
        /// ��ȡ�����ø��û���ָ��UTCʱ��֮ǰ�ܾ���½
        /// </summary>
        public DateTime? CannotLoginUntilDateUtc { get; set; }

        /// <summary>
        /// ��ȡ�����ø��û��Ƿ�Ϊ����״̬
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// ��ȡ������������/����ʱ��IP��ַ
        /// </summary>
        public string LastIpAddress { get; set; }

        /// <summary>
        /// ��ȡ������������/����ʱ��UTCʱ��
        /// </summary>
        public DateTime LastActivityDateUtc { get; set; }

        /// <summary>
        /// ��ȡ����������½ʱ��UTCʱ��
        /// </summary>
        public DateTime? LastLoginDateUtc { get; set; }

    }

}