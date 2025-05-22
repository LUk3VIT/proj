using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Academico.Models;
using Academico.Helpers;


namespace Academico.Helpers
{
    public class SQLiteDatabaseHelpers
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelpers(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<tbldisciplinas>().Wait();
            _conn.CreateTableAsync<tblperiodos>().Wait();
        }

        public Task<int> InsertPeriodos(tblperiodos p)
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<tblperiodos>> UpdatePeriodos(tblperiodos p)
        {
            string sql = "UPDATE tblperiodos SET Nome=?, Sigla=? WHERE Codigo=?";
            return _conn.QueryAsync<tblperiodos>(sql, p.Nome, p.Sigla, p.Codigo);
        }

        public Task<int> DeletePeriodos(int p)
        {
            return _conn.Table<tblperiodos>().DeleteAsync(i => i.Codigo == p);

            /*
             string sql = "DELETE Estado WHERE Codigo=?";
            _conn.QueryAsync<Estado>(sql, p);
             */
        }

        public Task<List<tblperiodos>> GetAllPeriodos()
        {
            return _conn.Table<tblperiodos>().ToListAsync();
        }

        public Task<List<tblperiodos>> SearchPeriodos(string p)
        {
            string sql = "SELECT * FROM tblperiodos WHERE Nome LIKE '%" + p + "%'";
            return _conn.QueryAsync<tblperiodos>(sql);
        }
    }
}
