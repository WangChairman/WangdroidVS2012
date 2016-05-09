using AddrBook.DAL;
using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.DAL
{
    public partial class ContactsInfoDal:BaseDal<ContactsInfo>
    {
        public override Expression<Func<ContactsInfo, int>> GetKey()
        {
            return u => u.ContactsId;
        }

        public override Expression<Func<ContactsInfo, bool>> GetByIdKey(int id)
        {
            return u => u.ContactsId == id;
        }
    }
}
