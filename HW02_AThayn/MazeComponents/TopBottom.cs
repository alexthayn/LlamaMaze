using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_AThayn.MazeComponents
{
    class TopBottom : MazeBox
    {
        public TopBottom()
        {
            _top = true;
            _bottom = true;
        }
    }

    class RightLeft : MazeBox
    {
        public RightLeft()
        {
            _right = true;
            _left = true;
        }
    }
}
