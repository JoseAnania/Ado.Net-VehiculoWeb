using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVehiculoMVC.Models
{
    public class VehiculoMarca
    {
        public Vehiculo V { get; set; }
        public List<Marca> M { get; set; }
    }
}