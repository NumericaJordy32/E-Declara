using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("Auditoria")]
public class Auditoria
{
    [Key]
    public int IdAuditoria { get; set; }
    public int? IdUsuario { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Accion { get; set; }
    public string? ValoresPrevios { get; set; }
    public string? ValorNuevo { get; set; }
    public string? Detalles { get; set; }

    [ForeignKey("IdUsuario")]
    public Usuario? Usuario { get; set; }
}