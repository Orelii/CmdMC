using System;

namespace CmdMC
{

    class Render
    {
        public static void RenderBoxF(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[0, 0, layer]);
            ReplaceType(layer0[1, 0, layer]);
            ReplaceType(layer0[2, 0, layer]);
            ReplaceType(layer0[3, 0, layer]);
            ReplaceType(layer0[4, 0, layer]);
            ReplaceType(layer0[5, 0, layer]);
            ReplaceType(layer0[6, 0, layer]);
            ReplaceType(layer0[7, 0, layer]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[0, 1, layer]);
            ReplaceType(layer0[1, 1, layer]);
            ReplaceType(layer0[2, 1, layer]);
            ReplaceType(layer0[3, 1, layer]);
            ReplaceType(layer0[4, 1, layer]);
            ReplaceType(layer0[5, 1, layer]);
            ReplaceType(layer0[6, 1, layer]);
            ReplaceType(layer0[7, 1, layer]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[0, 2, layer]);
            ReplaceType(layer0[1, 2, layer]);
            ReplaceType(layer0[2, 2, layer]);
            ReplaceType(layer0[3, 2, layer]);
            ReplaceType(layer0[4, 2, layer]);
            ReplaceType(layer0[5, 2, layer]);
            ReplaceType(layer0[6, 2, layer]);
            ReplaceType(layer0[7, 2, layer]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[0, 3, layer]);
            ReplaceType(layer0[1, 3, layer]);
            ReplaceType(layer0[2, 3, layer]);
            ReplaceType(layer0[3, 3, layer]);
            ReplaceType(layer0[4, 3, layer]);
            ReplaceType(layer0[5, 3, layer]);
            ReplaceType(layer0[6, 3, layer]);
            ReplaceType(layer0[7, 3, layer]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[0, 4, layer]);
            ReplaceType(layer0[1, 4, layer]);
            ReplaceType(layer0[2, 4, layer]);
            ReplaceType(layer0[3, 4, layer]);
            ReplaceType(layer0[4, 4, layer]);
            ReplaceType(layer0[5, 4, layer]);
            ReplaceType(layer0[6, 4, layer]);
            ReplaceType(layer0[7, 4, layer]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[0, 5, layer]);
            ReplaceType(layer0[1, 5, layer]);
            ReplaceType(layer0[2, 5, layer]);
            ReplaceType(layer0[3, 5, layer]);
            ReplaceType(layer0[4, 5, layer]);
            ReplaceType(layer0[5, 5, layer]);
            ReplaceType(layer0[6, 5, layer]);
            ReplaceType(layer0[7, 5, layer]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[0, 6, layer]);
            ReplaceType(layer0[1, 6, layer]);
            ReplaceType(layer0[2, 6, layer]);
            ReplaceType(layer0[3, 6, layer]);
            ReplaceType(layer0[4, 6, layer]);
            ReplaceType(layer0[5, 6, layer]);
            ReplaceType(layer0[6, 6, layer]);
            ReplaceType(layer0[7, 6, layer]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[0, 7, layer]);
            ReplaceType(layer0[1, 7, layer]);
            ReplaceType(layer0[2, 7, layer]);
            ReplaceType(layer0[3, 7, layer]);
            ReplaceType(layer0[4, 7, layer]);
            ReplaceType(layer0[5, 7, layer]);
            ReplaceType(layer0[6, 7, layer]);
            ReplaceType(layer0[7, 7, layer]);
            Console.WriteLine("");
        }
        public static void RenderCubeF(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksF(0, 0, layer0);
            RenderBehindBlocksF(1, 0, layer0);
            RenderBehindBlocksF(2, 0, layer0);
            RenderBehindBlocksF(3, 0, layer0);
            RenderBehindBlocksF(4, 0, layer0);
            RenderBehindBlocksF(5, 0, layer0);
            RenderBehindBlocksF(6, 0, layer0);
            RenderBehindBlocksF(7, 0, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksF(0, 1, layer0);
            RenderBehindBlocksF(1, 1, layer0);
            RenderBehindBlocksF(2, 1, layer0);
            RenderBehindBlocksF(3, 1, layer0);
            RenderBehindBlocksF(4, 1, layer0);
            RenderBehindBlocksF(5, 1, layer0);
            RenderBehindBlocksF(6, 1, layer0);
            RenderBehindBlocksF(7, 1, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksF(0, 2, layer0);
            RenderBehindBlocksF(1, 2, layer0);
            RenderBehindBlocksF(2, 2, layer0);
            RenderBehindBlocksF(3, 2, layer0);
            RenderBehindBlocksF(4, 2, layer0);
            RenderBehindBlocksF(5, 2, layer0);
            RenderBehindBlocksF(6, 2, layer0);
            RenderBehindBlocksF(7, 2, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksF(0, 3, layer0);
            RenderBehindBlocksF(1, 3, layer0);
            RenderBehindBlocksF(2, 3, layer0);
            RenderBehindBlocksF(3, 3, layer0);
            RenderBehindBlocksF(4, 3, layer0);
            RenderBehindBlocksF(5, 3, layer0);
            RenderBehindBlocksF(6, 3, layer0);
            RenderBehindBlocksF(7, 3, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksF(0, 4, layer0);
            RenderBehindBlocksF(1, 4, layer0);
            RenderBehindBlocksF(2, 4, layer0);
            RenderBehindBlocksF(3, 4, layer0);
            RenderBehindBlocksF(4, 4, layer0);
            RenderBehindBlocksF(5, 4, layer0);
            RenderBehindBlocksF(6, 4, layer0);
            RenderBehindBlocksF(7, 4, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksF(0, 5, layer0);
            RenderBehindBlocksF(1, 5, layer0);
            RenderBehindBlocksF(2, 5, layer0);
            RenderBehindBlocksF(3, 5, layer0);
            RenderBehindBlocksF(4, 5, layer0);
            RenderBehindBlocksF(5, 5, layer0);
            RenderBehindBlocksF(6, 5, layer0);
            RenderBehindBlocksF(7, 5, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksF(0, 6, layer0);
            RenderBehindBlocksF(1, 6, layer0);
            RenderBehindBlocksF(2, 6, layer0);
            RenderBehindBlocksF(3, 6, layer0);
            RenderBehindBlocksF(4, 6, layer0);
            RenderBehindBlocksF(5, 6, layer0);
            RenderBehindBlocksF(6, 6, layer0);
            RenderBehindBlocksF(7, 6, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksF(0, 7, layer0);
            RenderBehindBlocksF(1, 7, layer0);
            RenderBehindBlocksF(2, 7, layer0);
            RenderBehindBlocksF(3, 7, layer0);
            RenderBehindBlocksF(4, 7, layer0);
            RenderBehindBlocksF(5, 7, layer0);
            RenderBehindBlocksF(6, 7, layer0);
            RenderBehindBlocksF(7, 7, layer0);
            Console.WriteLine("");
        }
        public static void RenderBoxT(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 7]);
            ReplaceType(layer0[1, layer, 7]);
            ReplaceType(layer0[2, layer, 7]);
            ReplaceType(layer0[3, layer, 7]);
            ReplaceType(layer0[4, layer, 7]);
            ReplaceType(layer0[5, layer, 7]);
            ReplaceType(layer0[6, layer, 7]);
            ReplaceType(layer0[7, layer, 7]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 6]);
            ReplaceType(layer0[1, layer, 6]);
            ReplaceType(layer0[2, layer, 6]);
            ReplaceType(layer0[3, layer, 6]);
            ReplaceType(layer0[4, layer, 6]);
            ReplaceType(layer0[5, layer, 6]);
            ReplaceType(layer0[6, layer, 6]);
            ReplaceType(layer0[7, layer, 6]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 5]);
            ReplaceType(layer0[1, layer, 5]);
            ReplaceType(layer0[2, layer, 5]);
            ReplaceType(layer0[3, layer, 5]);
            ReplaceType(layer0[4, layer, 5]);
            ReplaceType(layer0[5, layer, 5]);
            ReplaceType(layer0[6, layer, 5]);
            ReplaceType(layer0[7, layer, 5]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 4]);
            ReplaceType(layer0[1, layer, 4]);
            ReplaceType(layer0[2, layer, 4]);
            ReplaceType(layer0[3, layer, 4]);
            ReplaceType(layer0[4, layer, 4]);
            ReplaceType(layer0[5, layer, 4]);
            ReplaceType(layer0[6, layer, 4]);
            ReplaceType(layer0[7, layer, 4]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 3]);
            ReplaceType(layer0[1, layer, 3]);
            ReplaceType(layer0[2, layer, 3]);
            ReplaceType(layer0[3, layer, 3]);
            ReplaceType(layer0[4, layer, 3]);
            ReplaceType(layer0[5, layer, 3]);
            ReplaceType(layer0[6, layer, 3]);
            ReplaceType(layer0[7, layer, 3]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 2]);
            ReplaceType(layer0[1, layer, 2]);
            ReplaceType(layer0[2, layer, 2]);
            ReplaceType(layer0[3, layer, 2]);
            ReplaceType(layer0[4, layer, 2]);
            ReplaceType(layer0[5, layer, 2]);
            ReplaceType(layer0[6, layer, 2]);
            ReplaceType(layer0[7, layer, 2]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 1]);
            ReplaceType(layer0[1, layer, 1]);
            ReplaceType(layer0[2, layer, 1]);
            ReplaceType(layer0[3, layer, 1]);
            ReplaceType(layer0[4, layer, 1]);
            ReplaceType(layer0[5, layer, 1]);
            ReplaceType(layer0[6, layer, 1]);
            ReplaceType(layer0[7, layer, 1]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 0]);
            ReplaceType(layer0[1, layer, 0]);
            ReplaceType(layer0[2, layer, 0]);
            ReplaceType(layer0[3, layer, 0]);
            ReplaceType(layer0[4, layer, 0]);
            ReplaceType(layer0[5, layer, 0]);
            ReplaceType(layer0[6, layer, 0]);
            ReplaceType(layer0[7, layer, 0]);
        }
        public static void RenderCubeT(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksT(0, 7, layer0);
            RenderBehindBlocksT(1, 7, layer0);
            RenderBehindBlocksT(2, 7, layer0);
            RenderBehindBlocksT(3, 7, layer0);
            RenderBehindBlocksT(4, 7, layer0);
            RenderBehindBlocksT(5, 7, layer0);
            RenderBehindBlocksT(6, 7, layer0);
            RenderBehindBlocksT(7, 7, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksT(0, 6, layer0);
            RenderBehindBlocksT(1, 6, layer0);
            RenderBehindBlocksT(2, 6, layer0);
            RenderBehindBlocksT(3, 6, layer0);
            RenderBehindBlocksT(4, 6, layer0);
            RenderBehindBlocksT(5, 6, layer0);
            RenderBehindBlocksT(6, 6, layer0);
            RenderBehindBlocksT(7, 6, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksT(0, 5, layer0);
            RenderBehindBlocksT(1, 5, layer0);
            RenderBehindBlocksT(2, 5, layer0);
            RenderBehindBlocksT(3, 5, layer0);
            RenderBehindBlocksT(4, 5, layer0);
            RenderBehindBlocksT(5, 5, layer0);
            RenderBehindBlocksT(6, 5, layer0);
            RenderBehindBlocksT(7, 5, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksT(0, 4, layer0);
            RenderBehindBlocksT(1, 4, layer0);
            RenderBehindBlocksT(2, 4, layer0);
            RenderBehindBlocksT(3, 4, layer0);
            RenderBehindBlocksT(4, 4, layer0);
            RenderBehindBlocksT(5, 4, layer0);
            RenderBehindBlocksT(6, 4, layer0);
            RenderBehindBlocksT(7, 4, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksT(0, 3, layer0);
            RenderBehindBlocksT(1, 3, layer0);
            RenderBehindBlocksT(2, 3, layer0);
            RenderBehindBlocksT(3, 3, layer0);
            RenderBehindBlocksT(4, 3, layer0);
            RenderBehindBlocksT(5, 3, layer0);
            RenderBehindBlocksT(6, 3, layer0);
            RenderBehindBlocksT(7, 3, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksT(0, 2, layer0);
            RenderBehindBlocksT(1, 2, layer0);
            RenderBehindBlocksT(2, 2, layer0);
            RenderBehindBlocksT(3, 2, layer0);
            RenderBehindBlocksT(4, 2, layer0);
            RenderBehindBlocksT(5, 2, layer0);
            RenderBehindBlocksT(6, 2, layer0);
            RenderBehindBlocksT(7, 2, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksT(0, 1, layer0);
            RenderBehindBlocksT(1, 1, layer0);
            RenderBehindBlocksT(2, 1, layer0);
            RenderBehindBlocksT(3, 1, layer0);
            RenderBehindBlocksT(4, 1, layer0);
            RenderBehindBlocksT(5, 1, layer0);
            RenderBehindBlocksT(6, 1, layer0);
            RenderBehindBlocksT(7, 1, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksT(0, 0, layer0);
            RenderBehindBlocksT(1, 0, layer0);
            RenderBehindBlocksT(2, 0, layer0);
            RenderBehindBlocksT(3, 0, layer0);
            RenderBehindBlocksT(4, 0, layer0);
            RenderBehindBlocksT(5, 0, layer0);
            RenderBehindBlocksT(6, 0, layer0);
            RenderBehindBlocksT(7, 0, layer0);
            Console.WriteLine("");
        }
        public static void RenderBoxR(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[layer, 0, 0]);
            ReplaceType(layer0[layer, 0, 1]);
            ReplaceType(layer0[layer, 0, 2]);
            ReplaceType(layer0[layer, 0, 3]);
            ReplaceType(layer0[layer, 0, 4]);
            ReplaceType(layer0[layer, 0, 5]);
            ReplaceType(layer0[layer, 0, 6]);
            ReplaceType(layer0[layer, 0, 7]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[layer, 1, 0]);
            ReplaceType(layer0[layer, 1, 1]);
            ReplaceType(layer0[layer, 1, 2]);
            ReplaceType(layer0[layer, 1, 3]);
            ReplaceType(layer0[layer, 1, 4]);
            ReplaceType(layer0[layer, 1, 5]);
            ReplaceType(layer0[layer, 1, 6]);
            ReplaceType(layer0[layer, 1, 7]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[layer, 2, 0]);
            ReplaceType(layer0[layer, 2, 1]);
            ReplaceType(layer0[layer, 2, 2]);
            ReplaceType(layer0[layer, 2, 3]);
            ReplaceType(layer0[layer, 2, 4]);
            ReplaceType(layer0[layer, 2, 5]);
            ReplaceType(layer0[layer, 2, 6]);
            ReplaceType(layer0[layer, 2, 7]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[layer, 3, 0]);
            ReplaceType(layer0[layer, 3, 1]);
            ReplaceType(layer0[layer, 3, 2]);
            ReplaceType(layer0[layer, 3, 3]);
            ReplaceType(layer0[layer, 3, 4]);
            ReplaceType(layer0[layer, 3, 5]);
            ReplaceType(layer0[layer, 3, 6]);
            ReplaceType(layer0[layer, 3, 7]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[layer, 4, 0]);
            ReplaceType(layer0[layer, 4, 1]);
            ReplaceType(layer0[layer, 4, 2]);
            ReplaceType(layer0[layer, 4, 3]);
            ReplaceType(layer0[layer, 4, 4]);
            ReplaceType(layer0[layer, 4, 5]);
            ReplaceType(layer0[layer, 4, 6]);
            ReplaceType(layer0[layer, 4, 7]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[layer, 5, 0]);
            ReplaceType(layer0[layer, 5, 1]);
            ReplaceType(layer0[layer, 5, 2]);
            ReplaceType(layer0[layer, 5, 3]);
            ReplaceType(layer0[layer, 5, 4]);
            ReplaceType(layer0[layer, 5, 5]);
            ReplaceType(layer0[layer, 5, 6]);
            ReplaceType(layer0[layer, 5, 7]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[layer, 6, 0]);
            ReplaceType(layer0[layer, 6, 1]);
            ReplaceType(layer0[layer, 6, 2]);
            ReplaceType(layer0[layer, 6, 3]);
            ReplaceType(layer0[layer, 6, 4]);
            ReplaceType(layer0[layer, 6, 5]);
            ReplaceType(layer0[layer, 6, 6]);
            ReplaceType(layer0[layer, 6, 7]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[layer, 7, 0]);
            ReplaceType(layer0[layer, 7, 1]);
            ReplaceType(layer0[layer, 7, 2]);
            ReplaceType(layer0[layer, 7, 3]);
            ReplaceType(layer0[layer, 7, 4]);
            ReplaceType(layer0[layer, 7, 5]);
            ReplaceType(layer0[layer, 7, 6]);
            ReplaceType(layer0[layer, 7, 7]);
        }
        public static void RenderCubeR(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksR(0, 0, layer0);
            RenderBehindBlocksR(0, 1, layer0);
            RenderBehindBlocksR(0, 2, layer0);
            RenderBehindBlocksR(0, 3, layer0);
            RenderBehindBlocksR(0, 4, layer0);
            RenderBehindBlocksR(0, 5, layer0);
            RenderBehindBlocksR(0, 6, layer0);
            RenderBehindBlocksR(0, 7, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksR(1, 0, layer0);
            RenderBehindBlocksR(1, 1, layer0);
            RenderBehindBlocksR(1, 2, layer0);
            RenderBehindBlocksR(1, 3, layer0);
            RenderBehindBlocksR(1, 4, layer0);
            RenderBehindBlocksR(1, 5, layer0);
            RenderBehindBlocksR(1, 6, layer0);
            RenderBehindBlocksR(1, 7, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksR(2, 0, layer0);
            RenderBehindBlocksR(2, 1, layer0);
            RenderBehindBlocksR(2, 2, layer0);
            RenderBehindBlocksR(2, 3, layer0);
            RenderBehindBlocksR(2, 4, layer0);
            RenderBehindBlocksR(2, 5, layer0);
            RenderBehindBlocksR(2, 6, layer0);
            RenderBehindBlocksR(2, 7, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksR(3, 0, layer0);
            RenderBehindBlocksR(3, 1, layer0);
            RenderBehindBlocksR(3, 2, layer0);
            RenderBehindBlocksR(3, 3, layer0);
            RenderBehindBlocksR(3, 4, layer0);
            RenderBehindBlocksR(3, 5, layer0);
            RenderBehindBlocksR(3, 6, layer0);
            RenderBehindBlocksR(3, 7, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksR(4, 0, layer0);
            RenderBehindBlocksR(4, 1, layer0);
            RenderBehindBlocksR(4, 2, layer0);
            RenderBehindBlocksR(4, 3, layer0);
            RenderBehindBlocksR(4, 4, layer0);
            RenderBehindBlocksR(4, 5, layer0);
            RenderBehindBlocksR(4, 6, layer0);
            RenderBehindBlocksR(4, 7, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksR(5, 0, layer0);
            RenderBehindBlocksR(5, 1, layer0);
            RenderBehindBlocksR(5, 2, layer0);
            RenderBehindBlocksR(5, 3, layer0);
            RenderBehindBlocksR(5, 4, layer0);
            RenderBehindBlocksR(5, 5, layer0);
            RenderBehindBlocksR(5, 6, layer0);
            RenderBehindBlocksR(5, 7, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksR(6, 0, layer0);
            RenderBehindBlocksR(6, 1, layer0);
            RenderBehindBlocksR(6, 2, layer0);
            RenderBehindBlocksR(6, 3, layer0);
            RenderBehindBlocksR(6, 4, layer0);
            RenderBehindBlocksR(6, 5, layer0);
            RenderBehindBlocksR(6, 6, layer0);
            RenderBehindBlocksR(6, 7, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksR(7, 0, layer0);
            RenderBehindBlocksR(7, 1, layer0);
            RenderBehindBlocksR(7, 2, layer0);
            RenderBehindBlocksR(7, 3, layer0);
            RenderBehindBlocksR(7, 4, layer0);
            RenderBehindBlocksR(7, 5, layer0);
            RenderBehindBlocksR(7, 6, layer0);
            RenderBehindBlocksR(7, 7, layer0);
            Console.WriteLine("");
        }
        public static void RenderBoxB(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[7, 0, layer]);
            ReplaceType(layer0[6, 0, layer]);
            ReplaceType(layer0[5, 0, layer]);
            ReplaceType(layer0[4, 0, layer]);
            ReplaceType(layer0[3, 0, layer]);
            ReplaceType(layer0[2, 0, layer]);
            ReplaceType(layer0[1, 0, layer]);
            ReplaceType(layer0[0, 0, layer]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[7, 1, layer]);
            ReplaceType(layer0[6, 1, layer]);
            ReplaceType(layer0[5, 1, layer]);
            ReplaceType(layer0[4, 1, layer]);
            ReplaceType(layer0[3, 1, layer]);
            ReplaceType(layer0[2, 1, layer]);
            ReplaceType(layer0[1, 1, layer]);
            ReplaceType(layer0[0, 1, layer]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[7, 2, layer]);
            ReplaceType(layer0[6, 2, layer]);
            ReplaceType(layer0[5, 2, layer]);
            ReplaceType(layer0[4, 2, layer]);
            ReplaceType(layer0[3, 2, layer]);
            ReplaceType(layer0[2, 2, layer]);
            ReplaceType(layer0[1, 2, layer]);
            ReplaceType(layer0[0, 2, layer]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[7, 3, layer]);
            ReplaceType(layer0[6, 3, layer]);
            ReplaceType(layer0[5, 3, layer]);
            ReplaceType(layer0[4, 3, layer]);
            ReplaceType(layer0[3, 3, layer]);
            ReplaceType(layer0[2, 3, layer]);
            ReplaceType(layer0[1, 3, layer]);
            ReplaceType(layer0[0, 3, layer]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[7, 4, layer]);
            ReplaceType(layer0[6, 4, layer]);
            ReplaceType(layer0[5, 4, layer]);
            ReplaceType(layer0[4, 4, layer]);
            ReplaceType(layer0[3, 4, layer]);
            ReplaceType(layer0[2, 4, layer]);
            ReplaceType(layer0[1, 4, layer]);
            ReplaceType(layer0[0, 4, layer]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[7, 5, layer]);
            ReplaceType(layer0[6, 5, layer]);
            ReplaceType(layer0[5, 5, layer]);
            ReplaceType(layer0[4, 5, layer]);
            ReplaceType(layer0[3, 5, layer]);
            ReplaceType(layer0[2, 5, layer]);
            ReplaceType(layer0[1, 5, layer]);
            ReplaceType(layer0[0, 5, layer]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[7, 6, layer]);
            ReplaceType(layer0[6, 6, layer]);
            ReplaceType(layer0[5, 6, layer]);
            ReplaceType(layer0[4, 6, layer]);
            ReplaceType(layer0[3, 6, layer]);
            ReplaceType(layer0[2, 6, layer]);
            ReplaceType(layer0[1, 6, layer]);
            ReplaceType(layer0[0, 6, layer]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[7, 7, layer]);
            ReplaceType(layer0[6, 7, layer]);
            ReplaceType(layer0[5, 7, layer]);
            ReplaceType(layer0[4, 7, layer]);
            ReplaceType(layer0[3, 7, layer]);
            ReplaceType(layer0[2, 7, layer]);
            ReplaceType(layer0[1, 7, layer]);
            ReplaceType(layer0[0, 7, layer]);
            Console.WriteLine("");
        }
        public static void RenderCubeB(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksB(7, 0, layer0);
            RenderBehindBlocksB(6, 0, layer0);
            RenderBehindBlocksB(5, 0, layer0);
            RenderBehindBlocksB(4, 0, layer0);
            RenderBehindBlocksB(3, 0, layer0);
            RenderBehindBlocksB(2, 0, layer0);
            RenderBehindBlocksB(1, 0, layer0);
            RenderBehindBlocksB(0, 0, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksB(7, 1, layer0);
            RenderBehindBlocksB(6, 1, layer0);
            RenderBehindBlocksB(5, 1, layer0);
            RenderBehindBlocksB(4, 1, layer0);
            RenderBehindBlocksB(3, 1, layer0);
            RenderBehindBlocksB(2, 1, layer0);
            RenderBehindBlocksB(1, 1, layer0);
            RenderBehindBlocksB(0, 1, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksB(7, 2, layer0);
            RenderBehindBlocksB(6, 2, layer0);
            RenderBehindBlocksB(5, 2, layer0);
            RenderBehindBlocksB(4, 2, layer0);
            RenderBehindBlocksB(3, 2, layer0);
            RenderBehindBlocksB(2, 2, layer0);
            RenderBehindBlocksB(1, 2, layer0);
            RenderBehindBlocksB(0, 2, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksB(7, 3, layer0);
            RenderBehindBlocksB(6, 3, layer0);
            RenderBehindBlocksB(5, 3, layer0);
            RenderBehindBlocksB(4, 3, layer0);
            RenderBehindBlocksB(3, 3, layer0);
            RenderBehindBlocksB(2, 3, layer0);
            RenderBehindBlocksB(1, 3, layer0);
            RenderBehindBlocksB(0, 3, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksB(7, 4, layer0);
            RenderBehindBlocksB(6, 4, layer0);
            RenderBehindBlocksB(5, 4, layer0);
            RenderBehindBlocksB(4, 4, layer0);
            RenderBehindBlocksB(3, 4, layer0);
            RenderBehindBlocksB(2, 4, layer0);
            RenderBehindBlocksB(1, 4, layer0);
            RenderBehindBlocksB(0, 4, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksB(7, 5, layer0);
            RenderBehindBlocksB(6, 5, layer0);
            RenderBehindBlocksB(5, 5, layer0);
            RenderBehindBlocksB(4, 5, layer0);
            RenderBehindBlocksB(3, 5, layer0);
            RenderBehindBlocksB(2, 5, layer0);
            RenderBehindBlocksB(1, 5, layer0);
            RenderBehindBlocksB(0, 5, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksB(7, 6, layer0);
            RenderBehindBlocksB(6, 6, layer0);
            RenderBehindBlocksB(5, 6, layer0);
            RenderBehindBlocksB(4, 6, layer0);
            RenderBehindBlocksB(3, 6, layer0);
            RenderBehindBlocksB(2, 6, layer0);
            RenderBehindBlocksB(1, 6, layer0);
            RenderBehindBlocksB(0, 6, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksB(7, 7, layer0);
            RenderBehindBlocksB(6, 7, layer0);
            RenderBehindBlocksB(5, 7, layer0);
            RenderBehindBlocksB(4, 7, layer0);
            RenderBehindBlocksB(3, 7, layer0);
            RenderBehindBlocksB(2, 7, layer0);
            RenderBehindBlocksB(1, 7, layer0);
            RenderBehindBlocksB(0, 7, layer0);
            Console.WriteLine("");
        }
        public static void RenderBoxU(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 0]);
            ReplaceType(layer0[1, layer, 0]);
            ReplaceType(layer0[2, layer, 0]);
            ReplaceType(layer0[3, layer, 0]);
            ReplaceType(layer0[4, layer, 0]);
            ReplaceType(layer0[5, layer, 0]);
            ReplaceType(layer0[6, layer, 0]);
            ReplaceType(layer0[7, layer, 0]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 1]);
            ReplaceType(layer0[1, layer, 1]);
            ReplaceType(layer0[2, layer, 1]);
            ReplaceType(layer0[3, layer, 1]);
            ReplaceType(layer0[4, layer, 1]);
            ReplaceType(layer0[5, layer, 1]);
            ReplaceType(layer0[6, layer, 1]);
            ReplaceType(layer0[7, layer, 1]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 2]);
            ReplaceType(layer0[1, layer, 2]);
            ReplaceType(layer0[2, layer, 2]);
            ReplaceType(layer0[3, layer, 2]);
            ReplaceType(layer0[4, layer, 2]);
            ReplaceType(layer0[5, layer, 2]);
            ReplaceType(layer0[6, layer, 2]);
            ReplaceType(layer0[7, layer, 2]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 3]);
            ReplaceType(layer0[1, layer, 3]);
            ReplaceType(layer0[2, layer, 3]);
            ReplaceType(layer0[3, layer, 3]);
            ReplaceType(layer0[4, layer, 3]);
            ReplaceType(layer0[5, layer, 3]);
            ReplaceType(layer0[6, layer, 3]);
            ReplaceType(layer0[7, layer, 3]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 4]);
            ReplaceType(layer0[1, layer, 4]);
            ReplaceType(layer0[2, layer, 4]);
            ReplaceType(layer0[3, layer, 4]);
            ReplaceType(layer0[4, layer, 4]);
            ReplaceType(layer0[5, layer, 4]);
            ReplaceType(layer0[6, layer, 4]);
            ReplaceType(layer0[7, layer, 4]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 5]);
            ReplaceType(layer0[1, layer, 5]);
            ReplaceType(layer0[2, layer, 5]);
            ReplaceType(layer0[3, layer, 5]);
            ReplaceType(layer0[4, layer, 5]);
            ReplaceType(layer0[5, layer, 5]);
            ReplaceType(layer0[6, layer, 5]);
            ReplaceType(layer0[7, layer, 5]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 6]);
            ReplaceType(layer0[1, layer, 6]);
            ReplaceType(layer0[2, layer, 6]);
            ReplaceType(layer0[3, layer, 6]);
            ReplaceType(layer0[4, layer, 6]);
            ReplaceType(layer0[5, layer, 6]);
            ReplaceType(layer0[6, layer, 6]);
            ReplaceType(layer0[7, layer, 6]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[0, layer, 7]);
            ReplaceType(layer0[1, layer, 7]);
            ReplaceType(layer0[2, layer, 7]);
            ReplaceType(layer0[3, layer, 7]);
            ReplaceType(layer0[4, layer, 7]);
            ReplaceType(layer0[5, layer, 7]);
            ReplaceType(layer0[6, layer, 7]);
            ReplaceType(layer0[7, layer, 7]);
        }
        public static void RenderCubeU(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksU(0, 7, layer0);
            RenderBehindBlocksU(1, 7, layer0);
            RenderBehindBlocksU(2, 7, layer0);
            RenderBehindBlocksU(3, 7, layer0);
            RenderBehindBlocksU(4, 7, layer0);
            RenderBehindBlocksU(5, 7, layer0);
            RenderBehindBlocksU(6, 7, layer0);
            RenderBehindBlocksU(7, 7, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksU(0, 6, layer0);
            RenderBehindBlocksU(1, 6, layer0);
            RenderBehindBlocksU(2, 6, layer0);
            RenderBehindBlocksU(3, 6, layer0);
            RenderBehindBlocksU(4, 6, layer0);
            RenderBehindBlocksU(5, 6, layer0);
            RenderBehindBlocksU(6, 6, layer0);
            RenderBehindBlocksU(7, 6, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksU(0, 5, layer0);
            RenderBehindBlocksU(1, 5, layer0);
            RenderBehindBlocksU(2, 5, layer0);
            RenderBehindBlocksU(3, 5, layer0);
            RenderBehindBlocksU(4, 5, layer0);
            RenderBehindBlocksU(5, 5, layer0);
            RenderBehindBlocksU(6, 5, layer0);
            RenderBehindBlocksU(7, 5, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksU(0, 4, layer0);
            RenderBehindBlocksU(1, 4, layer0);
            RenderBehindBlocksU(2, 4, layer0);
            RenderBehindBlocksU(3, 4, layer0);
            RenderBehindBlocksU(4, 4, layer0);
            RenderBehindBlocksU(5, 4, layer0);
            RenderBehindBlocksU(6, 4, layer0);
            RenderBehindBlocksU(7, 4, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksU(0, 3, layer0);
            RenderBehindBlocksU(1, 3, layer0);
            RenderBehindBlocksU(2, 3, layer0);
            RenderBehindBlocksU(3, 3, layer0);
            RenderBehindBlocksU(4, 3, layer0);
            RenderBehindBlocksU(5, 3, layer0);
            RenderBehindBlocksU(6, 3, layer0);
            RenderBehindBlocksU(7, 3, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksU(0, 2, layer0);
            RenderBehindBlocksU(1, 2, layer0);
            RenderBehindBlocksU(2, 2, layer0);
            RenderBehindBlocksU(3, 2, layer0);
            RenderBehindBlocksU(4, 2, layer0);
            RenderBehindBlocksU(5, 2, layer0);
            RenderBehindBlocksU(6, 2, layer0);
            RenderBehindBlocksU(7, 2, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksU(0, 1, layer0);
            RenderBehindBlocksU(1, 1, layer0);
            RenderBehindBlocksU(2, 1, layer0);
            RenderBehindBlocksU(3, 1, layer0);
            RenderBehindBlocksU(4, 1, layer0);
            RenderBehindBlocksU(5, 1, layer0);
            RenderBehindBlocksU(6, 1, layer0);
            RenderBehindBlocksU(7, 1, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksU(0, 0, layer0);
            RenderBehindBlocksU(1, 0, layer0);
            RenderBehindBlocksU(2, 0, layer0);
            RenderBehindBlocksU(3, 0, layer0);
            RenderBehindBlocksU(4, 0, layer0);
            RenderBehindBlocksU(5, 0, layer0);
            RenderBehindBlocksU(6, 0, layer0);
            RenderBehindBlocksU(7, 0, layer0);
            Console.WriteLine("");
        }
        public static void RenderBoxL(string?[,,] layer0, int layer)
        {
            // level 0
            Console.WriteLine("");
            ReplaceType(layer0[layer, 0, 7]);
            ReplaceType(layer0[layer, 0, 6]);
            ReplaceType(layer0[layer, 0, 5]);
            ReplaceType(layer0[layer, 0, 4]);
            ReplaceType(layer0[layer, 0, 3]);
            ReplaceType(layer0[layer, 0, 2]);
            ReplaceType(layer0[layer, 0, 1]);
            ReplaceType(layer0[layer, 0, 0]);
            // level 1
            Console.WriteLine("");
            ReplaceType(layer0[layer, 1, 7]);
            ReplaceType(layer0[layer, 1, 6]);
            ReplaceType(layer0[layer, 1, 5]);
            ReplaceType(layer0[layer, 1, 4]);
            ReplaceType(layer0[layer, 1, 3]);
            ReplaceType(layer0[layer, 1, 2]);
            ReplaceType(layer0[layer, 1, 1]);
            ReplaceType(layer0[layer, 1, 0]);
            // level 2
            Console.WriteLine("");
            ReplaceType(layer0[layer, 2, 7]);
            ReplaceType(layer0[layer, 2, 6]);
            ReplaceType(layer0[layer, 2, 5]);
            ReplaceType(layer0[layer, 2, 4]);
            ReplaceType(layer0[layer, 2, 3]);
            ReplaceType(layer0[layer, 2, 2]);
            ReplaceType(layer0[layer, 2, 1]);
            ReplaceType(layer0[layer, 2, 0]);
            // level 3
            Console.WriteLine("");
            ReplaceType(layer0[layer, 3, 7]);
            ReplaceType(layer0[layer, 3, 6]);
            ReplaceType(layer0[layer, 3, 5]);
            ReplaceType(layer0[layer, 3, 4]);
            ReplaceType(layer0[layer, 3, 3]);
            ReplaceType(layer0[layer, 3, 2]);
            ReplaceType(layer0[layer, 3, 1]);
            ReplaceType(layer0[layer, 3, 0]);
            // level 4
            Console.WriteLine("");
            ReplaceType(layer0[layer, 4, 7]);
            ReplaceType(layer0[layer, 4, 6]);
            ReplaceType(layer0[layer, 4, 5]);
            ReplaceType(layer0[layer, 4, 4]);
            ReplaceType(layer0[layer, 4, 3]);
            ReplaceType(layer0[layer, 4, 2]);
            ReplaceType(layer0[layer, 4, 1]);
            ReplaceType(layer0[layer, 4, 0]);
            // level 5
            Console.WriteLine("");
            ReplaceType(layer0[layer, 5, 7]);
            ReplaceType(layer0[layer, 5, 6]);
            ReplaceType(layer0[layer, 5, 5]);
            ReplaceType(layer0[layer, 5, 4]);
            ReplaceType(layer0[layer, 5, 3]);
            ReplaceType(layer0[layer, 5, 2]);
            ReplaceType(layer0[layer, 5, 1]);
            ReplaceType(layer0[layer, 5, 0]);
            // level 6
            Console.WriteLine("");
            ReplaceType(layer0[layer, 6, 7]);
            ReplaceType(layer0[layer, 6, 6]);
            ReplaceType(layer0[layer, 6, 5]);
            ReplaceType(layer0[layer, 6, 4]);
            ReplaceType(layer0[layer, 6, 3]);
            ReplaceType(layer0[layer, 6, 2]);
            ReplaceType(layer0[layer, 6, 1]);
            ReplaceType(layer0[layer, 6, 0]);
            // level 7
            Console.WriteLine("");
            ReplaceType(layer0[layer, 7, 7]);
            ReplaceType(layer0[layer, 7, 6]);
            ReplaceType(layer0[layer, 7, 5]);
            ReplaceType(layer0[layer, 7, 4]);
            ReplaceType(layer0[layer, 7, 3]);
            ReplaceType(layer0[layer, 7, 2]);
            ReplaceType(layer0[layer, 7, 1]);
            ReplaceType(layer0[layer, 7, 0]);
        }
        public static void RenderCubeL(string?[,,] layer0)
        {
            // level 0
            Console.WriteLine("");
            RenderBehindBlocksL(0, 7, layer0);
            RenderBehindBlocksL(0, 6, layer0);
            RenderBehindBlocksL(0, 5, layer0);
            RenderBehindBlocksL(0, 4, layer0);
            RenderBehindBlocksL(0, 3, layer0);
            RenderBehindBlocksL(0, 2, layer0);
            RenderBehindBlocksL(0, 1, layer0);
            RenderBehindBlocksL(0, 0, layer0);
            // level 1
            Console.WriteLine("");
            RenderBehindBlocksL(1, 7, layer0);
            RenderBehindBlocksL(1, 6, layer0);
            RenderBehindBlocksL(1, 5, layer0);
            RenderBehindBlocksL(1, 4, layer0);
            RenderBehindBlocksL(1, 3, layer0);
            RenderBehindBlocksL(1, 2, layer0);
            RenderBehindBlocksL(1, 1, layer0);
            RenderBehindBlocksL(1, 0, layer0);
            // level 2
            Console.WriteLine("");
            RenderBehindBlocksL(2, 7, layer0);
            RenderBehindBlocksL(2, 6, layer0);
            RenderBehindBlocksL(2, 5, layer0);
            RenderBehindBlocksL(2, 4, layer0);
            RenderBehindBlocksL(2, 3, layer0);
            RenderBehindBlocksL(2, 2, layer0);
            RenderBehindBlocksL(2, 1, layer0);
            RenderBehindBlocksL(2, 0, layer0);
            // level 3
            Console.WriteLine("");
            RenderBehindBlocksL(3, 7, layer0);
            RenderBehindBlocksL(3, 6, layer0);
            RenderBehindBlocksL(3, 5, layer0);
            RenderBehindBlocksL(3, 4, layer0);
            RenderBehindBlocksL(3, 3, layer0);
            RenderBehindBlocksL(3, 2, layer0);
            RenderBehindBlocksL(3, 1, layer0);
            RenderBehindBlocksL(3, 0, layer0);
            // level 4
            Console.WriteLine("");
            RenderBehindBlocksL(4, 7, layer0);
            RenderBehindBlocksL(4, 6, layer0);
            RenderBehindBlocksL(4, 5, layer0);
            RenderBehindBlocksL(4, 4, layer0);
            RenderBehindBlocksL(4, 3, layer0);
            RenderBehindBlocksL(4, 2, layer0);
            RenderBehindBlocksL(4, 1, layer0);
            RenderBehindBlocksL(4, 0, layer0);
            // level 5
            Console.WriteLine("");
            RenderBehindBlocksL(5, 7, layer0);
            RenderBehindBlocksL(5, 6, layer0);
            RenderBehindBlocksL(5, 5, layer0);
            RenderBehindBlocksL(5, 4, layer0);
            RenderBehindBlocksL(5, 3, layer0);
            RenderBehindBlocksL(5, 2, layer0);
            RenderBehindBlocksL(5, 1, layer0);
            RenderBehindBlocksL(5, 0, layer0);
            // level 6
            Console.WriteLine("");
            RenderBehindBlocksL(6, 7, layer0);
            RenderBehindBlocksL(6, 6, layer0);
            RenderBehindBlocksL(6, 5, layer0);
            RenderBehindBlocksL(6, 4, layer0);
            RenderBehindBlocksL(6, 3, layer0);
            RenderBehindBlocksL(6, 2, layer0);
            RenderBehindBlocksL(6, 1, layer0);
            RenderBehindBlocksL(6, 0, layer0);
            // level 7
            Console.WriteLine("");
            RenderBehindBlocksL(7, 7, layer0);
            RenderBehindBlocksL(7, 6, layer0);
            RenderBehindBlocksL(7, 5, layer0);
            RenderBehindBlocksL(7, 4, layer0);
            RenderBehindBlocksL(7, 3, layer0);
            RenderBehindBlocksL(7, 2, layer0);
            RenderBehindBlocksL(7, 1, layer0);
            RenderBehindBlocksL(7, 0, layer0);
            Console.WriteLine("");
        }
        private static void RenderBehindBlocksF(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[num1, num2, 0] == "air")
            {
                layer0[num1, num2, 0] = null;
            }
            if (layer0[num1, num2, 1] == "air")
            {
                layer0[num1, num2, 1] = null;
            }
            if (layer0[num1, num2, 2] == "air")
            {
                layer0[num1, num2, 2] = null;
            }
            if (layer0[num1, num2, 3] == "air")
            {
                layer0[num1, num2, 3] = null;
            }
            if (layer0[num1, num2, 4] == "air")
            {
                layer0[num1, num2, 4] = null;
            }
            if (layer0[num1, num2, 5] == "air")
            {
                layer0[num1, num2, 5] = null;
            }
            if (layer0[num1, num2, 6] == "air")
            {
                layer0[num1, num2, 6] = null;
            }
            if (layer0[num1, num2, 7] == "air")
            {
                layer0[num1, num2, 7] = null;
            }
            if (layer0[num1, num2, 0] is null)
            {
                if (layer0[num1, num2, 1] is null)
                {
                    if (layer0[num1, num2, 2] is null)
                    {
                        if (layer0[num1, num2, 3] is null)
                        {
                            if (layer0[num1, num2, 4] is null)
                            {
                                if (layer0[num1, num2, 5] is null)
                                {
                                    if (layer0[num1, num2, 6] is null)
                                    {
                                        ReplaceType(layer0[num1, num2, 7]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[num1, num2, 6]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[num1, num2, 5]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[num1, num2, 4]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[num1, num2, 3]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[num1, num2, 2]);
                    }
                }
                else
                {
                    ReplaceType(layer0[num1, num2, 1]);
                }
            }
            else
            {
                ReplaceType(layer0[num1, num2, 0]);
            }
        }
        private static void RenderBehindBlocksT(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[num1, 0, num2] == "air")
            {
                layer0[num1, 0, num2] = null;
            }
            if (layer0[num1, 1, num2] == "air")
            {
                layer0[num1, 1, num2] = null;
            }
            if (layer0[num1, 2, num2] == "air")
            {
                layer0[num1, 2, num2] = null;
            }
            if (layer0[num1, 3, num2] == "air")
            {
                layer0[num1, 3, num2] = null;
            }
            if (layer0[num1, 4, num2] == "air")
            {
                layer0[num1, 4, num2] = null;
            }
            if (layer0[num1, 5, num2] == "air")
            {
                layer0[num1, 5, num2] = null;
            }
            if (layer0[num1, 6, num2] == "air")
            {
                layer0[num1, 6, num2] = null;
            }
            if (layer0[num1, 7, num2] == "air")
            {
                layer0[num1, 7, num2] = null;
            }
            if (layer0[num1, 0, num2] is null)
            {
                if (layer0[num1, 1, num2] is null)
                {
                    if (layer0[num1, 2, num2] is null)
                    {
                        if (layer0[num1, 3, num2] is null)
                        {
                            if (layer0[num1, 4, num2] is null)
                            {
                                if (layer0[num1, 5, num2] is null)
                                {
                                    if (layer0[num1, 6, num2] is null)
                                    {
                                        ReplaceType(layer0[num1, 7, num2]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[num1, 6, num2]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[num1, 5, num2]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[num1, 4, num2]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[num1, 3, num2]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[num1, 2, num2]);
                    }
                }
                else
                {
                    ReplaceType(layer0[num1, 1, num2]);
                }
            }
            else
            {
                ReplaceType(layer0[num1, 0, num2]);
            }
        }
        private static void RenderBehindBlocksR(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[0, num1, num2] == "air")
            {
                layer0[0, num1, num2] = null;
            }
            if (layer0[1, num1, num2] == "air")
            {
                layer0[1, num1, num2] = null;
            }
            if (layer0[2, num1, num2] == "air")
            {
                layer0[2, num1, num2] = null;
            }
            if (layer0[3, num1, num2] == "air")
            {
                layer0[3, num1, num2] = null;
            }
            if (layer0[4, num1, num2] == "air")
            {
                layer0[4, num1, num2] = null;
            }
            if (layer0[5, num1, num2] == "air")
            {
                layer0[5, num1, num2] = null;
            }
            if (layer0[6, num1, num2] == "air")
            {
                layer0[6, num1, num2] = null;
            }
            if (layer0[7, num1, num2] == "air")
            {
                layer0[7, num1, num2] = null;
            }
            if (layer0[7, num1, num2] is null)
            {
                if (layer0[6, num1, num2] is null)
                {
                    if (layer0[5, num1, num2] is null)
                    {
                        if (layer0[4, num1, num2] is null)
                        {
                            if (layer0[3, num1, num2] is null)
                            {
                                if (layer0[2, num1, num2] is null)
                                {
                                    if (layer0[1, num1, num2] is null)
                                    {
                                        ReplaceType(layer0[0, num1, num2]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[1, num1, num2]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[2, num1, num2]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[3, num1, num2]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[4, num1, num2]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[5, num1, num2]);
                    }
                }
                else
                {
                    ReplaceType(layer0[6, num1, num2]);
                }
            }
            else
            {
                ReplaceType(layer0[7, num1, num2]);
            }
        }
        private static void RenderBehindBlocksB(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[num1, num2, 7] == "air")
            {
                layer0[num1, num2, 7] = null;
            }
            if (layer0[num1, num2, 6] == "air")
            {
                layer0[num1, num2, 6] = null;
            }
            if (layer0[num1, num2, 5] == "air")
            {
                layer0[num1, num2, 5] = null;
            }
            if (layer0[num1, num2, 4] == "air")
            {
                layer0[num1, num2, 4] = null;
            }
            if (layer0[num1, num2, 3] == "air")
            {
                layer0[num1, num2, 3] = null;
            }
            if (layer0[num1, num2, 2] == "air")
            {
                layer0[num1, num2, 2] = null;
            }
            if (layer0[num1, num2, 1] == "air")
            {
                layer0[num1, num2, 1] = null;
            }
            if (layer0[num1, num2, 0] == "air")
            {
                layer0[num1, num2, 0] = null;
            }
            if (layer0[num1, num2, 7] is null)
            {
                if (layer0[num1, num2, 6] is null)
                {
                    if (layer0[num1, num2, 5] is null)
                    {
                        if (layer0[num1, num2, 4] is null)
                        {
                            if (layer0[num1, num2, 3] is null)
                            {
                                if (layer0[num1, num2, 2] is null)
                                {
                                    if (layer0[num1, num2, 1] is null)
                                    {
                                        ReplaceType(layer0[num1, num2, 0]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[num1, num2, 1]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[num1, num2, 2]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[num1, num2, 3]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[num1, num2, 4]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[num1, num2, 5]);
                    }
                }
                else
                {
                    ReplaceType(layer0[num1, num2, 6]);
                }
            }
            else
            {
                ReplaceType(layer0[num1, num2, 7]);
            }
        }
        private static void RenderBehindBlocksU(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[num1, 7, num2] == "air")
            {
                layer0[num1, 7, num2] = null;
            }
            if (layer0[num1, 6, num2] == "air")
            {
                layer0[num1, 6, num2] = null;
            }
            if (layer0[num1, 5, num2] == "air")
            {
                layer0[num1, 5, num2] = null;
            }
            if (layer0[num1, 4, num2] == "air")
            {
                layer0[num1, 4, num2] = null;
            }
            if (layer0[num1, 3, num2] == "air")
            {
                layer0[num1, 3, num2] = null;
            }
            if (layer0[num1, 2, num2] == "air")
            {
                layer0[num1, 2, num2] = null;
            }
            if (layer0[num1, 1, num2] == "air")
            {
                layer0[num1, 1, num2] = null;
            }
            if (layer0[num1, 0, num2] == "air")
            {
                layer0[num1, 0, num2] = null;
            }
            if (layer0[num1, 7, num2] is null)
            {
                if (layer0[num1, 6, num2] is null)
                {
                    if (layer0[num1, 5, num2] is null)
                    {
                        if (layer0[num1, 4, num2] is null)
                        {
                            if (layer0[num1, 3, num2] is null)
                            {
                                if (layer0[num1, 2, num2] is null)
                                {
                                    if (layer0[num1, 1, num2] is null)
                                    {
                                        ReplaceType(layer0[num1, 0, num2]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[num1, 1, num2]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[num1, 2, num2]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[num1, 3, num2]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[num1, 4, num2]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[num1, 5, num2]);
                    }
                }
                else
                {
                    ReplaceType(layer0[num1, 6, num2]);
                }
            }
            else
            {
                ReplaceType(layer0[num1, 7, num2]);
            }
        }
        private static void RenderBehindBlocksL(int num1, int num2, string?[,,] layer0)
        {
            if (layer0[0, num1, num2] == "air")
            {
                layer0[0, num1, num2] = null;
            }
            if (layer0[1, num1, num2] == "air")
            {
                layer0[1, num1, num2] = null;
            }
            if (layer0[2, num1, num2] == "air")
            {
                layer0[2, num1, num2] = null;
            }
            if (layer0[3, num1, num2] == "air")
            {
                layer0[3, num1, num2] = null;
            }
            if (layer0[4, num1, num2] == "air")
            {
                layer0[4, num1, num2] = null;
            }
            if (layer0[5, num1, num2] == "air")
            {
                layer0[5, num1, num2] = null;
            }
            if (layer0[6, num1, num2] == "air")
            {
                layer0[6, num1, num2] = null;
            }
            if (layer0[7, num1, num2] == "air")
            {
                layer0[7, num1, num2] = null;
            }
            if (layer0[0, num1, num2] is null)
            {
                if (layer0[1, num1, num2] is null)
                {
                    if (layer0[2, num1, num2] is null)
                    {
                        if (layer0[3, num1, num2] is null)
                        {
                            if (layer0[4, num1, num2] is null)
                            {
                                if (layer0[5, num1, num2] is null)
                                {
                                    if (layer0[6, num1, num2] is null)
                                    {
                                        ReplaceType(layer0[7, num1, num2]);
                                    }
                                    else
                                    {
                                        ReplaceType(layer0[6, num1, num2]);
                                    }
                                }
                                else
                                {
                                    ReplaceType(layer0[5, num1, num2]);
                                }
                            }
                            else
                            {
                                ReplaceType(layer0[4, num1, num2]);
                            }
                        }
                        else
                        {
                            ReplaceType(layer0[3, num1, num2]);
                        }
                    }
                    else
                    {
                        ReplaceType(layer0[2, num1, num2]);
                    }
                }
                else
                {
                    ReplaceType(layer0[1, num1, num2]);
                }
            }
            else
            {
                ReplaceType(layer0[0, num1, num2]);
            }
        }
        public static void BrickColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void StoneColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void GrassColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void WoolColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void GoldColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void FabricColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void WaterColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void LapisColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void NetherrackColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void DiamondColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void AmethystColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void AndesiteColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void MossColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        public static void IceColour(string balue)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(balue + " ");
            Console.ResetColor();
        }
        public static void SandColour(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(value + " ");
            Console.ResetColor();
        }
        private static void ReplaceType(string input)
        {
            if (input == "air")
            {
                input = null;
            }
            switch (input)
            {
                case "brick":
                    BrickColour("■");
                    break;
                case "stone":
                    StoneColour("■");
                    break;
                case "grass":
                    GrassColour("■");
                    break;
                case "wool":
                    WoolColour("■");
                    break;
                case "gold":
                    GoldColour("■");
                    break;
                case "fabric":
                    FabricColour("■");
                    break;
                case "water":
                    WaterColour("■");
                    break;
                case "lapis":
                    LapisColour("■");
                    break;
                case "netherrack":
                    NetherrackColour("■");
                    break;
                case "diamond":
                    DiamondColour("■");
                    break;
                case "amethyst":
                    AmethystColour("■");
                    break;
                case "andesite":
                    AndesiteColour("■");
                    break;
                case "moss":
                    MossColour("■");
                    break;
                case "ice":
                    IceColour("■");
                    break;
                case "sand":
                    SandColour("■");
                    break;
                default:
                    Console.Write("  ");
                    break;
            }
        }
        public static void RenderField(bool multiLayerRender, string viewmode, string?[,,] layer0)
        {
            if (multiLayerRender == true)
            {
                switch (viewmode)
                {
                    case "front":
                        Render.RenderCubeF(layer0);
                        break;
                    case "top":
                        Render.RenderCubeT(layer0);
                        break;
                    case "right":
                        Render.RenderCubeR(layer0);
                        break;
                    case "back":
                        Render.RenderCubeB(layer0);
                        break;
                    case "underside":
                        Render.RenderCubeU(layer0);
                        break;
                    case "left":
                        Render.RenderCubeL(layer0);
                        break;
                }
            }
            else
            {
                switch (viewmode)
                {
                    case "front":
                        Render.RenderBoxF(layer0, 0);
                        break;
                    case "top":
                        Render.RenderBoxT(layer0, 0);
                        break;
                    case "right":
                        Render.RenderBoxR(layer0, 0);
                        break;
                    case "back":
                        Render.RenderBoxB(layer0, 0);
                        break;
                    case "underside":
                        Render.RenderBoxU(layer0, 0);
                        break;
                    case "left":
                        Render.RenderBoxL(layer0, 0);
                        break;
                }
            }
        }
    }
}



