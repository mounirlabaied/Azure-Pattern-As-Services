using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    public class Feature
    {
        public string BusinessLine { get; set; } = string.Empty;
        public DateTime Creation { get; set; } = DateTime.Now;
        public string Name { get; set; } = "FeatureName";
        public bool Active { get; set; } = true;
        public DateTime Created { get; set; } = DateTime.Now;


        public List<dynamic> Properties { get; set; } = new List<dynamic>();
        public Feature()
        {
            dynamic a = this.GetType();
        }
        protected string GetName() { return this.GetType().FullName; }

    }

    public class CustomerFeature : Feature
    {
        public decimal GlobalVersion { get; set; } = 1.2m;
        public CustomerFeature()
        {
            Trace.TraceInformation(string.Format("Loading new class : {0}", this));
            this.Creation = DateTime.Now;
        }

        public override string ToString()
        {
            return
            JsonConvert.SerializeObject(this);

        }
        public virtual void Implement()
        {

        }

    }
}
