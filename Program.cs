using System;

namespace BaseConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b1, b2;

            Console.Write("b1=");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("b2=");
            b2 = Convert.ToInt32(Console.ReadLine());

            if (b1 > 10)
            {
                string n;
                n = Console.ReadLine();
                double x = 1;
                int p = 0;
                double m = 0;
                int j = 0;
                bool c = true;
                //verify if it's float
                for (int i = n.Length - 1; i >= 0 && c == true; i--)
                    if (n[i] == '.')
                    {
                        c = false;
                        j = i;
                    }

                if (c == false)
                {
                    for (int i = j-1; i >= 0; i--)
                    {
                        //find out what digit or letter it is and convert it to base 10
                        if (n[i] == 'f')
                            p = 15;
                        else if (n[i] == 'e')
                            p = 14;
                        else if (n[i] == 'd')
                            p = 13;
                        else if (n[i] == 'c')
                            p = 12;
                        else if (n[i] == 'b')
                            p = 11;
                        else if (n[i] == 'a')
                            p = 10;
                        else
                            p = Convert.ToInt32(n[i]) - 48;

                        m = m + (p * x);
                        x = x * b1;
                    }

                    x = 1;
                    x = x / b1;

                    for (int i = j + 1; i < n.Length; i++)
                    {
                        //find out what digit or letter it is and convert it to base 10
                        if (n[i] == 'f')
                            p = 15;
                        else if (n[i] == 'e')
                            p = 14;
                        else if (n[i] == 'd')
                            p = 13;
                        else if (n[i] == 'c')
                            p = 12;
                        else if (n[i] == 'b')
                            p = 11;
                        else if (n[i] == 'a')
                            p = 10;
                        else
                            p = Convert.ToInt32(n[i]) - 48;

                        m = m + (p * x);
                        x = x / b1;
                    }

                    if (b2 == 10)
                        Console.WriteLine(m);
                    else
                    {
                        int intPart = (int)m;
                        double decPart = m - intPart;
                        int[] deci = new int[100];
                        j = 0;
                        while (intPart > 0)
                        {
                            deci[j] = intPart % b2;
                            intPart /= b2;
                            j++;
                        }
                        for (int i = j; i >= 0; i--)
                            Console.Write(deci[i]);
                        Console.Write(".");

                        j = 0;

                        while (decPart!=1)
                        {
                            decPart = decPart * b2;
                            intPart = (int)decPart;
                            deci[j] = intPart;
                            j++;
                        }
                        for (int i = 0; i < j; i++)
                            Console.Write(deci[i]);
                    }
                }
                else
                {
                    for (int i = n.Length - 1; i >= 0; i--)
                    {

                        //find out what digit or letter it is and convert it to base 10
                        if (n[i] == 'f')
                            p = 15;
                        else if (n[i] == 'e')
                            p = 14;
                        else if (n[i] == 'd')
                            p = 13;
                        else if (n[i] == 'c')
                            p = 12;
                        else if (n[i] == 'b')
                            p = 11;
                        else if (n[i] == 'a')
                            p = 10;
                        else
                            p = Convert.ToInt32(n[i]) - 48;

                        m += (p * x);
                        x = x * b1;
                    }
                    if (b2 == 10)
                        Console.WriteLine(m);
                    else
                    {
                        int z = (int)m;
                        int[] deci = new int[100];
                        j = 0;
                        while (z > 0)
                        {
                            deci[j] = z % 2;
                            z /= 2;
                            j++;
                        }
                        for (int i = j; i >=0; i--)
                        {
                            Console.Write(deci[i]);
                        }
                    }

                }

            }
            else
            {
                string n;
                n = Console.ReadLine();
                int c = -1;
                float m = 0;
                for (int i = 0; i < n.Length && c == -1; i++)
                {
                    if (n[i] == '.')
                        c = i;
                }

                if (c == -1)
                {
                    int p = 1;
                    for (int i = n.Length-1; i >= 0; i--)
                    {
                        m = m + (p * ((int)n[i] - 48));
                        p = p * b1;
                    }
                        
                }
                else
                {
                    float p = 1;
                    for (int i = c - 1; i >= 0; i--)
                    {
                        m = m + (p * ((int)n[i] - 48));
                        p = p * b1;
                    }
                    p = (float)1 / b1 ;
                    for (int i = c + 1; i < n.Length; i++)
                    {
                        m = m + (p * ((int)n[i] - 48));
                        p = (float) p / b1;
                    }
                        
                }
                if (b2 == 10)
                    Console.WriteLine(m);
                else
                {
                    if (c == -1)
                    {
                        char[] rest = new char[100];
                        int i = 0;
                        while (m >= 1)
                        {
                            rest[i] = (char) (m % b2 + 48);
                            m /= b2;
                            i++;
                        }
                        for (int j = i - 1; j >= 0; j--)
                        {
                            Console.Write(rest[j]);
                        }
                    }
                    else
                    {
                        int z = (int)m;
                        m = m - z;

                        char[] rest = new char[100];
                        int i = 0;
                        while (z >= 1)
                        {
                            rest[i] = (char)(z % b2 + 48);
                            z /= b2;
                            i++;
                        }
                        for (int j = i - 1; j >= 0; j--)
                        {
                            Console.Write(rest[j]);
                        }
                        Console.Write(".");

                        i = 0;
                        int c2 = 0;
                        while (c2 == 0)
                        {
                            m = m * b2;
                            z = (int)m;
                            rest[i] = (char)(z + 48);
                            if (z == m)
                                c2 = 1;
                            else
                            {
                                m = m - z;
                            }
                            i++;
                        }
                        for (int j = i - 1; j >= 0; j--)
                            Console.Write(rest[j]);
                    }
                }
            }
        }
    }
}