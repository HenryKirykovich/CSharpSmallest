using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;


namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
          
    {
        private const int SnakeSquareSize = 20;  // size of Snake

        private readonly SolidColorBrush _snakeColor = Brushes.Green; // color of snake / declaring object
        
        private enum Direction   // creating movement for worm
        {
            Left, Top, Right, Bottom
        }

        private Direction _direction = Direction.Right; // declaring object Direction
        private const int TimerInterval = 200; // declaring const speed of game
        private DispatcherTimer _timer; // object timer 

       



        private Rectangle _snakeHead; // declaring Head of Snake 
        private Point _foodPosition; // declaring object for located head or food or any
       
        private static readonly Random randomPositionFood = new Random();

        private List<Rectangle> _snake = new List<Rectangle> (); // gathering all element ( head, fruit , new body)


        public MainWindow()
        {
            InitializeComponent();
            GameCanvas.Loaded += GameCanvas_Loaded;
                      
        }


        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            _snakeHead = CreateSnakeSegment(new Point(5, 5)); // method for defining position of Head
            _snake.Add(_snakeHead);
            GameCanvas.Children.Add(_snakeHead); // displaying head of snake on Canvas (sending Head to Canvas via Children property



            PlaceFood();

            _timer = new DispatcherTimer();  // declaning timer 
            _timer.Tick += Timer_Tick;
            _timer.Interval = TimeSpan.FromMilliseconds(TimerInterval);
            _timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point newHeadPosition = CalculateNewHeadPosition(); // the coordinate head snake

            if (newHeadPosition == _foodPosition)
            {
                EatFood();
                PlaceFood();
            }

            for(int i = _snake.Count - 1; i > 0; i--)
            {
                Canvas.SetLeft(_snake[i], Canvas.GetLeft(_snake[i-1]));
                Canvas.SetTop(_snake[i], Canvas.GetTop(_snake[i - 1]));
            }

            Canvas.SetLeft(_snakeHead, newHeadPosition.X * SnakeSquareSize);
            Canvas.SetTop(_snakeHead, newHeadPosition.Y * SnakeSquareSize);
            
        }

        private void EatFood()
        {
           // Find the food image at the current food position and remove it
           
            GameCanvas.Children.Remove(GameCanvas.Children.OfType<System.Windows.Controls.Image>().FirstOrDefault());

            Rectangle newSnake = CreateSnakeSegment(_foodPosition);
            _snake.Add(newSnake);
            GameCanvas.Children.Add(newSnake);
        }


        private Point CalculateNewHeadPosition()
        {
            double left = Canvas.GetLeft(_snakeHead) / SnakeSquareSize;  // coordinate on x 
            double top = Canvas.GetTop(_snakeHead) / SnakeSquareSize;  // coordinate on y



            Point headCurrentPosition = new Point(left, top);
            Point newHeadPosition = new Point();

            switch (_direction)
            {
                case Direction.Left:
                    newHeadPosition = new Point(headCurrentPosition.X-1, headCurrentPosition.Y);
                    break;
                case Direction.Right:
                    newHeadPosition = new Point(headCurrentPosition.X+1, headCurrentPosition.Y);
                    break;
                case Direction.Top:
                    newHeadPosition = new Point(headCurrentPosition.X, headCurrentPosition.Y-1);
                    break;
                case Direction.Bottom: 
                    newHeadPosition = new Point(headCurrentPosition.X, headCurrentPosition.Y+1);
                    break;

            }
            return newHeadPosition;
        }

        


        private void PlaceFood()
        {
            int maxX = (int)(GameCanvas.ActualWidth / SnakeSquareSize); // maximum cell grid in X axe in Canvas
            int maxY = (int)(GameCanvas.ActualHeight / SnakeSquareSize);// maximum cell grid Y axe in Canvas

            int foodX = randomPositionFood.Next(0, maxX);
            int foodY = randomPositionFood.Next(0, maxY);

            _foodPosition = new Point(foodX, foodY);

            System.Windows.Controls.Image foodImage = new System.Windows.Controls.Image
            {
                Width = SnakeSquareSize,
                Height = SnakeSquareSize,
                Source = new BitmapImage(new Uri("images/banana.png", UriKind.Relative))
            };


            Canvas.SetLeft(foodImage, foodX * SnakeSquareSize);
            Canvas.SetTop(foodImage, foodY * SnakeSquareSize);


            GameCanvas.Children.Add(foodImage); // add my picture to Canvas in hold position 

        }


        private Rectangle CreateSnakeSegment(Point position)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = SnakeSquareSize,
                Height = SnakeSquareSize,
                Fill = _snakeColor
            };

            Canvas.SetLeft(rectangle, position.X * SnakeSquareSize);
            Canvas.SetTop(rectangle, position.Y * SnakeSquareSize);

            return rectangle;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (_direction != Direction.Bottom)
                    {
                        _direction = Direction.Top;
                    }
                    break;
                case Key.Down:
                    if (_direction != Direction.Top)
                    {
                        _direction = Direction.Bottom;
                    }
                    break;
                case Key.Left:
                    if (_direction != Direction.Right)
                    {
                        _direction = Direction.Left;
                    }
                    break;
                case Key.Right:
                    if (_direction != Direction.Left)
                    {
                        _direction = Direction.Right;
                    }
                    break;

            }
        }
    }
}
