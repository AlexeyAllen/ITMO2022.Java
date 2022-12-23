using System.Reflection;

namespace Calculator
{
    using SimpleCalculator;
    using System;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    public class CalcEngine
    {
        //
        // Operation Constants.
        //
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            ePower = 5,
        }

        //
        // Module-Level Constants
        //

        private static double negativeConverter = -1;
        // TODO: Upgrade the version number to 3.0.1.1
        private static string versionInfo = "Calculator v2.0.1.1";

        //
        // Module-level Variables.
        //

        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }

        //
        // Returns the custom version string to the caller.
        //

        public static string GetVersion()
        {
            return (versionInfo);
        }
        //
        // Called when the Date key is pressed.
        //

        public static string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringAnswer);
        }

        //
        // Called when a number key is pressed on the keypad.
        //

        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        //
        // Called when an operator is selected (+, -, *, /)
        //

        public static void CalcOperation(Operator calcOper)
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = System.Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;
                stringAnswer = "";
                decimalAdded = false;
            }
        }

        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(numHold * negativeConverter);
            }

            return (stringAnswer);
        }

        //
        // Called when the . key is pressed.
        //

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer = stringAnswer + ".";
                else
                    stringAnswer = "0.";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called SquareRoot.
        //

        public static string SquareRoot()
        {
            double squareRootHold;

            if (stringAnswer != "")
            {
                squareRootHold = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(Math.Sqrt(squareRootHold));
            }

            return (stringAnswer);
        }

        //
        // Called SquareRoot.
        //

        public static string Reciprocal()
        {
            double reciprocal;

            if (stringAnswer != "" && stringAnswer != "0")
            {
                reciprocal = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(1 / reciprocal);
            }
            else if (stringAnswer == "")    
            {
                stringAnswer = "¬ведите значение";
            }
            else if (stringAnswer == "0")
            {
                stringAnswer = "Error";
            }

            return (stringAnswer);
        }
        //
        // Called SquareNum.
        //

        public static string SquareNum()
        {
            double squareNum;

            if (stringAnswer != "")
            {
                squareNum = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(Math.Pow(squareNum, 2));
            }
            else
            {
                stringAnswer = "0";
            }

            return (stringAnswer);
        }

        ////
        //// Called Factorial.
        ////

        public static string StringAnswer
        {
            get { return stringAnswer; }
        }

        public static Task<double> FactorialAsync(double x)
        {
            double result = 1;

            return Task.Run(() =>
            {
                for (double i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            });
        }

        public static double Factorial(double x)
        {
            double result = 1;

            for (double i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        //
        // Called SquareNum.
        //

        public static string CubRoot()
        {
            double cubRoot;

            if (stringAnswer != "")
            {
                cubRoot = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(Math.Pow(cubRoot, (double)1 / 3));
            }

            return (stringAnswer);
        }

        //
        // Called when = is pressed.
        //

        public static string CalcEqual()
        {
            bool validEquation = false;

            if (stringAnswer != "")
            {
                secondNumber = System.Convert.ToDouble(stringAnswer);
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        validEquation = true;
                        break;

                    case Operator.ePower:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;

                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                    stringAnswer = System.Convert.ToString(numericAnswer);
            }

            return (stringAnswer);
        }

        //
        // Called Quadratic equation calculation.
        //

        public static void QuadCalc()
        {
            QuadEqForm quadEqForm = new QuadEqForm();
        }

        //
        // Resets the various module-level variables for the next calculation.
        //

        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = "";
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }
    }
}