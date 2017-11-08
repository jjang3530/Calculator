/* Program ID: A3JayJangP2
 * Purpose: Assignment 3 Part 2
 * Revision History:
 * Jay Jang - Mar 3, 2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JayJangP2
{
    class Program
    {
        // Input 1st Number
        public static string Input1stNumber(string input)
        {
            string input1stString;
            decimal firstNumber;
            input1stString = "";
            firstNumber = 0;

            Console.Write(" Please input first number: ");
                input1stString = Console.ReadLine();
                firstNumber = decimal.Parse(input1stString);
                Console.WriteLine("");
            return input1stString;
        }
        // Input Math Operator
        public static string InputMathOperator(string input)
        {
            string mathOperator;
            mathOperator = "";

            Console.Write("Please choose your Math Operator to ");
            Console.Write("be used in the calculation: ");
            mathOperator = Console.ReadLine();
            Console.WriteLine("");
            if (mathOperator != "+" && mathOperator != "-"
                && mathOperator != "*" && mathOperator != "/")
            {
                throw new Exception();
            }
            return mathOperator;
        }
        // Input 2nd Number
        public static string Input2ndNumber(string input)
        {
            string input2ndString;
            decimal secondNumber;
            input2ndString = "";
            secondNumber = 0;

            Console.Write("Please input second number: ");
                input2ndString = Console.ReadLine();
                secondNumber = decimal.Parse(input2ndString);
                Console.WriteLine("");
            return input2ndString;
        }

        // Start Main
        static void Main(string[] args)
        {
            string inputStringFirstNumber;
            string mathOperator;
            string inputStringSecondNumber;
            decimal inputFirstNumber;
            decimal inputSecondNumber;
            decimal answer;
            inputStringFirstNumber = "";
            mathOperator = "";
            inputStringSecondNumber = "";
            inputFirstNumber = 0;
            inputSecondNumber = 0;
            answer = 0;

            do
            {
                Console.WriteLine(" ┌── MINI CAL ──┐");
                Console.WriteLine(" │  7  8  9  /  │");
                Console.WriteLine(" │  4  5  6  *  │");
                Console.WriteLine(" │  1  2  3  -  │");
                Console.WriteLine(" │  0  .  =  +  │");
                Console.WriteLine(" └──────────────┘");

                try
                {
                    inputStringFirstNumber = Input1stNumber("");
                    inputFirstNumber = decimal.Parse(
                        inputStringFirstNumber);
                    Console.WriteLine("Your First number is "
                        + "\'" + inputFirstNumber + "\'");
                    Console.WriteLine("");
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine("");
                    Console.WriteLine(oEx.Message);
                    Console.WriteLine("");
                    Console.WriteLine("Please start program again!");
                    Console.WriteLine("");
                    return;
                }
                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: Invalid String value!"); 
                    Console.WriteLine("");
                    Console.WriteLine("Please start program again!");
                    Console.WriteLine("");
                    return;
                }

                    Console.WriteLine(" ┌── OPERATORS ─┐");
                    Console.WriteLine(" │ + : PLUS     │");
                    Console.WriteLine(" │ - : MINUS    │");
                    Console.WriteLine(" │ * : MULTIPLY │");
                    Console.WriteLine(" │ / : DIVIDE   │");
                    Console.WriteLine(" └──────────────┘");
                try
                {
                    mathOperator = InputMathOperator("");
                    Console.WriteLine("Your Math operator is "
                        + "\'" + mathOperator + "\'");
                    Console.WriteLine("");
                }
                catch(Exception)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: Invalid operator value!"); 
                    Console.WriteLine("");
                    Console.WriteLine("Please start program again!");
                    Console.WriteLine("");
                    return;
                }

                try
                {
                    inputStringSecondNumber = Input2ndNumber("");
                    inputSecondNumber = decimal.Parse(
                        inputStringSecondNumber);
                    Console.WriteLine("Your Second number is "
                        + "\'" + inputSecondNumber + "\'");
                    Console.WriteLine("");
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine("");
                    Console.WriteLine(oEx.Message);
                    Console.WriteLine("");
                    Console.WriteLine("Please start program again!");
                    Console.WriteLine("");
                    return;
                }
                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: Invalid String value!"); 
                    Console.WriteLine("");
                    Console.WriteLine("Please start program again!");
                    Console.WriteLine("");
                    return;
                }

                switch (mathOperator)
                {
                    case "+":
                        answer = inputFirstNumber + inputSecondNumber;
                        Console.WriteLine("Your Calculation : "
                            + inputFirstNumber + " " + mathOperator
                            + " " + inputSecondNumber + " " + "= "
                            + answer);
                        break;
                    case "-":
                        answer = inputFirstNumber - inputSecondNumber;
                        Console.WriteLine("Your Calculation : "
                            + inputFirstNumber + " " + mathOperator
                            + " " + inputSecondNumber + " " + "= "
                            + answer);
                        break;
                    case "*":
                        try
                        {
                            answer = inputFirstNumber * inputSecondNumber;
                        }
                        catch (OverflowException oEx)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(oEx.Message);
                            Console.WriteLine("");
                            Console.WriteLine("Please start program again!");
                            Console.WriteLine("");
                            return;
                        }
                        Console.WriteLine("Your Calculation : "
                            + inputFirstNumber + " " + mathOperator +
                            " " + inputSecondNumber + " " + "= "
                            + answer);
                        break;



                    case "/":
                        try
                        {
                            answer = inputFirstNumber /
                                inputSecondNumber;
                        }
                        catch (DivideByZeroException dZex)
                        {
                            Console.WriteLine(dZex.Message);
                            Console.Write("Error: 0 is not available");
                            Console.WriteLine(" in divide(/) operator");
                            Console.WriteLine("");
                            Console.WriteLine("Please start program again!");
                            Console.WriteLine("");
                            return;
                        }
                        Console.WriteLine("Your Calculation : " 
                            + inputStringFirstNumber + " " + mathOperator + " " 
                            + inputStringSecondNumber + " " + "= " + answer);
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine(" Let's try again!");
                Console.WriteLine("");
            } while (true);

        }
    }
}
