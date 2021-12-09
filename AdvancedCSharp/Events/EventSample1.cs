using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Events
{
    public class EventSample1
    {
        class Sender
        {
            public delegate void AmountChangedEventHandler(Object sender, int amount);

            public event AmountChangedEventHandler AmountChangedEvent;
            private int amount { get; set; }
            public int Amount
            {
                get
                {
                    return amount;
                }
                set
                {
                    amount = value;
                    OnAmountChanged();
                }
            }

            private void OnAmountChanged()
            {
                if (AmountChangedEvent != null)
                {
                    AmountChangedEvent(this, amount);
                }
            }
        }

        public class Subscriber
        {
            public void ReactToAmmountChange(Object sender, int amount)
            {
                Console.WriteLine("Subsriber has received amount: {0}", amount);
            }
        }

        public void Run()
        {
            Sender publisher = new Sender();
            
            Subscriber s1 = new Subscriber();
            Subscriber s2 = new Subscriber();

            publisher.AmountChangedEvent += s1.ReactToAmmountChange;
            publisher.AmountChangedEvent += s2.ReactToAmmountChange;

            publisher.Amount = 10;
        }
    }
}
