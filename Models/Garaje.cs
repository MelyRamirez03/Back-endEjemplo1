using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Models
{
    public class Garaje:List<Coche>
    {
        public Garaje()
        {
            this.Add(new Coche(1, "Tesla", "Roadster", "Domingo Garcia"));
            this.Add(new Coche(2, "Toyota", "Yaris", "Juan Antonio León"));
            this.Add(new Coche(3, "Honda", "Civic", "Juan Pablo Romero"));
            this.Add(new Coche(4, "Ferrari", "F40", "Roberto Cardiel"));
        }
    }
}