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
            throw new NotImplementedException();
        }

        public event EventHandler CalculatedEvent;

        protected virtual void OnCalculated()
        {
            var handler = CalculatedEvent;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
