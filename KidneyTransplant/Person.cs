using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Person
    {
        public string Name { get; set; }
        public Kidney[] Kidneys;

        public Person(string name, bool isSick)
        {
           Name = name;
           Kidneys = new Kidney[2];
           if(isSick)
           {
                InitUnhealthyKidneys();
           }
           else
           {
                InitHealthyKidneys();
           }
        }

        private void InitUnhealthyKidneys()
        {
            Kidneys[0] = new Kidney(false);
            Kidneys[1] = new Kidney(false);
            Console.WriteLine($"{Name} was born and is dying! HELP");
        }
        private void InitHealthyKidneys()
        {
            Kidneys[0] = new Kidney(true);
            Kidneys[1] = new Kidney(true);
            Console.WriteLine($"{Name} was born and has two healthy kidneys!");
        }

        public void GiveKidney(Person receiver)
        {
            Console.WriteLine($"{Name} is now donating his kidney to {receiver.Name}");
            receiver.ReceiveKidney(Kidneys[0]);
            Kidneys[0] = null;
            Console.WriteLine($"{Name} now only has 1 functioning Kidney left");
        }

        public void ReceiveKidney(Kidney donatedKidney)
        {
            Console.WriteLine($"{Name} is now receiving his kidney");
            Kidneys[0] = donatedKidney;
            Console.WriteLine($"{Name} now has a healthy kidney");
        }
    }
}
