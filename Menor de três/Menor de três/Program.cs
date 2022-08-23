using System.Globalization;

int primeiro, segundo, terceiro, menor;

Console.Write("Primeiro valor: ");
primeiro = int.Parse(Console.ReadLine());
Console.Write("Segundo valor: ");
segundo = int.Parse(Console.ReadLine());
Console.Write("Terceiro valor: ");
terceiro = int.Parse(Console.ReadLine());

if (primeiro < segundo && primeiro < terceiro) {
    menor = primeiro;
}
else if (segundo < terceiro) {
    menor = segundo;
}
else {
    menor = terceiro;
}

Console.WriteLine("MENOR = "+ menor);