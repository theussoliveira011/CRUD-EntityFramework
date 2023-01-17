using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroDeUsuarios.Models;

namespace CadastroDeUsuarios.Data
{
    public class CadastroDeUsuariosContext : DbContext
    {
        public CadastroDeUsuariosContext (DbContextOptions<CadastroDeUsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroDeUsuarios.Models.User> User { get; set; }
    }
}
