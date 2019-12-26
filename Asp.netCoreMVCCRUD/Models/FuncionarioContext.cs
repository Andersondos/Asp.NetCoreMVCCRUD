using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext()
        {

        }

        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }

    }
}
