using System;
// La clase alfajor no esta encapsulada porque se pueden cambiar los valores de los precios sin ningun criterio desde cualquier clase
// También debería ser la clase alfajor la que calcule su propio precio total, no la clase Kiosco
namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}