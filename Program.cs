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
}








using SadConsole.Configuration;

Settings.WindowTitle = "My SadConsole Game";

Builder configuration = new Builder()
    .SetScreenSize(90, 30)
    .OnStart(Startup)
    ;

Game.Create(configuration);
Game.Instance.Run();
Game.Instance.Dispose();



static void Startup(object? sender, GameHost host)
{
    ScreenObject container = new ScreenObject();
    Game.Instance.Screen = container;
    // First console
    Console console1 = new(60, 14);
    console1.Position = (3, 2);
    console1.Surface.DefaultBackground = Color.AnsiCyan;
    console1.Clear();
    console1.Print(1, 1, "Type on me!");
    console1.Cursor.Position = (1, 2);
    console1.Cursor.IsEnabled = true;
    console1.Cursor.IsVisible = true;
    console1.Cursor.MouseClickReposition = true;
    console1.IsFocused = true;


    ScreenSurface surfaceObject = new(5, 3);
    surfaceObject.Surface.FillWithRandomGarbage(surfaceObject.Font);
    surfaceObject.Position = console1.Surface.Area.Center - (surfaceObject.Surface.Area.Size / 2);
    surfaceObject.UseMouse = false;

    console1.Children.Add(surfaceObject);
    // Second console
    Console console2 = new Console(58, 12);
    console2.Position = new Point(19, 11);
    console2.Surface.DefaultBackground = Color.AnsiRed;
    console2.Clear();
    console2.Print(1, 1, "Johnny is a poopoo peepee:");
    console2.Cursor.Position = new Point(1, 2);
    console2.Cursor.IsEnabled = true;
    console2.Cursor.IsVisible = true;
    console2.FocusOnMouseClick = true;
    console2.MoveToFrontOnMouseClick = true;

    container.Children.Add(console2);
    container.Children.Add(console1);

    container.Children.MoveToBottom(console2);
}*/
using SadConsole.Configuration;
using SadConsoleGame;

Settings.WindowTitle = "My SadConsole Game";

Builder configuration = new Builder()
    .SetScreenSize(120, 38)
    .SetStartingScreen<RootScreen>()
    .IsStartingScreenFocused(true)
    ;

Game.Create(configuration);
Game.Instance.Run();
Game.Instance.Dispose();

