using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PRO
{
    internal class CreditCard
    {
        public ushort cvc { get; set; }
        public int balance { get; set; }
        public static CreditCard operator +(CreditCard balance1, CreditCard balance2) => new CreditCard { balance = balance1.balance + balance2.balance };
        public static CreditCard operator -(CreditCard balance1, CreditCard city2) => new CreditCard { balance = balance1.balance - city2.balance };
        public static bool operator ==(CreditCard cvc1, CreditCard cvc2) => cvc1.cvc == cvc2.cvc;
        public static bool operator !=(CreditCard balance1, CreditCard balance2) => balance1.balance != balance2.balance;
        public static bool operator >(CreditCard balance1, CreditCard balance2) => balance1.balance > balance2.balance;
        public static bool operator <(CreditCard balance1, CreditCard balance2) => balance1.balance < balance2.balance;
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            CreditCard other = (CreditCard)obj;
            return cvc == other.cvc;
        }
        public static void TestCreditCard()
        {
            CreditCard creditCard = new CreditCard() { balance = 2500 };
            CreditCard creditCard2 = new CreditCard() { balance = 250 };
            CreditCard creditCard3 = new CreditCard() {cvc = 134 };
            CreditCard creditCard4 = new CreditCard() { cvc = 134};
            CreditCard creditCard5 = creditCard + creditCard2;
            Console.WriteLine($"Test overload for class CreditCard. \nStart value for class:\nBalance first card = 2500$\nBalance second card = 250$\nCVC first = 134\nCVC second = 134");
            Console.WriteLine($"Result {creditCard.balance} + {creditCard2.balance} = {creditCard5.balance}");
            creditCard5 = creditCard - creditCard2;
            Console.WriteLine($"Result {creditCard.balance} - {creditCard2.balance} = {creditCard5.balance}");
            bool info = creditCard3 == creditCard4;
            Console.WriteLine($"Result {creditCard3.balance} == {creditCard4.balance} is a {info}");
            info = creditCard > creditCard2;
            Console.WriteLine($"Result {creditCard.balance} > {creditCard2.balance} is a {info}");
            info = creditCard < creditCard2;
            Console.WriteLine($"Result {creditCard.balance} < {creditCard2.balance} is a {info}");
            info = creditCard != creditCard2;
            Console.WriteLine($"Result {creditCard3.cvc} != {creditCard4.cvc} is a {info}");
            info = creditCard.Equals(creditCard2);
            Console.WriteLine($"Result method Equals for class CreditCard:\tfirst CVC  == second CVC is a {info}");
        }
    }
}
