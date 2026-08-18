using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification:Notification
    {
        public SystemNotification(Guid userId,
            string message) : base(userId, message, "System")
        {

        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}";
        }
        public override string GetMessage()
        {
            return $"{Message}";
        }
    }
}
