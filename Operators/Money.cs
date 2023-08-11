using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Wallet
    {
        private readonly List<Money> moneys = new();

        public Money this[int index, string nationalCode]
        {
            get
            {
                //var res = moneys.Wh;
                return moneys[index];
            }
            set
            {
                if(moneys.Count > index)
                    moneys[index] = value;  
                else
                {
                    moneys.Add(value);  
                }
            }
        }
    }
    public class Money : IEquatable<Money>
    {
        private readonly int _value;
        public Money(int value)
        {
            _value = value;
        }
        public int Value { get { return _value; } }

        public int Add(Money inputMoney)
            => _value + inputMoney.Value;

        public bool Equals(Money? other)
        {
            return this == other;
        }

        public override bool Equals(object? obj)
        {
            return this == (obj as Money);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public static Money operator +(Money right, Money left)=>
            new Money(left.Value + right.Value);

        public static Money operator -(Money right, Money left) =>
            new Money(left.Value - right.Value);

        public static bool operator == (Money right, Money left) =>
            left.Value == right.Value;

        public static bool operator  != (Money right, Money left) =>
            !(left.Value == right.Value);


    }
}
