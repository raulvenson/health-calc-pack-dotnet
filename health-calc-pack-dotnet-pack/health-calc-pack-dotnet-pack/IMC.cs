using health_calc_pack_dotnet_pack.Interfaces;

namespace health_calc_pack_dotnet_pack
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            var Result = Math.Round(Height / (Weight * Weight), 2);
            return Math.Round(Height / (Weight*Weight), 2 );
        }

        //IMC                 CLASSIFICAÇÃO   OBESIDADE(GRAU)
        //MENOR QUE 18,5	    MAGREZA	            0
        //ENTRE 18,5 E 24,9	    NORMAL	            0
        //ENTRE 25,0 E 29,9	    SOBREPESO           I
        //ENTRE 30,0 E 39,9 	OBESIDADE           II
        //MAIOR QUE 40,0	    OBESIDADE GRAVE     III
        public string GetIMCCategory(double IMC)
        {
            if (IMC < 18.5)
                return IMCConstant.MAGREZA;
            if (IMC < 25)
                return IMCConstant.NORMAL;
            if (IMC < 30)
                return IMCConstant.SOBREPESO;
            if (IMC < 40)
                return IMCConstant.OBESIDADE;

            return IMCConstant.OBESIDADE_GRAVE;
        }

        public bool IsValidData(double Height, double Weight)
        {
            return (Height < 3.0 && Weight <= 300);
        }
    }
}