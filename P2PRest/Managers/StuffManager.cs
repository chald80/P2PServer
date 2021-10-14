using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleP2PRest.Models;

namespace SimpleP2PRest.Managers
{
    public class StuffManager
    {
        private static readonly List<Stuff> Data = new List<Stuff>
        {
            new Stuff {Name = "hop", Peer = "Bob", FileEndPoint = "192.20.31.31"},
            new Stuff {Name = "hophop", Peer = "Bobo", FileEndPoint = "191.20.31.31"},
        };

        public List<Stuff> GetAll()
        {
            return new List<Stuff>(Data);
        }

        public List<Stuff> GetByName(string name)
        {
            return Data.FindAll(s => s.Name == name);
        }

        public Stuff Add(Stuff newStuff)
        {
            Data.Add(newStuff);
            return newStuff;
        }

        public Stuff Delete(string name)
        {
            Stuff stuff = Data.Find(p1 => p1.Name == name);
            if (stuff == null) return null;
            Data.Remove(stuff);
            return stuff;
        }

        public Stuff Update(string name, Stuff updates)
        {
            Stuff stuff = Data.Find(p1 => p1.Name == name);
            if (stuff == null) return null;
            stuff.Name = updates.Name;
            stuff.Peer = updates.Peer;
            stuff.FileEndPoint = updates.FileEndPoint;
            return stuff;
        }
    }
}
