using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("ROLES")]
public class Role
{
    [Key]
    public int IDROL { get; set; }
    public string? DESCRIPCIONROL { get; set; }

    public bool? ESTADOROL { get; set; }

    public int? IDTIPOUSUARIO { get; set; }

    [ForeignKey("IDTIPOUSUARIO")]
    public TipoUsuario? TipoUsuario { get; set; }

    public ICollection<RolMenu> RolMenus { get; set; } = [];
}