using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class Employee : Person
    {
        int ID { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

    }
}
