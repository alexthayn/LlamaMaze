using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW02_AThayn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Maze Maze;
        private bool isGameOver = false;

        public MainWindow()
        {
            InitializeComponent();
            DrawMaze();
            KeyUp += new KeyEventHandler(Window_OnKeyUp);
        }

        private void MoveRight_Click(object sender, RoutedEventArgs e)
        {
            //Get location
            Point spriteLocation = GetLocation();

            //Find Grid location
            Point gridLocation = GetGridLocation(spriteLocation);

            //Check if character is able to move right
            if (gridLocation.X + 1 > 9 || gridLocation.Y > 9)
                return;
            if (Maze.getMazeBox((int)gridLocation.Y, (int)gridLocation.X + 1).Left == true)
                return;
            if (spriteLocation.X + 50 > 700)
                return;

            //Move Right
            Canvas.SetLeft(Sprite, spriteLocation.X + 50);
        }

        private void MoveLeft_Click(object sender, RoutedEventArgs e)
        {
            //Get location
            Point spriteLocation = GetLocation();

            //Find Grid location
            Point gridLocation = GetGridLocation(spriteLocation);

            //Check if character is able to move left
            if (gridLocation.X - 1 < 0 || gridLocation.Y > 9)
                return;
            if (Maze.getMazeBox((int)gridLocation.Y, (int)gridLocation.X - 1).Right == true)
                return;
            if (spriteLocation.X - 50 < 200)
                return;

            //Move left
            Canvas.SetLeft(Sprite, spriteLocation.X - 50);
        }

        private void MoveUp_Click(object sender, RoutedEventArgs e)
        {
            //Get location
            Point spriteLocation = GetLocation();

            //Find Grid location
            Point gridLocation = GetGridLocation(spriteLocation);

            //Check if character is able to move up
            if (gridLocation.Y - 1 < 0 || gridLocation.X < 0)
                return;
            if (Maze.getMazeBox((int)gridLocation.Y - 1, (int)gridLocation.X).Bottom == true)
                return;
            if (spriteLocation.Y - 50 < 50)
                return;

            //Move left
            Canvas.SetTop(Sprite, spriteLocation.Y - 50);
        }

        private void MoveDown_Click(object sender, RoutedEventArgs e)
        {
            //Get location
            Point spriteLocation = GetLocation();

            //Find Grid location
            Point gridLocation = GetGridLocation(spriteLocation);

            //Check if at exit
            if (gridLocation.X == 8 && gridLocation.Y + 1 == 10)
            {
                Canvas.SetTop(Sprite, spriteLocation.Y + 50);
                YouWin();
                return;
            }

            //Check if character is able to move down
            if (gridLocation.Y + 1 > 9 || gridLocation.X < 0)
                return;
            if (Maze.getMazeBox((int)gridLocation.Y + 1, (int)gridLocation.X).Top == true)
                return;
            if (spriteLocation.Y + 50 > 500)
                return;

            
            //Move left
            Canvas.SetTop(Sprite, spriteLocation.Y + 50);
        }

        private Point GetLocation()
        {
            Point location = new Point(); 
            location.X = (int) Canvas.GetLeft(Sprite);
            location.Y = (int)Canvas.GetTop(Sprite);

            return location;
        }

        private Point GetGridLocation(Point location)
        {
            return new Point((location.X - 250) / 50, (location.Y - 50) / 50);
        }

        private void DrawMaze()
        {
            Maze = new Maze();
            Maze.CreateAMaze();

            bool top;
            bool left;
            bool bottom;
            bool right;
            String mazeSides;


            for (int i=0; i < 10; i++)
            {
                for(int j = 0; j<10;j++)
                {
                    top = Maze.getMazeBox(j,i).Top;
                    right = Maze.getMazeBox(j,i).Right;
                    bottom = Maze.getMazeBox(j,i).Bottom;
                    left = Maze.getMazeBox(j,i).Left;

                    mazeSides = null;
                    if (top) mazeSides += "T";
                    if (right) mazeSides += "R";
                    if (bottom) mazeSides += "B";
                    if (left) mazeSides += "L";
                    String uri = "pack://application:,,,/Images/" + mazeSides + ".png";

                    Rectangle mazePiece = new Rectangle();
                    mazePiece.Height = 56;
                    mazePiece.Width = 56;

                    mazePiece.Fill = new ImageBrush
                    {                        
                        ImageSource = new BitmapImage(new Uri(uri ))
                    };
                    Canvas.SetTop(mazePiece, j * 50 + 50);
                    Canvas.SetLeft(mazePiece, i * 50 + 250);
                    MazeCanvas.Children.Add(mazePiece);
                }
            }
        }

        private void YouWin()
        {
            WinningMessage.Text = "Congrats \nYou Win!";
            isGameOver = true;
        }

        private void Reset(object o, RoutedEventArgs e)
        {
            Canvas.SetTop(Sprite, 250);
            Canvas.SetLeft(Sprite, 200);

            //remove winning text if needed
            if (isGameOver)
            {
                WinningMessage.Text = "Help Llama \nFind His \nCactus";
                isGameOver = false;
            }
        }

        private void Window_OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    MoveUp_Click(sender,e);
                    break;
                case Key.Down:
                    MoveDown_Click(sender, e);
                    break;
                case Key.Left:
                    MoveLeft_Click(sender, e);
                    break;
                case Key.Right:
                    MoveRight_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
