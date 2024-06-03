using System;
using System.Collections.Generic;

namespace ABM_PRODUCTO.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public int? Precio { get; set; }

    public DateTime? FechaVencimiento { get; set; }
}
