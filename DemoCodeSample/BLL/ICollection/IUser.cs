using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCodeSample.BLL.ICollection
{
    public interface IUser
    {
        List<DAL.User> Users();
        DAL.User Users(int Id);
        void Add(DAL.User user);
        void Update(DAL.User user);
        void Delete(int Id);
    }
}
