using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    public interface IInfrastructureIComponent
    {
        bool SecurityFeatures();
        string Name();
    }
    public class InfrastructureNetwork : Infrastructure, IInfrastructureIComponent
    {
        private string NetworkName { get; set; } = "";
        private bool Securityfeatures = true;
        public InfrastructureNetwork()
        {

        }
        public new string Name()
        {
            return NetworkName;
        }

        public new bool SecurityFeatures()
        {
            return Securityfeatures;
        }
    }


    public enum Region { NorthEurope,WestEurope}
    public class Infrastructure : IInfrastructureIComponent
    {
        private string InfrastructureName { get; set; } = "Default";
        public string VirtualNetworkUri { get; set; } = string.Empty;
        public List<string> VirtualNetworkUris { get; set; } = new List<string>();
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool Securityfeatures = true;
        public bool UseTerraformComponent = true;
        public string TerraformStateFileUri = "";
        public List<string> VirtualNetwork_Peered { get; set; } = new List<string>();
        public Infrastructure()
        {
            
        }

        public bool SecurityFeatures()
        {
            return this.Securityfeatures;
        }

        public string Name()
        {
            return this.InfrastructureName;
        }
    }
}
