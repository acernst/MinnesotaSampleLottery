using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MinnesotaSampleLottery
{
    public class GameCollection : Collection<Game> { }

    public class DrawCollection : Collection<Draw> { }
    public class DrawDateCollection : Collection<DrawingDate> { }
    public class GameStateCollection : Collection<GameState> { }
    public class NumbersCollection : Collection<Numbers> { }
    public class NumberTypeCollection : Collection<NumberType> { }
    public class StateCollection : Collection<State> { }
}
