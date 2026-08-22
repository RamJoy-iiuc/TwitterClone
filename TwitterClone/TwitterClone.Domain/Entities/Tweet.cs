using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Tweet:BaseEntity,ILikeable
    {
        private Guid _userId;
        private string _content;

        // POST / CREATE
        public Tweet(Guid userId, string content):base(Guid.NewGuid())
        {
            _userId = userId;
            SetContent(content);
        }

        public Tweet(string content) : base(Guid.NewGuid())
        {
            SetContent(content);
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public string Content
        {
            get { return _content; }
        }

        // EDIT
        //callers don't directly modify Content
        //Domain-Driven Design (DDD) concept
        public void Edit(string content)
        {
            SetContent(content);
        }

        //ensures that an invalid tweet cannot be created or edited.
        private void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Tweet cannot be empty.");

            if (content.Length > 280)
                throw new ArgumentException("Tweet cannot exceed 280 characters.");

            _content = content;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }

        public bool CanbeLiked()
        {
            return true;
        }
    }
}
