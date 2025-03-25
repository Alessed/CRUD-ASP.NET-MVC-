using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Producto
{
    public int IntProducto { get; set; }

    public double? DblCantidad { get; set; }

    public DateOnly? DatFechaRegistro { get; set; }

    public string? StrNombre { get; set; }

    public double? DblPrecio { get; set; }

    public string? StrClave { get; set; }
}
