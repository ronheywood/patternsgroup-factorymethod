﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            var maze = MazeGame.MakeMaze();
            Console.WriteLine(maze.rooms.FirstOrDefault());
        }
    }
}