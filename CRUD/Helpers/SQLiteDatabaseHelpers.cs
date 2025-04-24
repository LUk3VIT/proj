
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SQLite;
using CRUD.Models;
using CRUD.Helpers;

namespace CRUD.Helpers
{
    public class SQLiteDatabaseHelpers
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelpers(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Periodo>().Wait();
        }

        public Task<int> Insert(Periodo p)
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<Periodo>> Update(Periodo p)
        {
            string sql = "UPDATE Periodo SET Nome=?, WHERE Codigo=?";
            return _conn.QueryAsync<Periodo>(sql, p.Nome, p.Codigo);
        }

        public Task<int> Delete(int p)
        {
            return _conn.Table<Periodo>().DeleteAsync(i => i.Codigo == p);

            /*
             string sql = "DELETE Estado WHERE Codigo=?";
            _conn.QueryAsync<Estado>(sql, p);
             */
        }

        public Task<List<Periodo>> GetAll()
        {
            return _conn.Table<Periodo>().ToListAsync();
        }

        public Task<List<Periodo>> Search(string p)
        {
            string sql = "SELECT * FROM Periodo WHERE Nome LIKE '%" + p + "%'";
            return _conn.QueryAsync<Periodo>(sql);
        }
    }
}
