using System.Data;

namespace pianino22222
{
       internal class Program
       {
            public static void Main(string[] args)
            {
                Console.WriteLine("Привет. Выбери октаву: 5- F1, 6-F2, 7-F3, 8-F4. Для переключения между октавами нажми L, закрыть программу- Z");
                ConsoleKeyInfo octava;
                do
                {
                    int k;
                    octava = Console.ReadKey();

                    if (octava.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Октава 5");
                        massiv();
                    }
                    else if (octava.Key == ConsoleKey.F2)
                    {
                        k = 1;
                        Console.WriteLine("Октава 6");
                        massiv2(k);

                    }
                    else if (octava.Key == ConsoleKey.F3)
                    {
                        k = 2;
                        Console.WriteLine("Октава 7");
                        massiv2(k);

                    }
                    else if (octava.Key == ConsoleKey.F4)
                    {
                        k = 3;
                        Console.WriteLine("Октава 8");
                        massiv2(k);

                    }
                } while (octava.Key != ConsoleKey.Z);
                Console.WriteLine("Пока((((");
            }
            public static double [] massiv ()
            {
                double[] octave = new double[] { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };
                ynikal(octave);
                return octave;
            }
            public static  int[] massiv2(int k)
            {
                int[] octave;
                if (k == 1)
                {
                    octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    zvyki(octave);
                }
                else if (k == 2)
                {
                   octave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                   zvyki(octave);
                }
                else if (k == 3)
                {
                    octave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                    zvyki(octave);
                }
                else
                {
                    octave = new int[] { };
                }
                return octave;
                
            }
            static void zvyki(int[] octave)
            {
                while (true)
                {

                    ConsoleKeyInfo zvyk = Console.ReadKey();
                    if (zvyk.Key == ConsoleKey.L)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выбери актаву еще раз");
                        break;
                    }
                    else if (zvyk.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Пока(((");
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (zvyk.Key)
                        {

                            case ConsoleKey.A:
                                int A = octave[0];
                                Console.Beep(A, 500);
                                break;
                            case ConsoleKey.Q:
                                int q = octave[1];
                                Console.Beep(q, 500);
                                break;
                            case ConsoleKey.S:
                                int s = octave[2];
                                Console.Beep(s, 500);
                                break;
                            case ConsoleKey.W:
                                int w = octave[3];
                                Console.Beep(w, 500);
                                break;
                            case ConsoleKey.D:
                                int d = octave[4];
                                Console.Beep(d, 500);
                                break;
                            case ConsoleKey.E:
                                int e = octave[5];
                                Console.Beep(e, 500);
                                break;
                            case ConsoleKey.F:
                                int f = octave[6];
                                Console.Beep(f, 500);
                                break;
                            case ConsoleKey.R:
                                int r = octave[7];
                                Console.Beep(r, 500);
                                break;
                            case ConsoleKey.G:
                                int g = octave[8];
                                Console.Beep(g, 500);
                                break;
                            case ConsoleKey.H:
                                int h = octave[9];
                                Console.Beep(h, 500);
                                break;
                            case ConsoleKey.T:
                                int t = octave[10];
                                Console.Beep(t, 500);
                                break;
                            case ConsoleKey.J:
                                int j = octave[11];
                                Console.Beep(j, 500);
                                break;

                        }

                    }
                }
            }
            static void ynikal(double[]octave)
            {
                while (true)
                {

                    ConsoleKeyInfo zvykynikal = Console.ReadKey();
                    if (zvykynikal.Key == ConsoleKey.L)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Выбери актаву еще раз");
                        break;
                    }
                    else if (zvykynikal.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Пока((");
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (zvykynikal.Key)
                        {

                            case ConsoleKey.A:
                                double a = octave[0];
                                Console.Beep((int)a, 500);
                                break;
                            case ConsoleKey.Q:
                                double q = octave[1];
                                Console.Beep((int)q, 500);
                                break;
                            case ConsoleKey.S:
                                double s = octave[2];
                                Console.Beep((int)s, 500);
                                break;
                            case ConsoleKey.W:
                                double w = octave[3];
                                Console.Beep((int)w, 500);
                                break;
                            case ConsoleKey.D:
                                double d = octave[4];
                                Console.Beep((int)d, 500);
                                break;
                            case ConsoleKey.E:
                                double e = octave[5];
                                Console.Beep((int)e, 500);
                                break;
                            case ConsoleKey.F:
                                double f = octave[6];
                                Console.Beep((int)f, 500);
                                break;
                            case ConsoleKey.R:
                                double r = octave[7];
                                Console.Beep((int)r, 500);
                                break;
                            case ConsoleKey.G:
                                double g = octave[8];
                                Console.Beep((int)g, 500);
                                break;
                            case ConsoleKey.H:
                                double h = octave[9];
                                Console.Beep((int)h, 500);
                                break;
                            case ConsoleKey.T:
                                double t = octave[10];
                                Console.Beep((int)t, 500);
                                break;
                            case ConsoleKey.J:
                                double j = octave[11];
                                Console.Beep((int)j, 500);
                                break;
                        }
                    }
                }
            }
        }
    }