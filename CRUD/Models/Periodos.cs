using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;


namespace CRUD.Models
{
    public class Periodo
    {
        [PrimaryKey, AutoIncrement]
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
