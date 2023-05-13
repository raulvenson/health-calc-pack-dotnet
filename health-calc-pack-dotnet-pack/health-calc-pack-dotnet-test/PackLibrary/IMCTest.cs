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
        public void ValidaDadosIMC_QuandoDadosInvalidos_EntaoRetornaFalso()
        {
            //Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.False(result);
        }

        [Theory]
        [InlineData(17, IMCConstant.MAGREZA)]
        [InlineData(24, IMCConstant.NORMAL)]
        [InlineData(26, IMCConstant.SOBREPESO)]
        [InlineData(30.55, IMCConstant.OBESIDADE)]
        [InlineData(42, IMCConstant.OBESIDADE_GRAVE)]
        public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double ValorIMC, string Resultado)
        {
            //Arrange
            IIMC imc = new IMC();
            
            

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Resultado, result);
        }

    }
}