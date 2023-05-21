
using health_calc_pack_dotnet_pack.Interfaces;
using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.Models;
using health_calc_pack_dotnet_pack.Enums;
using health_calc_pack_dotnet_pack.MacronutrientesStrategies;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacronutrientesTest
    {

        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerdaPeso, 216.0, 288.0, 216.0)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 288.0, 288.0, 144.0)]
        [InlineData(ObjetivoFisicoEnum.GanhoMassaMuscular, 288.0, 144.0, 72.0)]
        public void CalculaMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(
            ObjetivoFisicoEnum ObjetivoFisico, 
            double Carboidratos,
            double Proteinas,
            double Gorduras)
        {
            //Arrange
            IMacronutrientes macronutrientes = new Macronutrientes();
            double Weight = 72;
            MacronutrientesModel Expected = new MacronutrientesModel()
            {
                Carboidratos = Carboidratos,
                Proteinas = Proteinas,
                Gorduras = Gorduras
            };

            //Act
            var result = macronutrientes.CalcularMacronutrientes(ObjetivoFisico, Weight);

            //Asserts
            Assert.Equivalent(Expected, result);
        }


        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerdaPeso, 216.0, 288.0, 216.0)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 288.0, 288.0, 144.0)]
        [InlineData(ObjetivoFisicoEnum.GanhoMassaMuscular, 288.0, 144.0, 72.0)]
        public void CalculaMacronutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes_VersaoStrategy(
            ObjetivoFisicoEnum ObjetivoFisico,
            double Carboidratos,
            double Proteinas,
            double Gorduras)
        {
            //Arrange
            MacronutrientesContext strategy = new();

            double Weight = 72;

            switch (ObjetivoFisico)
            {
                case ObjetivoFisicoEnum.GanhoMassaMuscular:
                    strategy.SetStrategy(new GanharMassaStrategy());
                    break;
                case ObjetivoFisicoEnum.PerdaPeso:
                    strategy.SetStrategy(new PerderPesoStrategy());
                    break;
                case ObjetivoFisicoEnum.ManterPeso:
                    strategy.SetStrategy(new ManterPesoStrategy());
                    break;
                default:
                    break;
            }

            MacronutrientesModel Expected = new MacronutrientesModel()
            {
                Carboidratos = Carboidratos,
                Proteinas = Proteinas,
                Gorduras = Gorduras
            };

            //Act
            var result = strategy.ExecuteStrategy(Weight);

            //Asserts
            Assert.Equivalent(Expected, result);
        }
    }
}
