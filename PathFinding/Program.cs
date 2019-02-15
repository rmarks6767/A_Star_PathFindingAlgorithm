﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PathFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid(100, 100);

            Path path = new Path();

            List<Node> totalPath = path.GeneratePath(new Vector2(0, 0), new Vector2(99, 9), grid);

            Char[,] display = new char[grid.MapWidth, grid.MapHeight];

            for (int i = 0; i < grid.MapWidth; i++)
            {
                for (int ii = 0; ii < grid.MapHeight; ii++)
                {
                    display[i, ii] = ' ';
                }
            }

            for (int i = 0; i < totalPath.Count; i++)
            {
                display[totalPath[i].X, totalPath[i].Y] = 'O'; 
            }

            for (int i = 0; i < grid.MapWidth; i++)
            {
                for (int ii = 0; ii < grid.MapHeight; ii++)
                {
                    Console.Write(display[i, ii]);
                }
                Console.WriteLine();
            }
        }
    }
}
