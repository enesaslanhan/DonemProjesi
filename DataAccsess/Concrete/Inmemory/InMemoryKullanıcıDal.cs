using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.Inmemory
{
    public class InMemoryKullanıcıDal 
    {
        /*
        List<User> _kullanıcılar;
        public InMemoryKullanıcıDal()
        {
            _kullanıcılar = new List<User>
            {
                new User {id=1,isim="Enes",soyisim="Aslanhan",telNo="0536xxxxx96" },
                new User {id=2,isim="Ali",soyisim="Kaymaz",telNo="0545xxxxx83" },
                new User {id=3,isim="Selin",soyisim="Yanardağ",telNo="0531xxxxx77" }
            };
        }
        public void Add(User kullanıcı)
        {
            _kullanıcılar.Add(kullanıcı);
        }

        public void Delete(User kullanıcı)
        {

            User kullanıcıToDelete = _kullanıcılar.SingleOrDefault(k => k.id == kullanıcı.id);
            _kullanıcılar.Remove(kullanıcıToDelete);
            //SingleOrDefault = foreach yapmak gibi 
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _kullanıcılar;
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<KullanıcıDetailDto> GetKullanıcıDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(User kullanıcı)
        {
            User kullanıcıToUpdate= _kullanıcılar.SingleOrDefault(k => k.id == kullanıcı.id);
            kullanıcıToUpdate.isim = kullanıcı.isim;
            kullanıcıToUpdate.soyisim = kullanıcı.soyisim;
            kullanıcıToUpdate.telNo = kullanıcı.telNo;
        }
        */
    }

}
