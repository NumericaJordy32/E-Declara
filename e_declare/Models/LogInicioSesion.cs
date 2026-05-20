using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("Log_IniciosSesion")]
public class LogInicioSesion
{
    [Key]
    public int IdLog { get; set; }
    public int? IdUsuario { get; set; }
    public DateTime? FechaAcceso { get; set; }

    public string? DireccionIP { get; set; }

    public string? Navegador { get; set; }

    public bool? Exitoso { get; set; }

    public string? DetalleError { get; set; }

    [ForeignKey("IdUsuario")]
    public Usuario? Usuario { get; set; }
}