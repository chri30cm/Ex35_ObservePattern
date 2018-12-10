using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObservePattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;
        

        private int state = 0;
        public int State
        {
            get;
            set;
        }

        public ConcreteObserver(ConcreteSubject subject)
        {
           _subject = subject;
        }

        public override void Update()
        {
            
        }
    }
}
