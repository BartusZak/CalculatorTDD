using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }

        public float Divide(int dividend, int divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0) throw new DivideByZeroException();

            float result = (float)dividend / divisor;
            OnCalculated();
            return result;
        }

        public event EventHandler CalculatedEvent;

        protected virtual void OnCalculated()
        {
            var handler = CalculatedEvent;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
