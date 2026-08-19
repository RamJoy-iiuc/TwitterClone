using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public Guid CommentByUserId { get; set; }

        public CommentNotification(Guid userId,Guid commentByUserId, string message) : base(userId, message, "Comment")
        {
            CommentByUserId = commentByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, " +
                   $"CommentByUserId: {CommentByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommentByUserId} Comment your post";
        }
    }
}
