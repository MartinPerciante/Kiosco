using System;
// La clase alfajor no esta encapsulada porque se pueden cambiar los valores de los precios sin ningun criterio desde cualquier clase
namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioAlfajor()
        {
            return precioMasa+precioDulce;
        }
        private Double precioDulce;
        public Double PrecioDulce 
        {
            get {return precioDulce;}
            set
            {
                if (value > 0)
                {
                    precioDulce=value;
                }
            }
        }
        private Double precioMasa;
        public Double PrecioMasa 
        {
            get {return precioMasa;}
            set
            {
                if (value > 0)
                {
                    precioMasa=value;
                }
            }
        }
    }
}