using health_calc_pack_dotnet_pack;
using health_calc_pack_dotnet_pack.MacronutrientesStrategies;
using health_calc_pack_dotnet_pack.Models;

MacronutrientesContext strategy = new();

strategy.SetStrategy(new GanharMassaStrategy());
MacronutrientesModel result = strategy.ExecuteStrategy(70.55);

Console.WriteLine($"Para uma dieta de ganho de massa muscular, consuma: " +
    $"{result.Carboidratos}g de Carboidratos," +
    $"{result.Proteinas}g de Proteinas," +
    $"{result.Gorduras}g de Gorduras");

Console.ReadKey();

//var imc = new IMC();
//var result = imc.Calc(1.73, 72.0);
//var classificacao = imc.GetIMCCategory(24);

//Console.WriteLine($"Seu IMC é: {result} e o resultado é: {classificacao}");
