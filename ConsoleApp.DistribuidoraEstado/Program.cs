//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53
//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal
//da distribuidora. 

using System.Globalization;

var listFaturamentos = new Dictionary<string, double>();
listFaturamentos.Add("SP", 67836.43);
listFaturamentos.Add("RJ", 36678.66);
listFaturamentos.Add("MG", 29229.88);
listFaturamentos.Add("ES", 27165.48);
listFaturamentos.Add("Outros", 19849.53);

double totalMensal = listFaturamentos.Select(s => s.Value).Sum();
Console.WriteLine($"Faturamento do mês: {totalMensal.ToString("C", new CultureInfo("pt-BR"))}");

foreach(var item in listFaturamentos)
{
    Console.WriteLine($"Estado: {item.Key}, Faturamento: {item.Value.ToString("C", new CultureInfo("pt-BR"))}, Percentual: {(item.Value/totalMensal)*100:F2}%");
}


