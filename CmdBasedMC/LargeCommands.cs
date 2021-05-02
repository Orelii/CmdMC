using System;
using System.Collections.Generic;
using System.Text;

namespace CmdMC
{
    class LargeCommands
    {
        public static void BuildFill(int c1, int c2, int c3, int c4, int c5, int c6, string block, string?[,,] layer)
        {
            switch (c2)
            {
                case 0:
                    c2 = 7;
                    break;
                case 1:
                    c2 = 6;
                    break;
                case 2:
                    c2 = 5;
                    break;
                case 3:
                    c2 = 4;
                    break;
                case 4:
                    c2 = 3;
                    break;
                case 5:
                    c2 = 2;
                    break;
                case 6:
                    c2 = 1;
                    break;
                case 7:
                    c2 = 0;
                    break;
            }
            switch (c5)
            {
                case 0:
                    c5 = 7;
                    break;
                case 1:
                    c5 = 6;
                    break;
                case 2:
                    c5 = 5;
                    break;
                case 3:
                    c5 = 4;
                    break;
                case 4:
                    c5 = 3;
                    break;
                case 5:
                    c5 = 2;
                    break;
                case 6:
                    c5 = 1;
                    break;
                case 7:
                    c5 = 0;
                    break;
            }
            layer[c1, c2, c3] = block;
            layer[c4, c5, c6] = block;
            bool processComplete = false;
            int storagex = c1;
            int storagey = c2;
            int storagez = c3;
            while (processComplete == false)
            {
                layer[storagex, storagey, storagez] = block;
                if (c1 > c4)
                {
                    storagex--;
                    if (storagex == c4 - 1)
                    {
                        storagex = c1;
                        if (c2 > c5)
                        {
                            storagey--;
                            if (storagey == c5 - 1)
                            {
                                storagey = c2;
                                if (c3 > c6)
                                {
                                    storagez--;
                                    if (storagez == c6 - 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                                else
                                {
                                    storagez++;
                                    if (storagez == c6 + 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                            }
                        }
                        else
                        {
                            storagey++;
                            if (storagey == c5 + 1)
                            {
                                if (c3 > c6)
                                {
                                    storagez--;
                                    if (storagez == c6 - 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                                else
                                {
                                    storagez++;
                                    if (storagez == c6 + 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    storagex++;
                    if (storagex == c4 + 1)
                    {
                        storagex = c1;
                        if (c2 > c5)
                        {
                            storagey--;
                            if (storagey == c5 - 1)
                            {
                                storagey = c2;
                                if (c3 > c6)
                                {
                                    storagez--;
                                    if (storagez == c6 - 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                                else
                                {
                                    storagez++;
                                    if (storagez == c6 + 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                            }
                        }
                        else
                        {
                            storagey++;
                            if (storagey == c5 + 1)
                            {
                                storagey = c2;
                                if (c3 > c6)
                                {
                                    storagez--;
                                    if (storagez == c6 - 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                                else
                                {
                                    storagez++;
                                    if (storagez == c6 + 1)
                                    {
                                        storagez = c3;
                                        processComplete = true;

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
