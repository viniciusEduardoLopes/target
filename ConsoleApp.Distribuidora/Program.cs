
// Obtém o caminho do JSON no diretório do executável
using ConsoleApp.Distribuidora.Entity;
using Newtonsoft.Json;

string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DadosFaturamento", "dados.json");

if (!File.Exists(filePath))
{
    Console.WriteLine("Arquivo JSON não encontrado!");
    return;
}

// Lê o conteúdo do JSON
string json = File.ReadAllText(filePath);

// Desserializa os dados para uma lista de objetos
List<FaturamentoData> faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoData>>(json);

Console.WriteLine("Arquivo JSON carregado com sucesso!");