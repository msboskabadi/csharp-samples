using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Money
    {
        private readonly int _value;
        public Money(int value)
        {
            _value = value;
        }
        public int Value { get { return _value; } }

        public int Add(Money inputMoney)
            => _value + inputMoney.Value;   

        public static Money operator +(Money right, Money left)=>
            new Money(left.Value + right.Value);

        public static Money operator -(Money right, Money left) =>
            new Money(left.Value - right.Value);

    }
}
