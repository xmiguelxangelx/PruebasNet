using System;
using System.ComponentModel.DataAnnotations;

public class Proveedor
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string RazonSocial { get; set; } = string.Empty;

    [EmailAddress, StringLength(120)]
    public string? Email { get; set; }

    [Phone, StringLength(20)]
    public string? Telefono { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaRegistro { get; set; } = DateTime.Today;
}
