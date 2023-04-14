using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ProjeContext>, IUserDal
    {
        
        public List<KullanıcıDetailDto> GetKullanıcıDetails()
        {
            using (ProjeContext context = new ProjeContext())
            {
                var result = from u in context.User
                             join a in context.table
                             on u.userId equals a.userId
                             select new KullanıcıDetailDto {userId=u.userId,age=a.age,anketId=a.anketId,firstName=u.firstName,lastName=u.lastName,size=a.size,weight=a.weight};
                return result.ToList();
            }
            
        }
        
    }
}
