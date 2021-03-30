using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            } else if(number2 < number1)
            {
                return number2;
            } else
            {
                Console.WriteLine("Nilainya sama");
                return 0;
            }
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            
            if (number1 < number2 && number1 < number3)
            {
                return number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                return number2;
            }
            else if (number3 < number1 && number3 < number2)
            {
                return Convert.ToInt32(number3);
            }
            else
            {
                Console.WriteLine("Nilainya Sama");
                return 0;
            }
        }
        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else if (number2 > number1)
            {
                return number2;
            }
            else
            {
                Console.WriteLine("Nilainya sama");
                return 0;
            }
        }
        public int FindMaximum(int number1, int number2, float number3)
        {

            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                return Convert.ToInt32(number3);
            }
            else
            {
                Console.WriteLine("Nilainya Sama");
                return 0;
            }
        }
    }
}
