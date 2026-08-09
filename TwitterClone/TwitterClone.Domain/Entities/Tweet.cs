using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    //public class Tweet
    //{
    //        public Guid Id { get; set; }

    //        public Guid UserId { get; set; }

    //        public string Content { get; set; }

    //        public DateTime CreatedAt { get; set; }

    //}

    public class Tweet
    {
        private Guid _id;
        private Guid _userId;
        private string _content;
        private DateTime _createdAt;
        private DateTime? _updatedAt;

        // POST / CREATE
        public Tweet(Guid userId, string content)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            SetContent(content);
            _createdAt = DateTime.Now;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime? UpdatedAt
        {
            get { return _updatedAt; }
        }

        // EDIT
        public void Edit(string content)
        {
            SetContent(content);
            _updatedAt = DateTime.Now;
        }

        private void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Tweet cannot be empty.");

            if (content.Length > 280)
                throw new ArgumentException("Tweet cannot exceed 280 characters.");

            _content = content;
        }
    }
}
