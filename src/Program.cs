// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace MiniCactpotAnalysis
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main()
        {
            List<int[]> Lines = new List<int[]>()
            {
                new [] { 0, 1, 2 },
                new [] { 3, 4, 5 },
                new [] { 6, 7, 8 },
                new [] { 0, 4, 8 },
                new [] { 1, 4, 7 },
                new [] { 2, 5, 8 },
                new [] { 0, 3, 6 },
                new [] { 2, 4, 6 }
            };
            Dictionary<int, int> payTable = new Dictionary<int, int>{
                {6, 10000},
                {7, 36},
                {8, 720},
                {9, 360},
                {10, 80},
                {11, 252},
                {12, 108},
                {13, 72},
                {14, 54},
                {15, 180},
                {16, 72},
                {17, 180},
                {18, 119},
                {19, 36},
                {20, 306},
                {21, 1080},
                {22, 144},
                {23, 1800},
                {24, 3600},
            };


            BoardPlayer CactBoard = new BoardPlayer(rnd);
            CactBoard.NormalStart(rnd);
            CactBoard.Proceed(new int[] {4, 5, 6}, rnd);
        }
    }
}