using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObservePattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
           this.subject = subject;
        }

        public ConcreteObserver()
        {
        }



        public override void Update()
        {
            state = subject.State;
        }
    }
}
