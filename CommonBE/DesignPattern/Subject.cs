using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBE.DesignPattern
{
    public abstract class Subject<T> where T : IObserver
    {
        public string name;

        protected abstract List<T> observers { get; set; }
        public void Attach(T observer)
        {
            observers.Add(observer);
        }
        public void Detach(T observer)
        {
            observers.Remove(observer);
        }
        public Subject(string Name)
        {
            observers = new List<T>();

            name = Name;
        }
        public Subject()
        {
            observers = new List<T>();
        }
    }
}
