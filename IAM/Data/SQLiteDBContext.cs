using Microsoft.EntityFrameworkCore;
using IAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAM.Data
{
    public class SQLiteDBContext : DbContext
    {

        // Antes de mais nada instalar os pacotes:
        // Install-Package Microsoft.EntityFrameworkCore.Sqlite
        // Install-Package Microsoft.EntityFrameworkCore.Tools

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sqlitedemo.db");

        public DbSet<Usuario> Usuario { get; set; }


    }
}
