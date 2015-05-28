using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnesotaSampleLottery
{
    public class Game
    {
        #region CONSTRUCTORS
        public Game() { }

        #endregion

        #region PROPERTIES

        public int GameId { get; set; }
        public string Name { get; set; }
        public string Multiplier { get; set; }
        public int NumbersDrawn { get; set; }
        public string Description { get; set; }

        #endregion

    }
}
