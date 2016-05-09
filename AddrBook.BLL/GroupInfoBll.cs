using AddrBook.DAL;
using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.BLL
{
    public partial class GroupInfoBll : BaseBll<GroupInfo>
    {
        public override BaseDal<GroupInfo> GetDal()
        {
            return new GroupInfoDal();
        }
    }
}
