using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidneyTransplant
{
    internal class Kidney
    {
        public bool IsHealthy {  get; set; }
        public Kidney(bool isHealthy)
        {
            IsHealthy = isHealthy;
        }   
    }
}
