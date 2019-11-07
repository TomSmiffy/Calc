//Program: calling sub-procedures and passing parameters //Programmer: Trevor Till
//Date: autumn 2017, V1.0
//Purpose: to demonstrate passing parameters to
//a sub-procedure
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProceduralCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local variables, local to static void Main()
            int iNuml = 0;
            int iNum2 = 0;
            int iResult = 0;
            string cOption;
            Console.WriteLine("Menu");
            Console.WriteLine("A to add");
            Console.WriteLine("M to multiply");
            Console.WriteLine("D to divide");
            Console.WriteLine("S to subtract");
            Console.WriteLine("Please enter your choice: ");
            cOption = (Console.ReadLine());
            cOption = cOption.ToUpper();
            Console.WriteLine("Enter first number: ");
            iNuml = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            iNum2 = int.Parse(Console.ReadLine());
            //Calls the calc() sub-procedure and passes parameters //calc() returns the value and
            //it is assigned it to iResult
            iResult = calc(iNuml, iNum2, cOption);
            Console.WriteLine(iResult);
            Console.ReadLine();
        }
        static int calc(int iFirstNum, int iSecondNum, string cMenuChoice)
        {
            switch (cMenuChoice)
            {
                             case "A":
                return iFirstNum + iSecondNum;
            case "M":
                return iFirstNum * iSecondNum;
            case "D":
                return iFirstNum / iSecondNum;
            case "5":
                return iFirstNum - iSecondNum;
            default:
                return 0;
            }//End of switch
        }//End of calc()
    }//End of class
}//End of namespace
