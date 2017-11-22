using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    class AutoExtend : CustomerFeature
    {
        public string Name { get; set; } = "Auto Extend";
        public bool ContainsResources { get; set; } = false;
        public AutoExtend()
        {

        }
    }
}
