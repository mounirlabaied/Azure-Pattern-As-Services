using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trymgmt;
using trymgmt.Identity;

namespace CloudCenter
{
    public sealed class Feature
    {
        public string Name { get; set; } = "FeatureName";
        public bool Active { get; set; } = true;
        public DateTime Created { get; set; } = DateTime.Now;
        public Feature()
        {

        }
    }
  
    public class SandboxFeatures
    {
        public List<string> Features { get; set; } = new List<string>();
        public SandboxFeatures()
        {



            var subclasses =
            from assembly in AppDomain.CurrentDomain.GetAssemblies()
            from type in assembly.GetTypes()
            where type.IsSubclassOf(typeof(CustomerFeature))
            select type;
            foreach (var classfound in subclasses)
            {
                this.Features.Add(classfound.Name);
            }


        }
        public virtual void Implement()
        {

        }
    }
}
