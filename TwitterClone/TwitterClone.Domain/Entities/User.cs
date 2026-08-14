using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TwitterClone.Domain.Entities
{
    public class User: BaseEntity
    {
        private string _username;
        private string _email;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _bio;

        // CREATE ACCOUNT
        public User(
            string username,
            string email,
            string password,
            string firstName,
            string lastName):base(Guid.NewGuid())
        {
            _username = username;
            _email = email;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
            _bio = "";
        }

        public string Username
        {
            get { return _username; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string Bio
        {
            get { return _bio; }
        }

        // MANAGE PROFILE
        public void UpdateProfile(
            string firstName,
            string lastName,
            string bio)
        {
            _firstName = firstName;
            _lastName = lastName;
            _bio = bio;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, " +
                   $"Username: {Username}, " +
                   $"Email: {Email}, " +
                   $"FirstName: {FirstName}, " +
                   $"LastName: {LastName}, " +
                   $"Bio: {Bio}";
        }
    }
}
