using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CadastroDeUsuarios.Data;
using System;
using System.Linq;

namespace CadastroDeUsuarios.Models;

public static class SeedData
{
  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var context = new CadastroDeUsuariosContext(
      serviceProvider.GetRequiredService<DbContextOptions<CadastroDeUsuariosContext>>()))
      {
        if(context.User.Any())
        {
          return;
        }
        context.User.AddRange(
          new User 
          {
            Name = "Jefferson",
            SurName = "Matheus",
            CreatedDate = DateTime.Parse("2023-2-12"),
          },new User 
          {
            Name = "Richard",
            SurName = "Santos",
            CreatedDate = DateTime.Parse("2023-1-12"),
          },new User 
          {
            Name = "Pinoquio",
            SurName = "Andrade",
            CreatedDate = DateTime.Parse("2023-4-12"),
          },new User 
          {
            Name = "Ricardo",
            SurName = "Henrique",
            CreatedDate = DateTime.Parse("2023-3-12"),
          }
        );
        context.SaveChanges();
      }
  }
}