using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownBotForm
{
    public class NumberGuesser
    {
        public NumberGuesser()
        {

        }

        public List<int> ParseNumbers(string input)
        {
            List<int> numbers = new List<int>();
            try
            {                
                string[] words = input.Split(',');
                foreach (string word in words)
                {
                    numbers.Add(int.Parse(word));
                }
            }
            catch
            {
                //input not in correct format
            }
            
            return numbers;            
        }
    }

    public class NumberResult
    {
        public List<int> numbers;
        public List<MathOperation> operations;
        public int result = 0;

        public NumberResult(List<int> numbers, List<MathOperation> operations)
        {
            this.numbers = numbers;
            this.operations = operations;
            this.result = GetResult(numbers, operations);
        }

        public string GetOperationsString()
        {
            string s = "";

            for (int i = 0; i < operations.Count; i++)
            {
                s += numbers[i].ToString() + " ";
                s += GetOperatorString(operations[i]) + " ";
            }
            s += numbers[numbers.Count - 1].ToString();

            return s;
        }

        private string GetOperatorString(MathOperation operation)
        {
            switch (operation)
            {
                case MathOperation.Add:
                    return "+";

                case MathOperation.Subtract:
                    return "-";

                case MathOperation.Multiply:
                    return "*";

                case MathOperation.Divide:
                    return "/";
            }

            return "";
        }

        private int EvaluateOperation(int a, int b, MathOperation operation)
        {
            switch (operation)
            {
                case MathOperation.Add:
                    return a + b;

                case MathOperation.Subtract: 
                    return a - b;

                case MathOperation.Multiply:
                    return a * b;

                case MathOperation.Divide:
                    return a / b;
            }

            //error
            return int.MinValue;
        }

        private int GetResult(List<int> numbersIn, List<MathOperation> operationsIn)
        {
            if (operationsIn.Count == 0)
            {
                return numbersIn[0];
            }
            else
            {
                numbersIn[1] = EvaluateOperation(numbersIn[0], numbersIn[1], operationsIn[0]);
                numbersIn.RemoveAt(0);
                operationsIn.RemoveAt(0);
                return GetResult(numbersIn, operationsIn);
            }
        }
    }

    public enum MathOperation
    {
        Add = 0,
        Subtract = 1,
        Multiply = 2,
        Divide = 3
    }
}
