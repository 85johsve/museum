internal class Program
{
    private static void Main(string[] args)
    {
        Entrance();
    }
    public static void Entrance()
    {   
        Console.Clear();
        Console.WriteLine("Välkommen till Museets Entré. Var vill du gå?");
        Console.WriteLine("[X] Utställningshall 1");
        Console.WriteLine("[Y] Utställningshall 2");
        Console.WriteLine("[C] Café");
        Console.WriteLine("[T] titta på Salt-skulpturer och Cigarrer");
        Console.WriteLine("[Esc] Lämna Museet");

        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.X)
        {
            ExhibitionHall1();
        }
        else if(key == ConsoleKey.Y)
        {
            ExhibitionHall2();
        }
        else if(key == ConsoleKey.C)
        {
            Cafe();
        }
        else if(key == ConsoleKey.T)
        {
            Console.Clear();
            Console.WriteLine("Oj det här var väldigt fina skulpturer och cigarrer!");
            Console.WriteLine("Tryck på valfri tangent för att återgå.");
            Console.ReadKey();
            Entrance();
        }
        else if(key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Du måste välja en av dom angivna valen!");
            Console.ReadKey();
            Entrance();
        }
    }

    public static void ExhibitionHall1()
    {
        Console.Clear();
        Console.WriteLine("Du befinner dig nu i Utställningshall 1!");
        Console.WriteLine("Var vill du gå?");
        Console.WriteLine("[C] Café");
        Console.WriteLine("[E] Entrén");
        Console.WriteLine("[T] titta på Saltvatten som dunstar");

        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.C)
        {
            Cafe();
        }
        else if (key == ConsoleKey.E)
        {
            Entrance();
        }
        else if (key == ConsoleKey.T)
        {
            Console.WriteLine("Saltvattnet som dunstar är förtrollande");
            Console.WriteLine("Tryck på valfri tangent för att återgå.");
            Console.ReadKey();
            ExhibitionHall1();
        }
        else
        {
            Console.WriteLine("Du måste välja en av dom angivna valen!");
            Console.ReadKey();
            ExhibitionHall1();
        }
    }

    public static void ExhibitionHall2()
    {
        Console.Clear();
        Console.WriteLine("Du befinner dig nu i Utställningshall 2!");
        Console.WriteLine("Var vill du gå nu då?");
        Console.WriteLine("[E] Entrén");
        Console.WriteLine("[T] Titta på Pipor");

        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.C)
        {
            Cafe();
        }
        else if (key == ConsoleKey.E)
        {
            Entrance();
        }
        else if (key == ConsoleKey.T)
        {
            Console.WriteLine("Piporna ser precis ut som riktiga pipor!");
            Console.WriteLine("Tryck på valfri tangent för att återgå.");
            Console.ReadKey();
            ExhibitionHall2();
        }

        else
        {
            Console.WriteLine("Du måste välja en av dom angivna valen!");
            Console.ReadKey();
            ExhibitionHall2();
        }
    }

    public static void Cafe()
    {
        Console.Clear();
        Console.WriteLine("Du befinner dig nu i Cafeet!");
        Console.WriteLine("Var vill du gå?");
        Console.WriteLine("[X] Utställningshall 1");
        Console.WriteLine("[E] Entrén");
        Console.WriteLine("[G] Giftshop");
        Console.WriteLine("[T] titta på Vad som finns att köpa");

        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.X)
        {
            ExhibitionHall1();
        }
        else if (key == ConsoleKey.E)
        {
            Entrance();
        }
        else if (key == ConsoleKey.G)
        {
            giftShop();
        }
        else if (key == ConsoleKey.T)
        {
            Console.WriteLine("Det finns faktiskt salt att köpa! pioprna är slut.");
            Console.WriteLine("Tryck på valfri tangent för att återgå.");
            Console.ReadKey();
            Cafe();
        }
        else
        {
            Console.WriteLine("Du måste välja en av dom angivna valen!");
            Console.ReadKey();
            ExhibitionHall1();
        }
    }

    public static void giftShop()
    {
        Console.Clear();
        Console.WriteLine("Välkommen till Giftshopen. En gallerdörr stängs bakom dig. Det var en fälla.");
        Console.WriteLine("Tryck på valfri tangent för att avsluta lidandet.");
        Console.ReadKey();
        Environment.Exit(0);
        
    }
    
}