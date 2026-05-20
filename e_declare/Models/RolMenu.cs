using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("ROL_MENU")]
public class RolMenu
{
    [Key, Column(Order = 0)]
    public int IDROL { get; set; }

    [Key, Column(Order = 1)]
    public int IDMENU { get; set; }

    [ForeignKey("IDROL")]
    public Role? Role { get; set; }

    [ForeignKey("IDMENU")]
    public Menu? Menu { get; set; }
}