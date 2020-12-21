using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Article : EntityBase,IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }


        //Bir makale bir kategoriye ait olabilir ve ona ulaşsın.
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Bir makaleyi bir kişi yazmış olsun.
        public int UserId { get; set; }
        public User User { get; set; }

        //bir makalede birden fazla yorum olabilir.
        public ICollection<Comment> Comments { get; set; }

    }
}
