using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnesotaSampleLottery
{
    public class GameState
    {
        #region CONSTRUCTORS
        public GameState() { }
        #endregion

        #region PROPERTIES

        public int GameStateId { get; set; }
        public int GameId { get; set; }
        public int StateId { get; set; }

        #endregion

    }
}
