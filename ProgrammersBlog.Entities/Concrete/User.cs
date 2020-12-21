using ProgrammersBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.Concrete
{
    public class User :EntityBase,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }

        public string Picture { get; set; }
        public string Description { get; set; }


        //bir kullanıcı bir role sahip olmalı.
        public int RoleId { get; set; }
        public Role Role { get; set; }


        //bir kullanıcının birden fazla makalesi olabilir.
        public ICollection<Article> Articles { get; set; }
    }
}