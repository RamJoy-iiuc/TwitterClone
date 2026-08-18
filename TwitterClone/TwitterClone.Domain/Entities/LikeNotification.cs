using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification: Notification
    {
        public Guid LikeByUserId { get; private set; }

        public LikeNotification(Guid userId, Guid likeByUserId, string message) 
            : base(userId, message,"Like")
        {
            LikeByUserId = likeByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";
        }
    }
}
