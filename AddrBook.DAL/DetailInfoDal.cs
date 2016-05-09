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
    public partial class DetailInfoDal : BaseDal<DetailInfo>
    {
        public override Expression<Func<DetailInfo, int>> GetKey()
        {
            return u => u.ContactsId;
        }

        public override Expression<Func<DetailInfo, bool>> GetByIdKey(int id)
        {
            return u => u.ContactsId == id;
        }
    }
}
