// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Game game = new();

for (int i = 0; i < 8; i++)
{
    game.Roll(4);
}

