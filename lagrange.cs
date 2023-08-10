using System;

namespace lagrangeinterpolation
{
   class GFG
        {
            static double interpolate(double[,] arr1, double xi, int n)
            {
                double result = 0; // Initialize result
                for (int i = 0; i < n; i++)
                {
                    double term = arr1[i, 1];
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            term = term * (xi - arr1[j, 0]) /
                                      (arr1[i, 0] - arr1[j, 0]);
                    }
                    // Add current term to result
                    result += term;
                }
                return result;
            }
            // Driver code
            public static void Main(String[] args)
            {
                MainMenu();
            }
            static void Mp()
            {
                Console.Write("_______________________________________________\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n              LAGRANGE CALCULATOR\n");
                Console.ResetColor();
                Console.Write("_______________________________________________\n");
                Console.Write("\nEnter Number of Points: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Interpolation Points: ");
                double point = Convert.ToDouble(Console.ReadLine());
                int i, j;
                double[,] arr1 = new double[number, 2];
                Console.WriteLine("\nINPUT POINTS");
                for (i = 0; i < number; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("Data Point " + (i + 1) + " - x" + i + " : ", i, j);
                            arr1[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                        if (j == 1)
                        {
                            Console.Write("Data Point " + (i + 1) + " - y" + i + " : ", i, j);
                            arr1[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                }

                Console.Write("\nValue of f(" + point + ") is : " + (double)interpolate(arr1, point, number) + "\n");
            }
            static void AboutAuthor()
            {
                Console.Write("_______________________________________________\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n         About the Author");
                Console.ResetColor();
                Console.Write("_______________________________________________\n");
                Console.WriteLine("\nThis program is created by:\n vitamin-abc");
            }
            static void MainMenu()
            {
                string choice;
                Console.Write("_______________________________________________\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n              LAGRANGE CALCULATOR\n");
                Console.ResetColor();
                Console.Write("_______________________________________________\n");
                Console.Write("\n[1] Lagrange Calculator\n[2] About the Author\n[3] Exit\n");
                Console.Write("\nCHOICE: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Mp();
                        Loop();
                        break;
                    case "2":
                        Console.Clear();
                        AboutAuthor();
                        Loop();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("_______________________________________________\n\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     Exit");
                        Console.ResetColor();
                        Console.Write("_______________________________________________\n");
                        Console.WriteLine("\nThank you for using the program!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("_______________________________________________\n\n");
                        Console.Write($"Error! '{choice}' is an invalid choice. Please select again.".PadRight(Console.WindowWidth));
                        Console.ResetColor();
                        MainMenu();
                        break;
                }
            }
            static void Loop()
            {
                string mainchoice;
                Console.Write("_______________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n[1] Back to Menu [2] Exit program\n");
                Console.ResetColor();
                Console.Write("\nCHOICE: ");
                mainchoice = Console.ReadLine();

                switch (mainchoice)
                {
                    case "1":
                        Console.Clear();
                        MainMenu();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("_______________________________________________\n\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     Exit");
                        Console.ResetColor();
                        Console.Write("_______________________________________________\n");
                        Console.WriteLine("\nThank you for using the program!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Error! '{mainchoice}' is an invalid choice. Please select again.".PadRight(Console.WindowWidth));
                        Console.ResetColor();
                        Loop();
                        break;
                }
            }
        }
    }
