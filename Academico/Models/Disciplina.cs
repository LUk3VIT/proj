using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace Academico.Models
{
    internal class tbldisciplinas
    {
        [PrimaryKey, AutoIncrement]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        }
}
