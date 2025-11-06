using System;
using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Range(0, 9_999_999)]
    public decimal Precio { get; set; }

    [Range(0, 100_000)]
    public int Stock { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaRegistro { get; set; } = DateTime.Today;
}
