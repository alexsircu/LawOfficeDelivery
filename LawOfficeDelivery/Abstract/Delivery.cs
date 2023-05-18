using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeDelivery.Abstract
{
    internal abstract class Delivery
    {
        string _name;
        List<Provider> _providers;
        List<Rider> _riders;
        
        public string Name { get => _name; set => _name = value; }
        public List<Provider> Providers { get => _providers; set => _providers = value; }
        public List<Rider> Riders { get => _riders; set => _riders = value; }

        public Delivery(string name) 
        { 
            Name = name;
            Providers = new List<Provider>();
            Riders = new List<Rider>();
        }

        public abstract void AddProvider(Provider provider);
        public void AddRider(Rider rider)
        {
            Riders.Add(rider);
        }

        internal class Rider : Person
        {
        }
    }
}
