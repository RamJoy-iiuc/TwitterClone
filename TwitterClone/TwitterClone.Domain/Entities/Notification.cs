using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public abstract class Notification: BaseEntity
    {
        private Guid _userId;
        private string _message;
        private bool _isRead;
        private string _type;

        public Notification(Guid userId,string message, string notificationType) : base(Guid.NewGuid())
        {
            _userId = userId;
            _message = message;
            _type = notificationType;
            _isRead = false;
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public string Message
        {
            get { return _message; }
        }
        public bool IsRead
        {
            get { return _isRead; }
        }
        public string Type
        {
            get { return _type; }
        }
        public void MarkAsRead()
        {
            _isRead = true;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}" +
                $", UserId: {UserId}" +
                $", Type: {Type}" +
                $", Message: {Message}" +
                $", IsRead: {IsRead}";
        }

        public abstract string GetMessage();
        
    }

}
