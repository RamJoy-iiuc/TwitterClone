using System.Xml.Linq;

namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _comment;

        public Retweet(Guid userId, Guid tweetId, string comment)
            : base(Guid.NewGuid())
        {
            _userId = userId;
            _tweetId = tweetId;
            _comment = comment;
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        //Keep it if your application supports quote retweets
        //, where a user retweets someone else's tweet and adds their own text.
        //Original Tweet:
        //"Today is a beautiful day!"

        //Quote Retweet:
        //"Today is a beautiful day!"
        //"Absolutely
        public string Comment
        {
            get { return _comment; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, TweetId: {TweetId}, Comment: {Comment}";
        }
    }
}
