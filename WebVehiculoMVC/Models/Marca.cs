using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVehiculoMVC.Models
{
    public class Marca
    {
        public int IdM { get; set; }
        public string NombreM { get; set; }

        public Marca(int idM, string nombreM)
        {
            IdM = idM;
            NombreM = nombreM;
        }

        public Marca() { }
    }
}