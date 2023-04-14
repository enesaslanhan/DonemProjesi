using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.Inmemory;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            KullanıcıTest();
        }

        private static void KullanıcıTest()
        {
            UserManager kullanıcıManager = new UserManager(new EfUserDal());
            var result = kullanıcıManager.GetKullanıcıDetails();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.firstName + " " + user.age);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
