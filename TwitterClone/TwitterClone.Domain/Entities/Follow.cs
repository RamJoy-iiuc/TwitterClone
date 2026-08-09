using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _createdAt;

        public Follow(Guid followerId, Guid followingId)
        {
            _id = Guid.NewGuid();
            _followerId = followerId;
            _followingId = followingId;
            _createdAt = DateTime.Now;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
