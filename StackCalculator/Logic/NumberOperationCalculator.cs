using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator.Logic
{
    class NumberOperationCalculator : OperationCalculator
    {
        private Stack<StackValue> stack;

        public NumberOperationCalculator(Stack<StackValue> stack)
        {
            this.stack = stack;
        }

        public void Add()
        {
            if (stack.Count < 2) return;

            string numberOneText = stack.Pop().Value;
            string numberTwoText = stack.Pop().Value;

            int numberOne = int.Parse(numberOneText);
            int numberTwo = int.Parse(numberTwoText);

            int operationResult = numberOne + numberTwo;

            stack.Push(new StackValue(operationResult));
        }
    }
}
