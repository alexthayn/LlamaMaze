using HW02_AThayn.MazeComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_AThayn
{
    class Maze
    {
        MazeBox[][] _theMaze;

        public MazeBox getMazeBox(int x, int y)
        {
            return _theMaze[x][y];
        }

        public Maze()
        {
            _theMaze = new MazeBox[10][];
        }

        public void CreateAMaze()
        {
            _theMaze[0] = new MazeBox[] { new TopLeft(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopRight() };
            _theMaze[1] = new MazeBox[] { new RightLeft(), new TopLeft(), new TopBottom(), new Top(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopRight(), new RightLeft()};
            _theMaze[2] = new MazeBox[] { new RightLeft(), new RightLeft(), new TopLeft(), new Bottom(), new TopRightBottom(), new TopBottomLeft(), new TopBottom(), new TopRight(), new Left(), new Right() };
            _theMaze[3] = new MazeBox[] { new RightLeft(), new RightBottomLeft(), new RightLeft(), new TopLeft(), new TopBottom(), new TopBottom(), new TopRight(), new RightBottomLeft(), new RightLeft(), new RightBottomLeft()};
            _theMaze[4] = new MazeBox[] { new Right(), new TopRightLeft(), new Left(), new Right(), new TopLeft(), new TopRight(), new RightLeft(), new TopRightLeft(), new RightLeft(), new TopRightLeft()};
            _theMaze[5] = new MazeBox[] { new RightBottomLeft(), new RightLeft(), new RightBottomLeft(), new RightLeft(), new BottomLeft(), new RightBottom(), new Left(), new Right(), new RightBottomLeft(), new RightLeft()};
            _theMaze[6] = new MazeBox[] { new TopRightLeft(), new RightLeft(), new TopRightLeft(), new BottomLeft(), new TopBottom(), new TopBottom(), new RightBottom(), new RightLeft(), new TopRightLeft(), new RightLeft()};
            _theMaze[7] = new MazeBox[] { new Left(), new Right(), new BottomLeft(), new TopBottom(), new TopBottom(),  new Top(), new TopBottom(), new RightBottom(), new RightLeft(), new RightLeft()};
            _theMaze[8] = new MazeBox[] { new RightLeft(), new BottomLeft(), new TopBottom(), new TopBottom(), new TopBottom(), new Bottom(), new TopRightBottom(), new TopBottomLeft(), new RightBottom(), new RightLeft()};
            _theMaze[9] = new MazeBox[] { new BottomLeft(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new TopBottom(), new Top(), new RightBottom()};
        }                                      
    }   
}
