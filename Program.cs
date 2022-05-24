using System;

namespace Calc
{
    public struct Calculator
    {
        public double Sum { get; set; }                     //properties
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        
        public double Add()                                 //add function
        {
            Sum = FirstNumber + SecondNumber;
            return Sum;
        }
        public double Subtract()                            //substruct function
        {
            Sum = FirstNumber - SecondNumber;
            return Sum;
        }
        public double Multiply()                            //multiply function
        {
            Sum = FirstNumber * SecondNumber;
            return Sum;
        }
        public double Divide()                              //divide function
        {
            Sum = FirstNumber / SecondNumber;
            return Sum;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t*** Miniräknare ***");
            Calculate();
        }
        private static void Calculate()
        {
            Calculator myCalc = new Calculator();

            Console.Write("Skriva första tal: ");
            
            bool validation ;                               
            for (int i = 0; i < 1; i++)                             // do loop for helping to user to write only number
            {
                try
                {
                    double inputFirst = double.Parse(Console.ReadLine());
                    myCalc.FirstNumber = inputFirst;                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Endast tal.Skriva igen:");
                    i--;                   
                }
            } 
        dl1:
            Console.Write("Skriva operator: ");                  //operator message to write +, -, *, /
            string oper;
            do
            {
                oper = Console.ReadLine();
                if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
                {
                    validation = true;
                }
                else 
                { 
                    Console.WriteLine("Skriva bara: + , - , * , /");                   
                    validation = false;
                }
            } while (!validation);

            Console.Write("Skriva andra tal: ");
            for (int i = 0; i < 1; i++)                                                  // for loop for helping to user to write only number
            {
                try
                {
                    double inputSecond = int.Parse(Console.ReadLine());
                    myCalc.SecondNumber = inputSecond;                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Endast tal.Skriva igen:");
                    i--;
                }                
            }

            if (oper == "+")                                     //operator function according to terms
            {
                myCalc.Add();
                Console.WriteLine("{0} + {1} = {2}", myCalc.FirstNumber, myCalc.SecondNumber, myCalc.Sum);
            }
            if (oper == "-")
            {
                myCalc.Subtract();
                Console.WriteLine("{0} - {1} = {2}", myCalc.FirstNumber, myCalc.SecondNumber, myCalc.Sum);
            }
            if (oper == "*")
            {
                myCalc.Multiply();
                Console.WriteLine("{0} * {1} = {2}", myCalc.FirstNumber, myCalc.SecondNumber, myCalc.Sum);
            }
            if (oper == "/")
            {
                myCalc.Divide();
                Console.WriteLine("{0} / {1} = {2}", myCalc.FirstNumber, myCalc.SecondNumber, myCalc.Sum);
            }

            Console.Write("Första tal är: {0}\n", myCalc.Sum);   //sum will be first number 
            Console.Write("\t\t\tTryck på knapp c:Rensa | x:Stänga programmet | Valfri knapp:Försäta  ");

            string inputKey = Console.ReadLine();                // other altenative to go ahead
            if (inputKey == "x")
            {
                Environment.Exit(0);              
            }
            if (inputKey == "c")
            {
                Run();
            }
            else
            {
                myCalc.FirstNumber = myCalc.Sum;
                goto dl1;                                        //transfering program to uper row if user didn't enter 'c' or 'x'
            }            
        }
    }
}
