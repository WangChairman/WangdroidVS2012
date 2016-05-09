using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.DalFactory
{
    public class DBSessionFactory
    {
        public static DBSession CreateDbSession()
        {
            DBSession DbSession = (DBSession)CallContext.GetData("dbSession");
            if (DbSession == null)
            {
                DbSession = new DalFactory.DBSession();
                CallContext.SetData("dbSession", DbSession);
            }
            return DbSession;
        }
    }
}
