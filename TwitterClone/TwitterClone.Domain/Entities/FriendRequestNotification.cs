using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification: Notification
    {
        public Guid RequestedByUserId { get; set; }
        public FriendRequestNotification(Guid userId, Guid requestedByUserId, string message) : base(userId, message, "FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }
        public override string GetMessage()
        {
            return $"User with ID {RequestedByUserId} send you a Friend Request";
        }
    }

}
