using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime CreationDate { get; set; }
        // Add any additional properties needed for your application, such as SubForum, Upvotes, etc.
    }
}
