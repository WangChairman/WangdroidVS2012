using AddrBook.DAL;
using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.BLL
{
    public partial class ContactsInfoBll:BaseBll<ContactsInfo>
    {
        public override BaseDal<ContactsInfo> GetDal()
        {
            return new ContactsInfoDal();
        }
    }
}
