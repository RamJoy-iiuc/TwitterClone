using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10test
    {
        public void Run()
        {
            var tweet = new Tweet("This is my first tweet");
            tweet.Edit("This is my second tweet");
        }
    }
}
