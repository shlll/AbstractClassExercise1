using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Line();
            DrawLine(line);
            var circle = new Circle();
            DrawCircle(circle);
            var square = new Square();
            DrawSquare(square);
            Console.ReadLine();
        }
        public static void DrawLine(Line line)
        {
            line.Draw();
        }
        public static void DrawCircle(Circle circle)
        {
            circle.Draw();
        }
        public static void DrawSquare(Square square)
        {
            square.Draw();
        }
    }
    
    



}
