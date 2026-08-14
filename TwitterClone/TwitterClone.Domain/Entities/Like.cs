using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;

        public Like(Guid userId, Guid tweetId) : base(Guid.NewGuid())
        {
            _userId = userId;
            _tweetId = tweetId;
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}";
        }


    }
}
