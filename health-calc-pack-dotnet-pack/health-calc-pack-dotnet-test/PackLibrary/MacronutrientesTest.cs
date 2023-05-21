
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.Models;
using health_calc_pack_dotnet_pack.Enums;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacronutrientesTest
    {

        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerdaPeso)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso)]
        [InlineData(ObjetivoFisicoEnum.GanhoMassaMuscular)]
        public void CalculaMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico)
        {
            //Arrange
            IMacronutrientes macronutrientes = new Macronutrientes();
            double Weight = 72;
            MacronutrientesModel Expected = new MacronutrientesModel();

            if(ObjetivoFisico == ObjetivoFisicoEnum.PerdaPeso)
            {
                Expected.Carboidratos = 216.0;
                Expected.Proteinas = 288.0;
                Expected.Gorduras = 216.0;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.ManterPeso)
            {
                Expected.Carboidratos = 288.0;
                Expected.Proteinas = 288.0;
                Expected.Gorduras = 144.0;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.GanhoMassaMuscular)
            {
                Expected.Carboidratos = 288.0;
                Expected.Proteinas = 144.0;
                Expected.Gorduras = 72.0;
            }


            //Act
            var result = macronutrientes.CalcularMacronutrientes(ObjetivoFisico, Weight);

            //Asserts
            Assert.Equivalent(Expected, result);
        }
    }
}
