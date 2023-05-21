using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.Models;

namespace health_calc_pack_dotnet_pack.Interfaces
{
    public interface IMacronutrientesStrategy
    {
        MacronutrientesModel CalcularMacronutrientes(double Peso);
    
    }
}
