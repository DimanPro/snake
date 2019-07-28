﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //установка фиксированных размеров окна 
            Console.SetWindowSize(1, 1);
            Console.SetWindowSize(80, 26);
            Console.SetBufferSize(80, 26);



            //отрисовка рамок
            HorizontalLine  upLine  = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine   = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine  = new VerticalLine(0, 24, 78, '+');

            //отрисовка точек
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }


    }
}
