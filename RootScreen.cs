namespace SadConsoleGame;

internal class RootScreen : ScreenObject
{
    private ScreenSurface _map;
    public RootScreen()
    {
        _map = new ScreenSurface(Game.Instance.ScreenCellsX, Game.Instance.ScreenCellsY - 5);
        _map.UseMouse = false;

        Children.Add(_map);
        private void FillBackground()
        {
            Color[] colors = new[] { Color.LightGreen, Color.Coral, Color.CornflowerBlue, Color.DarkGreen };
            float[] colorStops = new[] { 0f, 0.35f, 0.75f, 1f };

            Algorithms.GradientFill(_map.FontSize,
                                    _map.Surface.Area.Center,
                                    _map.Surface.Width / 3,
                                    45,
                                    _map.Surface.Area,
                                    new Gradient(colors, colorStops),
                                    (x, y, color) => _map.Surface[x, y].Background = color);
        }
    }
}
