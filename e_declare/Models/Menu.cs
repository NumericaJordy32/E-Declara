using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("MENUS")]
public class Menu
{
    [Key]
    public int IDMENU { get; set; }
    public string? NOMBREMENU { get; set; }

    public bool? ESTADOMENU { get; set; }

    public string? RUTAMENU { get; set; }
    public string? ICONOMENU { get; set; }
    public int? IDMENUPADRE { get; set; }

    [ForeignKey("IDMENUPADRE")]
    public Menu? MenuPadre { get; set; }

    public ICollection<Menu> SubMenus { get; set; } = [];
    public ICollection<RolMenu> RolMenus { get; set; } = [];
}