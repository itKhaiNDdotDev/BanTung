using System;
using System.Collections.Generic;
using System.Text;

namespace TungLD.DAL.Base
{
    public interface IBaseDAL<T>
    {
        public List<T> GetAll();
        public int Create(T item);
    }
}
