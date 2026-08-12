using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _message;
        private bool _isRead;
        private DateTime _createdAt;

        public Notification(Guid userId, string message)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _message = message;
            _isRead = false;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
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

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public void MarkAsRead()
        {
            _isRead = true;
        }
    }

}
