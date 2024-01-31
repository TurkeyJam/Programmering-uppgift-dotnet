/*using SadConsole.Configuration;

Settings.WindowTitle = "My SadConsole Game";

Game.Create(90, 30, Startup);
Game.Instance.Run();
Game.Instance.Dispose();

static void Startup(object? sender, GameHost host)
{
    Game.Instance.StartingConsole.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, Mirror.None);
    Game.Instance.StartingConsole.Print(4, 4, "Hello from SadConsole");
    Game.Instance.StartingConsole.DrawBox(new Rectangle(3, 3, 23, 3), ShapeParameters.CreateBorder(new ColoredGlyph(Color.Violet, Color.Black, 176)));
    Game.Instance.StartingConsole.DrawBox(new Rectangle(3, 3, 23, 3), ShapeParameters.CreateStyledBox(ICellSurface.ConnectedLineThin, new ColoredGlyph(Color.Violet, Color.Black)));
    Game.Instance.StartingConsole.DrawCircle(new Rectangle(5, 8, 16, 8), ShapeParameters.CreateFilled(new ColoredGlyph(Color.Violet, Color.Black, 176), new ColoredGlyph(Color.White, Color.Black)));
    Game.Instance.StartingConsole.DrawLine(new Point(60, 5), new Point(66, 20), '$', Color.AnsiBlue, Color.AnsiBlueBright, Mirror.None);
    // X, Y, Color
    Game.Instance.StartingConsole.SetForeground(15, 4, Color.DarkGreen);
    // X, Y, Color
    Game.Instance.StartingConsole.SetBackground(18, 4, Color.DarkCyan);
    // X, Y, Glyph index or character
    Game.Instance.StartingConsole.SetGlyph(4, 4, '@'); // use '@' or 1, they're the same index glyph
}*/
using SadConsole.Configuration;

Settings.WindowTitle = "My SadConsole Game";

Builder configuration = new Builder()
    .SetScreenSize(90, 30)
    .UseDefaultConsole()
    .OnStart(Startup)
    ;

Game.Create(configuration);
Game.Instance.Run();
Game.Instance.Dispose();

static void Startup(object? sender, GameHost host)
{
    if (Game.Instance.StartingConsole is null)
        throw new NullReferenceException("You should never have this error if you used the UseDefaultConsole startup code.");

    Console startingConsole = Game.Instance.StartingConsole;
}