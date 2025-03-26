using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Producto
{
    public int intProducto { get; set; }

    public double? dblCantidad { get; set; }

    public DateOnly? datFechaRegistro { get; set; }

    public string? strNombre { get; set; }

    public double? dblPrecio { get; set; }

    public string? strClave { get; set; }
}
