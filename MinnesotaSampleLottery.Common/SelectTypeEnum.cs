using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnesotaSampleLottery.Common
{
    public enum SelectTypeEnum
    {
        /// <summary>
        /// Defaults to none
        /// </summary>
        None = 0,
        /// <summary>
        /// Gets a single item from DB
        /// </summary>
        GetItem = 10,
        /// <summary>
        /// Gets a collection from DB
        /// </summary>
        GetCollection = 20
    }
}
