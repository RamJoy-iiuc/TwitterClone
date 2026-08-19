using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification:Notification
    {
        public Guid MentionByUserId { get; set; }

        public MentionNotification(Guid userId, Guid mentionByUserId, string message) : base(userId, message, "Mention notification")
        {
            MentionByUserId = mentionByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, MentionByUserId: {MentionByUserId}";
        }
        public override string GetMessage()
        {
            return $"User with ID {MentionByUserId} mentioned you";
        }
    }
}
