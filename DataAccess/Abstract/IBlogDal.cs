using BlogApp.Models;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IBlogDal :  IEntityRepository<Blog>
    {
    }
}
