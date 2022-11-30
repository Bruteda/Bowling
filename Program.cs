// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Game game = new();


    for (int i = 0; i < 30; i++)
    {

        //bool _continue = game.Roll(5);
        if (!game.Roll(10)) break; 
        
    }


Console.WriteLine(game.Score());
