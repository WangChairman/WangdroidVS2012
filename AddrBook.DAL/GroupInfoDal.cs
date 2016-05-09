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
    public partial class GroupInfoDal : BaseDal<GroupInfo>
    {
        public override Expression<Func<GroupInfo, int>> GetKey()
        {
            return u => u.GroupId;
        }

        public override Expression<Func<GroupInfo, bool>> GetByIdKey(int id)
        {
            return u => u.GroupId == id;
        }
    }
}
