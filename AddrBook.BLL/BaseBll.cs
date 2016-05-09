﻿using AddrBook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.BLL
{
    public abstract partial class BaseBll<T>
        where T : class
    {
        private BaseDal<T> dal;
        public abstract BaseDal<T> GetDal();

        public BaseBll()
        {
            dal = GetDal();
        }

        public IQueryable<T> GetList(int pageSize, int pageIndex)
        {
            return dal.GetList(pageSize, pageIndex);
        }

        public T GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Add(T t)
        {
            return dal.Add(t) > 0;
        }

        public bool Edit(T t)
        {
            return dal.Edit(t) > 0;
        }

        public bool Remove(int id)
        {
            return dal.Remove(id) > 0;
        }

        public int GetCount()
        {
            return dal.GetCount();
        }
    }
}
