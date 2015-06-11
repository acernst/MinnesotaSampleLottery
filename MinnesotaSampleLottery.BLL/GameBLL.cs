using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinnesotaSampleLottery.Common;
using MinnesotaSampleLottery.DAL;

namespace MinnesotaSampleLottery
{
    public static class GameBLL
    {
        public static Game GetGame(int gameId)
        {
            return GameDAL.GetItem(gameId);
        }

        public static GameCollection GetCollection()
        {
            return GameDAL.GetCollection();
        }

        public static int Save(Game gameToSave)
        {
            int returnValue;

            returnValue = GameDAL.Save(gameToSave);

            return returnValue;
        }
    }
}
