using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    public class RemoteDesktop : CustomerFeature
    {
        public string Name { get; set; } = "Remote Desktop";
        public string RDSFarmName { get; set; } = "NorthEurope_Farm";
        public DateTime Date { get; set; } = DateTime.Parse("21/03/1988");
        public RemoteDesktop()
        {
            this.Properties.Add(this);
            this.Name = GetName();
            this.Creation = DateTime.Now;

        }
        public override void Implement()
        {
            Console.WriteLine("Remote Desktop Implementation..");
        }

    }

}
