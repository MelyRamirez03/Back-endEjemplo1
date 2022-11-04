using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Models
{
    public class Coche
    {
        public int IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Propietario { get; set; }

        public Coche(int IdCoche, string Marca, string Modelo, string Propietario)
        {
            this.IdCoche = IdCoche;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Propietario = Propietario;
        }
    }
}