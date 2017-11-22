using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    public class AutoShutDown : CustomerFeature
    {
        public string Name { get; set; } = "AutoShutDown";
        public Feature feature { get; set; } = new Feature();
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public AutoShutDown()
        {
            this.Properties.Add(this);
            this.Name = GetName();
            this.Creation = DateTime.Now;
            BusinessLine = "AMP";
        }
        public override void Implement()
        {
            Console.WriteLine("AutoShutDown");
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
