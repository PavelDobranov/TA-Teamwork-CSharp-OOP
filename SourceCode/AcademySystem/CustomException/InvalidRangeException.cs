using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySystem.CustomException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T min;
        private T max;

        public InvalidRangeException(string msg, T min, T max, Exception innerEx)
            : base(msg, innerEx)
        {
            this.Min = min;
            this.Max = max;
        }
        public InvalidRangeException(string msg, T min, T max)
            : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }
        public T Min
        {
            get { return this.min; }
            private set { this.min = value; }
        }

        public T Max
        {
            get { return this.max; }
            private set { this.max = value; }
        }
    }
}
