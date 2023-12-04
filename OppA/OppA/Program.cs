using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using OppA;

namespace ConsoleStars
{
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new IStar[]
            {
                new Phases(random),
                new Phases(random),
                new Phases(random),
                new Movable(random),
                new Movable(random),
                new Movable(random),
            };
            while (true)
            {
                Console.Clear();

                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                
                //foreach (var star in stars)
                //{
                //    if (star is PhasesStar)
                //    {
                //        var phasesStar = (PhasesStar)star;
                //        phasesStar.Show();
                //        phasesStar.Update();
                //    }
                //    else if (star is MovableStar)
                //    {
                //        var phasesStar = (MovableStar)star;
                //        phasesStar.Show();
                //        phasesStar.Update();
                //    }
                //}

                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}