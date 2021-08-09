﻿using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class CareTaker
    {
        private List<Memento> ledTvList = new List<Memento>();

        public void AddMemento(Memento m)
        {
            ledTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }

        public Memento GetMemento(int index)
        {
            return ledTvList[index];
        }
    }
}