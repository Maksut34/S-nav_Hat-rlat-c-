using SınavEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavDAL
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
            Database.Connection.ConnectionString = "Server=Maksut-OZDEMIR\\SQLEXPRESS02;Database=Sınavlar;uid=sa;pwd=1;";
        }
        DbSet<Sınavlar> sınavlars { get; set; }
    }
}
