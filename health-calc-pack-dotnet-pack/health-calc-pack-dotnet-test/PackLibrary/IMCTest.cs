using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void CalculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 1.73;
            double Weight = 72;
            double ExpectedIMC = 24.06;

            //Act
            var result = imc.Calc(Weight,Height);

            //Asserts
            Assert.Equal(ExpectedIMC, result);
        }

        [Fact]
        public void ValidaDadosIMC_QuandoDadosValidos_EntaoRetornaVerdadeiro()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);
        }

        [Fact]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao()
        {
            //Arrange
            IIMC imc = new IMC();
            double ValorIMC = 24.06;
            string Expected = "NORMAL";

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);
        }

    }
}