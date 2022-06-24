using System;
public class Test
{

    public static void Main()
    {

        string input = Console.In.ReadLine();
        int cases;
        cases = Convert.ToInt32(input);
        int[][,] outputs = new int[cases][,];


        for (int i = 0; i < cases; i++)
        {
            input = Console.In.ReadLine();
            string[] tokens = input.Split();

            int n = Convert.ToInt32(tokens[0]);
            int m = Convert.ToInt32(tokens[1]);
            int[,] arrayInput = new int[n, m];

            for (int j = 0; j < n; j++)
            {
                input = Console.In.ReadLine();
                char[] bits = input.ToCharArray();

                for (int k = 0; k < m; k++)
                {
                    if (Convert.ToInt32(input[k]) == 48)
                    {
                        arrayInput[j, k] = 0;
                    }
                    else
                        arrayInput[j, k] = 1;

                }

            }

           

            int[,] actual = arrayInput;

            int[,] output = new int[n, m];

            for (int l = 0; l < n; l++)
            {

                for (int o = 0; o < m; o++)
                {


                    if (actual[l, o] == 1)
                        output[l, o] = 0;
                    else
                    {

                        int close = 999;

                        for (int p = 0; p < n; p++)
                        {

                            for (int q = 0; q < m; q++)
                            {

                                if (actual[p, q] == 1)
                                {

                                    int distance;
                                    int valueI = p - l;
                                    int valueJ = q - o;
                                    if (valueI < 0)
                                        valueI = valueI * (-1);
                                    if (valueJ < 0)
                                        valueJ = valueJ * (-1);
                                    distance = valueI + valueJ;



                                    int near = distance;
                                    if (near < close)
                                    {
                                        close = near;
                                    }
                                }
                            }
                        }

                        output[l, o] = close;
                       
                    }
                }
            }



            outputs[i] = output;



        }

        for (int i = 0; i < outputs.Length; i++)
        {
            int[,] print = outputs[i];
            for (int j = 0; j < print.GetLength(0); j++)
            {
                for (int k = 0; k < print.GetLength(1); k++)
                {
                    Console.Out.Write(print[j, k]);

                }
                Console.Out.WriteLine();
            }

        }


    }
}