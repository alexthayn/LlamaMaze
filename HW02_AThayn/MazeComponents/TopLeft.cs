using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_AThayn.MazeComponents
{
    class TopLeft : MazeBox
    {
        public TopLeft()
        {
            _top = true;
            _left = true;
        }
    }

    class RightBottom : MazeBox
    {
        public RightBottom()
        {
            _right = true;
            _bottom = true;
        }
    }

    class BottomLeft : MazeBox
    {
        public BottomLeft()
        {
            _bottom = true;
            _left = true;
        }
    }

    class TopRight : MazeBox
    {
        public TopRight()
        {
            _top = true;
            _right = true;
        }
    }

    class TopRightLeft : MazeBox
    {
        public TopRightLeft()
        {
            _top = true;
            _right = true;
            _left = true;
        }
    }

    class RightBottomLeft : MazeBox
    {
        public RightBottomLeft()
        {
            _right = true;
            _bottom = true;
            _left = true;
        }
    }

    class TopBottomLeft : MazeBox
    {
        public TopBottomLeft()
        {
            _top = true;
            _bottom = true;
            _left = true;
        }
    }

    class TopRightBottom : MazeBox
    {
        public TopRightBottom()
        {
            _top = true;
            _right = true;
            _bottom = true;
        }
    }

    class TopRightLeftBottom : MazeBox
    {
        public TopRightLeftBottom()
        {
            _top = true;
            _right = true;
            _bottom = true;
            _left = true;
        }
    }
}
