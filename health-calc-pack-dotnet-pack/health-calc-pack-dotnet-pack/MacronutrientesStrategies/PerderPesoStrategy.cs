
using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack.MacronutrientesStrategies
{
    public class PerderPesoStrategy : IMacronutrientesStrategy
    {
        public MacronutrientesModel CalcularMacronutrientes(double Peso)
        {
            return new MacronutrientesModel()
            {
                Carboidratos = 3.0 * Peso,
                Proteinas = 4.0 * Peso,
                Gorduras = 3.0 * Peso
            };
        }
    }
}
