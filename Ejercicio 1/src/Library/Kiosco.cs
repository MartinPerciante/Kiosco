using System;
// El kiosco cumple con el patron EXPERT pero no con el SRP porque tiene dos responsabilidades: la de vender alfajores y la de convertir el tipo de moneda
namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirDinero.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioAlfajor();
        }
    }
}