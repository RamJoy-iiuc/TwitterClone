using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        private Guid _followerId;
        private Guid _followingId;

        public Follow(Guid followerId, Guid followingId) : base(Guid.NewGuid())
        {
            _followerId = followerId;
            _followingId = followingId;
        }

        public Guid FollowerId
        {
            get { return _followingId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, FollowerId: {FollowerId}, FollowingId: {FollowingId}";
        }

    }
}
