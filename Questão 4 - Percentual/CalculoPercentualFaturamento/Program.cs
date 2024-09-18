double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double total = sp + rj + mg + es + outros;

Console.WriteLine("Percentual de representação por estado:");
Console.WriteLine($"SP: {(sp / total) * 100:F2}%");
Console.WriteLine($"RJ: {(rj / total) * 100:F2}%");
Console.WriteLine($"MG: {(mg / total) * 100:F2}%");
Console.WriteLine($"ES: {(es / total) * 100:F2}%");
Console.WriteLine($"Outros: {(outros / total) * 100:F2}%");