using AddrBook.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.DalFactory
{
    public partial class DBSession
    {
        //OAEntities Db = new OAEntities();
        public DbContext Db
        {
            get { return DbContextFactory.CreateDbContext(); }
        }

        /// <summary>
        /// 一个业务中有可能涉及到对多张表的操作，那么可以将操作的数据，传递到数据层中相应的方法，打上相应的标记，最后调用该方法，将数据一次性提交到数据库中，避免了多次链接数据库。
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }


    }
}
