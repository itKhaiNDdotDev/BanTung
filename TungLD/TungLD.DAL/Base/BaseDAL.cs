using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace TungLD.DAL.Base
{
    public class BaseDAL<T> : IBaseDAL<T>
    {
        public int Create(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            string query = "SELECT * FROM " + typeof(T).Name + "s";

            using (var connection = new SqlConnection(DatabaseInfo.ConnectionString))
            {
                connection.Open();
                using(var sqlCmd = new SqlCommand(query))
                {
                    using(var reader = sqlCmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                T item = default(T);
                                var props = typeof(T).GetProperties();
                                foreach(var prop in props)
                                {
                                    item.Get
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
