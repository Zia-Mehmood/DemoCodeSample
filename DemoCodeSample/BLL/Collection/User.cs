using DemoCodeSample.BLL.ICollection;
using DemoCodeSample.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCodeSample.BLL.Collection
{
    public class User: IUser
    {
        private readonly FinanceServicesContext _context;
        public User(FinanceServicesContext context)
        {
            _context = context;
        }
        public List<DAL.User> Users()
        {
            return _context.User.ToList();
        }
        public DAL.User Users(int Id)
        {
            return _context.User.Where(x=>x.Id==Id).SingleOrDefault();
        }
        public void Add(DAL.User user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(DAL.User user)
        {
            try
            {
                DAL.User myUser = _context.User.Where(x => x.Id == user.Id).SingleOrDefault();
                myUser.FirstName = user.FirstName;
                myUser.LastName = user.LastName;
                myUser.Address = user.Address;
                myUser.Email = user.Email;
                _context.Update(myUser);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Delete(int Id)
        {
            try
            {
                DAL.User user = _context.User.Where(x => x.Id == Id).SingleOrDefault();
                
                _context.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
