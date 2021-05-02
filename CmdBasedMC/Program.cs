using System;

namespace CmdMC
{
    class Program
    {
        static string?[,,] layer0 = new string[8, 8, 8];
        static bool multiLayerRender = true;
        static string viewmode = "front";

        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();
            // close command
            if (inputCommand.StartsWith("close"))
            {
                System.Environment.Exit(69420);
            }
            // place command
            else if (inputCommand.StartsWith("place"))
            {
                try
                {
                    int grid1 = Convert.ToInt32(inputCommand.Substring(6, 1));
                    int grid2 = Convert.ToInt32(inputCommand.Substring(8, 1));
                    int grid3 = Convert.ToInt32(inputCommand.Substring(10, 1));
                    string blockSelection = (inputCommand.Substring(12));
                    blockSelection.ToLower();
                    if (grid1 > 0 && grid1 < 9)
                    {
                        grid1--;
                        if (grid2 > 0 && grid2 < 9)
                        {
                            grid2--;
                            switch (grid2)
                            {
                                case 0:
                                    grid2 = 7;
                                    break;
                                case 1:
                                    grid2 = 6;
                                    break;
                                case 2:
                                    grid2 = 5;
                                    break;
                                case 3:
                                    grid2 = 4;
                                    break;
                                case 4:
                                    grid2 = 3;
                                    break;
                                case 5:
                                    grid2 = 2;
                                    break;
                                case 6:
                                    grid2 = 1;
                                    break;
                                case 7:
                                    grid2 = 0;
                                    break;
                            }
                            if (grid3 > 0 && grid3 < 9)
                            {
                                grid3--;
                                if (blockSelection == "brick" || blockSelection == "stone" || blockSelection == "grass" || blockSelection == "wool" || blockSelection == "gold" || blockSelection == "fabric" || blockSelection == "water" || blockSelection == "lapis" || blockSelection == "air" || blockSelection == "realgar" || blockSelection == "kyanite" || blockSelection == "amethyst")
                                {
                                    layer0[grid1, grid2, grid3] = blockSelection;
                                    Render.RenderField(multiLayerRender, viewmode, layer0);

                                }
                                else
                                {
                                    Console.WriteLine("Invalid block type.");
                                    Console.WriteLine("Valid types:");
                                    Console.WriteLine("");
                                    Render.BrickColour("Brick ");
                                    Render.StoneColour("Stone ");
                                    Render.GrassColour("Grass ");
                                    Render.WoolColour("Wool ");
                                    Render.GoldColour("Gold ");
                                    Render.FabricColour("Fabric ");
                                    Render.WaterColour("Water ");
                                    Render.LapisColour("Lapis ");
                                    Console.WriteLine("");
                                    Render.RealgarColour("Realgar ");
                                    Render.KyaniteColour("Kyanite ");
                                    Render.AmethystColour("Amethyst");
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                Console.WriteLine("One or more of your coordinates are invalid. (1-8)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("One or more of your coordinates are invalid. (1-8)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("One or more of your coordinates are invalid. (1-8)");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            // layer command
            else if (inputCommand.StartsWith("layer"))
            {
                try
                {
                    int viewlayer = Convert.ToInt32(inputCommand.Substring(6, 1));
                    if (viewlayer > 0 && viewlayer < 9)
                    {
                        viewlayer--;
                        if (viewmode == "front")
                        {
                            Render.RenderBoxF(layer0, viewlayer);
                            Console.WriteLine("");
                        }
                        else if (viewmode == "top")
                        {
                            Render.RenderBoxT(layer0, viewlayer);
                            Console.WriteLine("");
                        }
                        else if (viewmode == "right")
                        {
                            Render.RenderBoxR(layer0, viewlayer);
                            Console.WriteLine("");
                        }
                        else if (viewmode == "back")
                        {
                            Render.RenderBoxB(layer0, viewlayer);
                            Console.WriteLine("");
                        }
                        else if (viewmode == "underside")
                        {
                            Render.RenderBoxU(layer0, viewlayer);
                            Console.WriteLine("");
                        }
                        else if (viewmode == "left")
                        {
                            Render.RenderBoxL(layer0, viewlayer);
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("An invalid layer view was entered. (1-8)");
                        Main(args);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            }
            // rendertype command
            else if (inputCommand.StartsWith("rendertype"))
            {
                if (multiLayerRender == true)
                {
                    multiLayerRender = false;
                    Render.RenderField(multiLayerRender, viewmode, layer0);
                    Console.WriteLine("Switched rendering type to single layer.");
                }
                else
                {
                    multiLayerRender = true;
                    Console.WriteLine("Switched rendering type to multi layer.");
                    Render.RenderField(multiLayerRender, viewmode, layer0);
                }
            }
            // view command
            else if (inputCommand.StartsWith("view"))
            {
                try
                {
                    string input = inputCommand.Substring(5);
                    switch (input)
                    {
                        case "front":
                            Console.WriteLine("Changed perspective to the front.");
                            viewmode = "front";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeF(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxF(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                        case "top":
                            Console.WriteLine("Changed perspective to the top.");
                            viewmode = "top";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeT(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxT(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                        case "right":
                            Console.WriteLine("Changed perspective to the right.");
                            viewmode = "right";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeR(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxR(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                        case "back":
                            Console.WriteLine("Changed perspective to the back.");
                            viewmode = "back";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeB(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxB(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                        case "bottom":
                            Console.WriteLine("Changed perspective to the underside.");
                            viewmode = "underside";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeU(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxU(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                        case "left":
                            Console.WriteLine("Changed perspective to the left.");
                            viewmode = "left";
                            if (multiLayerRender == true)
                            {
                                Render.RenderCubeL(layer0);
                                Console.WriteLine("");
                            }
                            else
                            {
                                Render.RenderBoxL(layer0, 0);
                                Console.WriteLine("");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            // fill command
            else if (inputCommand.StartsWith("fill"))
            {
                try
                {
                    int coord1 = Convert.ToInt32(inputCommand.Substring(5, 1));
                    int coord2 = Convert.ToInt32(inputCommand.Substring(7, 1));
                    int coord3 = Convert.ToInt32(inputCommand.Substring(9, 1));
                    int coord4 = Convert.ToInt32(inputCommand.Substring(11, 1));
                    int coord5 = Convert.ToInt32(inputCommand.Substring(13, 1));
                    int coord6 = Convert.ToInt32(inputCommand.Substring(15, 1));
                    string fillBlock = inputCommand.Substring(17);
                    if (coord1 > 0 && coord1 < 9)
                    {
                        coord1--;
                        if (coord2 > 0 && coord2 < 9)
                        {
                            coord2--;
                            if (coord3 > 0 && coord3 < 9)
                            {
                                coord3--;
                                if (coord4 > 0 && coord4 < 9)
                                {
                                    coord4--;
                                    if (coord5 > 0 && coord5 < 9)
                                    {
                                        coord5--;
                                        if (coord6 > 0 && coord6 < 9)
                                        {
                                            coord6--;
                                            LargeCommands.BuildFill(coord1, coord2, coord3, coord4, coord5, coord6, fillBlock, layer0);
                                            Render.RenderField(multiLayerRender, viewmode, layer0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            // help command
            else if (inputCommand.StartsWith("help"))
            {
                Console.WriteLine("close");
                Console.WriteLine("Closes the console.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("place (x) (y) (z) (block)");
                Console.WriteLine("Places a block at the specified coordinates. Coordinates go from 1 to 8.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("layer (1-8)");
                Console.WriteLine("Displays a cross section of the build at the specified layer.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("rendertype");
                Console.WriteLine("Toggles between multi layer rendering and single layer rendering.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("view (side)");
                Console.WriteLine("Switches the perspective to a different side. The sides include front (default), top, right, back, bottom, and left.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("fill (x1) (y1) (z1) (x2) (y2) (z2) (block)");
                Console.WriteLine("Fills in a rectangular area from the first location to the second.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("help");
                Console.WriteLine("Displays a list of commands and how to use them.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("save");
                Console.WriteLine("Saves the current build to a .json file.");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("load (number)");
                Console.WriteLine("Loads the specified file.");
/*                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("listsaves");
                Console.WriteLine("Lists all saved builds.");
*/            }
            // save command
            else if (inputCommand.StartsWith("save"))
            {
                LargeCommands.SaveFile(layer0, multiLayerRender, viewmode);
            }
            // load command
            else if (inputCommand.StartsWith("load"))
            {
                try
                {
                    layer0 = LargeCommands.LoadFile(layer0, Convert.ToInt32(inputCommand.Substring(5)));
                    Render.RenderField(multiLayerRender, viewmode, layer0);
                    Console.WriteLine("Successfully loaded save.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
/*            else if (inputCommand.StartsWith("listsaves"))
            {
                LargeCommands.SaveList();
            }
            else if (inputCommand.StartsWith("delete"))
            {
                if (File.Exists(@"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + Convert.ToInt32(inputCommand.Substring(7)) + ".json"))
                {
                    File.Delete(@"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + Convert.ToInt32(inputCommand.Substring(7)) + ".json");
                    int numberlol3 = 1;
                    repeat(numberlol3, inputCommand);
                    static void repeat(int numberlol3, string inputCommand)
                    {
                        if (File.Exists(@"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + numberlol3 + ".json"))
                        {
                            numberlol3++;
                            repeat(numberlol3, inputCommand);
                        }
                        else if (File.Exists(@"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + numberlol3 + 1 + ".json"))
                        {
                            File.Move(@"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + numberlol3 + 1 + ".json", @"c:\Users\Oreli\source\repos\CmdBasedMC\CmdBasedMC\saves\save" + numberlol3 + ".json");
                            repeat(numberlol3, inputCommand);
                        }
                        else
                        {
                            Console.WriteLine("Successfully deleted save " + Convert.ToInt32(inputCommand.Substring(7)) + ".");
                        }
                    }
                }
            }
*/            Main(args);

        }

    }
}


