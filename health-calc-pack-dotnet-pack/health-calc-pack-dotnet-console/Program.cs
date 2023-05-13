using health_calc_pack_dotnet_pack;

var imc = new IMC();
var result = imc.Calc(1.73, 72.0);
var classificacao = imc.GetIMCCategory(24);

Console.WriteLine($"Seu IMC é: {result} e o resultado é: {classificacao}");
