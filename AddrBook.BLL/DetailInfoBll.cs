using AddrBook.DAL;
using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.BLL
{
    public partial class DetailInfoBll:BaseBll<DetailInfo>
    {
        public override BaseDal<DetailInfo> GetDal()
        {
            return new DetailInfoDal();
        }
    }
}
