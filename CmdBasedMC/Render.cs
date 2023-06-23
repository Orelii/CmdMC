using System;

namespace CmdMC
{
    class Render
    {
        public static void RenderBoxF(string?[,,] layer0, int layer)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 0; i != 8; i++)
                {
                    ReplaceType(layer0[i, digit2, layer]);
                    if (i == 7)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeF(string?[,,] layer0)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 0; i != 8; i++)
                {
                    RenderBehindBlocksF(i, digit2, layer0);
                    if (i == 7)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderBoxT(string?[,,] layer0, int layer)
        {
            int digit2 = 7;
            while (digit2 > -1)
            {
                for (int i = 0; i != 8; i++)
                {
                    ReplaceType(layer0[i, layer, digit2]);
                    if (i == 7)
                    {
                        digit2--;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeT(string?[,,] layer0)
        {
            int digit2 = 7;
            while (digit2 > -1)
            {
                for (int i = 0; i != 8; i++)
                {
                    RenderBehindBlocksT(i, digit2, layer0);
                    if (i == 7)
                    {
                        digit2--;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderBoxR(string?[,,] layer0, int layer)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 0; i != 8; i++)
                {
                    ReplaceType(layer0[layer, digit2, i]);
                    if (i == 7)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeR(string?[,,] layer0)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 0; i != 8; i++)
                {
                    RenderBehindBlocksR(digit2, i, layer0);
                    if (i == 7)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderBoxB(string?[,,] layer0, int layer)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 7; i != -1; i--)
                {
                    ReplaceType(layer0[i, digit2, layer]);
                    if (i == 0)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeB(string?[,,] layer0)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 7; i != -1; i--)
                {
                    RenderBehindBlocksB(i, digit2, layer0);
                    if (i == 0)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderBoxU(string?[,,] layer0, int layer)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 0; i != 8; i++)
                {
                    ReplaceType(layer0[i, layer, digit2]);
                    if (i == 7)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeU(string?[,,] layer0)
        {
            int digit2 = 7;
            while (digit2 > -1)
            {
                for (int i = 0; i != 8; i++)
                {
                    RenderBehindBlocksU(i, digit2, layer0);
                    if (i == 7)
                    {
                        digit2--;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderBoxL(string?[,,] layer0, int layer)
        {
            int digit2 = 0;
            while (digit2 < 8)
            {
                for (int i = 7; i != -1; i--)
                {
                    ReplaceType(layer0[layer, digit2, i]);
                    if (i == 0)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void RenderCubeL(string?[,,] layer0)
        {
            int digit2 = 1;
            while (digit2 < 8)
            {
                for (int i = 7; i != -1; i--)
                {
                    RenderBehindBlocksL(digit2, i, layer0);
                    if (i == 0)
                    {
                        digit2++;
                        break;
                    }
                }
                Console.WriteLine("");
            }
        }
        private static void RenderBehindBlocksF(int num1, int num2, string?[,,] layer0)
        {
            for (int i = 0; i < 8; i++)
            {
                if (layer0[num1, num2, i] == "air")
                {
                    layer0[num1, num2, i] = null;
                }
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
            for (int i = 0; i < 8; i++)
            {
                if (layer0[num1, i, num2] == "air")
                {
                    layer0[num1, i, num2] = null;
                }
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
            for (int i = 0; i < 8; i++)
            {
                if (layer0[i, num1, num2] == "air")
                {
                    layer0[i, num1, num2] = null;
                }
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
            for (int i = 7; i < -1; i--)
            {
                if (layer0[num1, num2, i] == "air")
                {
                    layer0[num1, num2, i] = null;
                }
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
            for (int i = 7; i < -1; i--)
            {
                if (layer0[num1, i, num2] == "air")
                {
                    layer0[num1, i, num2] = null;
                }
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
            for (int i = 0; i < 8; i++)
            {
                if (layer0[i, num1, num2] == "air")
                {
                    layer0[i, num1, num2] = null;
                }
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