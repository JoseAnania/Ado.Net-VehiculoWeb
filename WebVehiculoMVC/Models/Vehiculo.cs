using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVehiculoMVC.Models
{
    public class Vehiculo
    {
        public int IdV { get; set; }
        public string NombreV { get; set; }
        public string ModeloV { get; set; }
        public int IdM { get; set; }

        public Vehiculo(int idV, string nombreV, string modeloV, int idM )
        {
            IdV = idV;
            NombreV = nombreV;
            ModeloV = modeloV;
            IdM = idM;
        }

        public Vehiculo() { }
    }
}