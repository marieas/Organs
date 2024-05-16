using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class PersonWList
    {
           public string Name { get; set; }
           public List<Kidney> Kidneys { get; set; }


            public PersonWList(string name, bool isSick)
            {
                Name = name;
                Kidneys = new List<Kidney>();
                if (isSick)
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
                Kidneys.Add(new Kidney(false));              
                Console.WriteLine($"{Name} was born and is dying! HELP");
            }
            private void InitHealthyKidneys()
            {
                Kidneys.Add(new Kidney(true));
                Kidneys.Add(new Kidney(true));
                Console.WriteLine($"{Name} was born and has {Kidneys.Count} healthy kidneys!");
            }

            public void GiveKidney(Person receiver)
            {
                Console.WriteLine($"{Name} is now donating his kidney to {receiver.Name}");
                receiver.ReceiveKidney(Kidneys[0]);
                Kidneys.RemoveAt(0);
                Console.WriteLine($"{Name} now only has {Kidneys.Count} functioning Kidney left");
            }

            public void ReceiveKidney(Kidney donatedKidney)
            {
                Console.WriteLine($"{Name} is now receiving his kidney");
                Kidneys.Add(donatedKidney);
                Console.WriteLine($"{Name} now has a healthy kidney");
            }
        }
    }

}
}
