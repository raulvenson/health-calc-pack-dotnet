
using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack.MacronutrientesStrategies
{
    public class GanharMassaStrategy : IMacronutrientesStrategy
    {
        public MacronutrientesModel CalcularMacronutrientes(double Peso)
        {
            return new MacronutrientesModel()
            {
                Carboidratos = 4.0 * Peso,
                Proteinas = 2.0 * Peso,
                Gorduras = 1.0 * Peso
            };
        }
    }
}
