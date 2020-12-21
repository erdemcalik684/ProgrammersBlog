using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Comment : EntityBase,IEntity
    {
        public string Text { get; set; }




        //bir yorum bir makaleye ait olmalı
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
