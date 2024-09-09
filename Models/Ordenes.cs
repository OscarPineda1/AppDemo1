using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDemo1.Models
{
    public class Ordenes
    {
        public string? Instrumento {get; set;}
        public decimal? Precio {get; set;}
        public string? TipoPrecio {get; set;}
        public int? Cantidad{get; set;}

        public decimal Costo {get;}
        public decimal Tax {get;}
        public decimal Total {get; }

        public Ordenes(String instrumento, Decimal precio, String tipoPrecio, int cantidad){
            Instrumento = instrumento;
            Precio = precio;
            TipoPrecio = tipoPrecio;
            Cantidad = cantidad;
            Costo = (decimal)(Precio * Cantidad);
            Tax = Costo*0.18m;
            Total = Costo + Tax;
        }
    }   
}