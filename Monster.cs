using SadConsole.Quick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadConsoleGame;

internal class Monster : GameObject
{
    public Monster(Point position, IScreenSurface hostingSurface)
    : base(new ColoredGlyph(Color.Red, Color.Black, 'M'), position, hostingSurface)
    {

    }
    public override bool Touched(GameObject source, Map map)
    {
        return base.Touched(source, map);
    }
}