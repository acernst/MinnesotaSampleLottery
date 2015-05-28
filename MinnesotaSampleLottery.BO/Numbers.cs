using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnesotaSampleLottery
{
    public class Numbers
    {
        #region CONSTRUCTORS
        public Numbers() { }
        #endregion

        #region PROPERTIES

        public int NumberDrawId { get; set; }
        public int DrawId { get; set; }
        public int NumberTypeId { get; set; }
        public int DrawNumber { get; set; }

        #endregion

    }
}
