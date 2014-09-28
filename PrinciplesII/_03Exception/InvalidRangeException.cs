namespace _03Exception
{
    using System;

    public class InvalidRangeException<T> : ApplicationException where T : IComparable
    {
        private T start;
        private T end;
        private string message;

        public InvalidRangeException(T start, T end) : base()
        {
            this.start = start;
            this.end = end;
            this.message = "Out of range " + start.ToString() + " and " + end.ToString();
        }

        public T Start
        {
            get
            {
                return this.start;
            }

            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            set
            {
                this.end = value;
            }
        }
        
        public override string Message
        {
            get
            {
                return this.message;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + "  " + this.message;
        }
    }
}
