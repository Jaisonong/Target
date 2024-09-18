using System.Text.Json;

string faturamentoJson = @"
        [
            { ""dia"": 1, ""faturamento"": 22174.1664 },
            { ""dia"": 2, ""faturamento"": 24537.6698 },
            { ""dia"": 3, ""faturamento"": 26139.6134 },
            { ""dia"": 4, ""faturamento"": 0.0 },
            { ""dia"": 5, ""faturamento"": 0.0 },
            { ""dia"": 6, ""faturamento"": 26742.6612 },
            { ""dia"": 7, ""faturamento"": 0.0 },
            { ""dia"": 8, ""faturamento"": 42889.2258 },
            { ""dia"": 9, ""faturamento"": 46251.174 },
            { ""dia"": 10, ""faturamento"": 11191.4722 }
        ]";


using JsonDocument doc = JsonDocument.Parse(faturamentoJson);
var faturamentoMensal = doc.RootElement.EnumerateArray();

var faturamentosValidos = faturamentoMensal
    .Select(dia => dia.GetProperty("faturamento").GetDouble())
    .Where(f => f > 0)
    .ToList();

double menorFaturamento = faturamentosValidos.Min();
double maiorFaturamento = faturamentosValidos.Max();
double mediaFaturamento = faturamentosValidos.Average();
int diasAcimaDaMedia = faturamentosValidos.Count(f => f > mediaFaturamento);

Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
