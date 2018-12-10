﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_ObservePattern
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer o)
        {
            observers.Add(o);
            Notify();
        }

        public void Detach(Observer o)
        {
            observers.Remove(o);
            Notify();
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
            
        }
    }
}