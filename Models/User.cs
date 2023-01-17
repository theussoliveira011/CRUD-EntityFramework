using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroDeUsuarios.Models;

public class User
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? SurName { get; set; }
  [Display(Name = "Created Date")]
  [DataType(DataType.Date)]
  public DateTime CreatedDate { get; set; }
}