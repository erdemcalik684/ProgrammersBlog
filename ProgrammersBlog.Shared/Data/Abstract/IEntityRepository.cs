using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        // Birtane makale getir,bir tane kullanıcı getir.
        // Idsi 10 olan makaleyi getir. var makale = repository.GetAsync(m=>m.Id==10);
        //Bunu predicate ile yaptık.
        //İkinci param expressionda ise, örneğin bir makaleyi getirdik fakat, o makaleyi yazan kullanıcıyıda getirmek istiyorsak include expression yazmalıyız.
        //var makale = repository.GetAsync(m=>m.Id==25,m=>m.Comments);
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);


        //Tüm Kategorileri getirmek istersek böyle yaparız.
        //Idsi 1 olan makaleye ait tüm yorumları getirmek istiyoruz.
        //repository.GetAllAsync(y=>y.ArticleId==1);
        //var makale = repository.GetAllAsync(m=>m.Id==25,m=>m.Comments); 
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);



        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);


        // böyle bir kullanıcı var mı ? , böyle bir makale var mı ?
        Task<bool> AnyAsync(Expression<Func<T,bool>> predicate);

        // kaçtane makale var kaç tane yorum var.
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    
    }
}
