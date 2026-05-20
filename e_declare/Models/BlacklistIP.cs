using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("Blacklist_IPs")]
public class BlacklistIP
{
    [Key]
    public int IDBLACKLIST { get; set; }

    public string DIRECCIONIP { get; set; } = string.Empty;

    public string? MOTIVO { get; set; }
    public DateTime? FECHADEBLOQUEO { get; set; }

    public bool? ESPERMANENTE { get; set; }
}