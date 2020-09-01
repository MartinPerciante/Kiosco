using System;
// El kiosco no cumple con el patron EXPERT porque la clase alfajor es la que debería de calcular su precio total 
// No se cumple con el patron SRP porque la clase Kiosco tiene dos responsabilidades: la de vender alfajores y la de convertir el tipo de moneda
namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}