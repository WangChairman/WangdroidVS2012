using AddrBook.DAL;
using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.BLL
{
    public partial class RecordInfoBll : BaseBll<RecordInfo>
    {
        public override BaseDal<RecordInfo> GetDal()
        {
            return new RecordInfoDal();
        }
    }
}
