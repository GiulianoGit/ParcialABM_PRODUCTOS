using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ABM_PRODUCTO.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "El campo Tipo es obligatorio")]
    public string? Tipo { get; set; }

    [Required(ErrorMessage = "El campo Precio es obligatorio")]
    public int? Precio { get; set; }

    [Required(ErrorMessage = "El campo Fecha de Vencimiento es obligatorio")]
    public DateTime? FechaVencimiento { get; set; }
}
