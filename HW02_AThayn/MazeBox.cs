using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_AThayn
{
    abstract class MazeBox
    {
        protected bool _top = false;
        protected bool _right = false;
        protected bool _bottom = false;
        protected bool _left = false;

        public bool Top { get { return _top; } }
        public bool Right { get { return _right; }}
        public bool Bottom { get { return _bottom; }}
        public bool Left { get { return _left; } }
    }
}
