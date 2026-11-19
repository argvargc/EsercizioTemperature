int[] temperaturaGiorno = new int[7];
int temperaturaMax = 0;
int temperaturaMin = 0;
int temperaturaMed = 0;

for (int i = 0; i < 7; i++)
{
    Console.Write($"Inserisci la temperatura per il giorno {i}: ");
    temperaturaGiorno[i] = Convert.ToInt16(Console.ReadLine());

    if (temperaturaMin == 0 && i == 0)
    {
        temperaturaMin = temperaturaGiorno[i];
    }
    if (temperaturaGiorno[i] > temperaturaMax)
    {
        temperaturaMax = temperaturaGiorno[i];
    }
    if (temperaturaGiorno[i] < temperaturaMin)
    {
        temperaturaMin = temperaturaGiorno[i];
    }
    temperaturaMed = temperaturaMed + temperaturaGiorno[i];
}

temperaturaMed = temperaturaMed / temperaturaGiorno.Length;
Console.WriteLine($"Temperatura massima: {temperaturaMax}");
Console.WriteLine($"Temperatura minima: {temperaturaMin}");
Console.WriteLine($"Temperatura media: {temperaturaMed}");
