using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            int m = 1;

            f1(5, 4);

            sum(3, 5, 12);

            A(0, 1);

            shoa(5);

            ave(2, 12, 14);

            reverse(524);

            factorial(12);

            esm("fatemeh");

            B(0);


            Console.WriteLine("enter your average");
            int input = int.Parse(Console.ReadLine());
            if (input >= 15)
            {
                Console.WriteLine("your average is good");
            }
            else
            {
                Console.WriteLine(" your average is bad");
            }



            Console.WriteLine("enter your number one");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your operand(+,-)");
            char operand = char.Parse(Console.ReadLine());
            Console.WriteLine("enter your number two");
            int num3 = int.Parse(Console.ReadLine());
            switch (operand)
            {
                case '+':
                    int sumnum23 = num2 + num3;
                    Console.WriteLine(sumnum23);
                    break;
                case '-':
                    int sumnumkk = num2 - num3;
                    Console.WriteLine(sumnumkk);
                    break;
            }



            Console.WriteLine("enter your salary");
            int salary = int.Parse(Console.ReadLine());
            if (salary <= 700000)
            {
                double tax = 0.01 * salary;
                Console.WriteLine(tax);
            }
            else
            {
                double tax = 0.02 * salary;
                Console.WriteLine(tax);
            }



            Console.ReadKey();
        }




        static void f1(int x, int y)
        {

            int mul1 = 0;
            int mul2 = 0;
            mul1 = x * x;
            mul2 = y * y;
            int sum = mul1 + mul2;
            Console.WriteLine(sum);
        }


        static void sum(int x, int y, int z)
        {
            int sum = x + y + z;
            int average1 = sum / 3;
            {
                Console.WriteLine(average1);
            }
        }


        static void A(int x1, int x2)
        {
            int x3;
            for (int i = 0; i < 5; i++)
            {
                x3 = x1 + x2;
                x1 = x2;
                x2 = x3;
            }
            Console.WriteLine(x1);
        }



        static void shoa(int r)
        {
            double result = 3.14 * r * r;
            double output = 2 * 3.14 * r;
            Console.WriteLine(output);
            Console.WriteLine(result);
        }



        static void ave(int x, int y, int z)
        {
            int sum = x + y + z;
            int average1 = sum / 3;
            {
                Console.WriteLine(average1);
            }
        }



        static void reverse(int d)
        {
            int hh = 0;
            int sum5 = 0;
            while (d != 0)
            {
                hh = d % 10;
                sum5 = sum5 * 10;
                sum5 = sum5 + d;
                d = d / 10;
            }
            {
                Console.WriteLine(sum5);
            }
        }



        static void factorial(int num)
        {
            int m = 1;
            for (int i = 1; i < num; i++)
            {

                m = m * i;
            }
            Console.WriteLine(m);
        }



        static void esm(string name)
        {
            for (int k = 0; k < name.ToArray().Length; k++)
            {
                if (name == "a" || name == "u" || name == "o" || name == "i" || name == "o")
                {
                    k++;
                }
                int num1 = k++;
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("girl");
                }
                else if (num1 % 2 == 1)
                {
                    Console.WriteLine("boy");
                }
            }
        }



        static void B(int sum1)
        {
            int sumTemp = sum1;
            for (int i = 1; i <= 100; i++)
            {
                sumTemp += i;
            }
            Console.WriteLine(sumTemp);
        }

    }
}

