using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("TipoUsuario")]
public class TipoUsuario
{
    [Key]
    public int IdTipoUsuario { get; set; }

    // CORREGIDO: Se quitó el "?" porque en BD es No NULL
    public string NombreTipo { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    // CORREGIDO: Se agregó el "?" porque en BD es bit y permite NULL
    public bool? Estado { get; set; }

    public ICollection<Usuario> Usuarios { get; set; } = [];
    public ICollection<Role> Roles { get; set; } = [];
}