using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet_pack
{
    public class MacronutrientesContext
    {
        private IMacronutrientesStrategy? strategy;

        public void SetStrategy(IMacronutrientesStrategy strategy) { this.strategy = strategy; }

        public MacronutrientesModel ExecuteStrategy(double Peso)
        {
            return strategy!.CalcularMacronutrientes(Peso);
        }
    }
}
