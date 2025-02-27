
// Obtém o caminho do JSON no diretório do executável
using ConsoleApp.Distribuidora.Entity;
using Newtonsoft.Json;
using System.Globalization;

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DadosFaturamento", "dados.json");

if (!File.Exists(filePath))
{
    Console.WriteLine("Arquivo JSON não encontrado!");
    return;
}

string json = File.ReadAllText(filePath);

List<FaturamentoData> faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoData>>(json);

// Filtrar apenas os dias com faturamento (excluir valores 0.0)
var diasComFaturamento = faturamentoMensal.Where(d => d.Valor > 0).ToList();

// Encontrar o menor e o maior faturamento
double menorFaturamento = diasComFaturamento.Min(d => d.Valor);
double maiorFaturamento = diasComFaturamento.Max(d => d.Valor);

// Calcular a média mensal considerando apenas os dias com faturamento
double mediaMensal = diasComFaturamento.Average(d => d.Valor);

// Contar quantos dias tiveram faturamento superior à média
int diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > mediaMensal);

// Exibir os resultados
Console.WriteLine($"Menor faturamento do mês: {menorFaturamento.ToString("C", new CultureInfo("pt-BR"))}");
Console.WriteLine($"Maior faturamento do mês: {maiorFaturamento.ToString("C", new CultureInfo("pt-BR"))}");
Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");