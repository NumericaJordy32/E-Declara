using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_declare.Models;

[Table("Usuarios")]
public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? NombreEmpresa { get; set; }
    public string? Email { get; set; }
    public string? DireccionEmpresa { get; set; }
    public string? PasswordHash { get; set; }
    public int? IdTipoUsuario { get; set; }
    public int? IdTipoIdentificacion { get; set; }

    // Cambiado a nullable porque en BD permite NULL
    public int? IntentosFallidos { get; set; }

    // Cambiados a bool? porque en BD son bit y permiten NULL
    public bool? CuentaBloqueada { get; set; }
    public DateTime? FechaDesbloqueo { get; set; }

    // varbinary(max) en SQL se mapea a byte[] en C#
    public byte[]? FirmaElectronica { get; set; }

    public string? AvatarUrl { get; set; }
    public string? TokenRecuperacion { get; set; }
    public DateTime? FechaExpiracionToken { get; set; }

    public bool? MFA_Habilitado { get; set; }
    public string? MFA_SecretKey { get; set; }
    public string? CodigoSMS_Temp { get; set; }
    public DateTime? FechaCreacion { get; set; }
    public DateTime? UltimoAcceso { get; set; }

    public bool? Estado { get; set; }

    public bool? ClaveTemporal { get; set; }

    public string? Celular { get; set; }
    public string? Identificacion { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public int? IdJefe { get; set; }

    public bool? estadoAsociado { get; set; }
    public int SaldoDocumentos { get; set; }

    public DateTime? FechaUltimaRecargaDocumentos { get; set; }
    public string? HistorialComprasDocumentosJson { get; set; }

    // Navegación
    [ForeignKey("IdTipoUsuario")]
    public TipoUsuario? TipoUsuario { get; set; }

    [ForeignKey("IdTipoIdentificacion")]
    public TipoIdentificacion? TipoIdentificacion { get; set; }
}