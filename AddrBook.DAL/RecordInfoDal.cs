using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.DAL
{
    public partial class RecordInfoDal:BaseDal<RecordInfo>
    {
        public override Expression<Func<RecordInfo, int>> GetKey()
        {
            return u => u.RecordId;
        }

        public override Expression<Func<RecordInfo, bool>> GetByIdKey(int id)
        {
            return u => u.RecordId == id;
        }
    }
}
