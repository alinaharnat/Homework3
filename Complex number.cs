using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3
{
    public class ComplexNumber<T>
    {
        private T re;
        private T im;

        public ComplexNumber(T re, T im)
        {
            if (IsNumericType())
            {
                this.re = re;
                this.im = im;
            }
            else
            {
                throw new Exception("Type isn't numeric");
            }
        }

        public T Re
        {
            get { return re; }
        }
        public T Im
        {
            get { return im; }
        }

        public static ComplexNumber<T> operator +(ComplexNumber<T> number1, ComplexNumber<T> number2)
        {
            if (number1.IsNumericType() && number2.IsNumericType())
            {
                dynamic re = Convert.ToDouble(number1.Re) + Convert.ToDouble(number2.Re);
                dynamic im = Convert.ToDouble(number1.Im) + Convert.ToDouble(number2.Im);
                return new ComplexNumber<T>((T)Convert.ChangeType(re, typeof(T)), (T)Convert.ChangeType(im, typeof(T)));
            }
            else
            {
                throw new InvalidOperationException("Types must be numeric");
            }
        }

        public static ComplexNumber<T> operator -(ComplexNumber<T> number1, ComplexNumber<T> number2)
        {
            if (number1.IsNumericType() && number2.IsNumericType())
            {
                var re = Convert.ToDouble(number1.Re) - Convert.ToDouble(number2.Re);
                var im = Convert.ToDouble(number1.Im) - Convert.ToDouble(number2.Im);
                return new ComplexNumber<T>((T)Convert.ChangeType(re, typeof(T)), (T)Convert.ChangeType(im, typeof(T)));
            }
            throw new InvalidOperationException("Types must be numeric");
        }

        public string Print()
        {
            return $"{re} + {im}i";
        }

        private bool IsNumericType()
        {
            return typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(long) ||
                   typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(float);
        }
    }
}
