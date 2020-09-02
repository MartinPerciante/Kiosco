using System;
// La clase alfajor no esta encapsulada porque se pueden cambiar los valores de los precios sin ningun criterio desde cualquier clase
// También debería ser la clase alfajor la que calcule su propio precio total, no la clase Kiosco
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
