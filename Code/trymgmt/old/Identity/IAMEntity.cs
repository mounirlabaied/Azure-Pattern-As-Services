using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt.Identity
{
    public class IAMEntity
    {
        public string ActiveDirectoryTenant { get; set; } = Guid.NewGuid().ToString();
        public List<string> UPNDomain { get; set; } = new List<string> { "@azure.domain.com", "@techdom.onmicrosoft.com" };
        public string VaultBaseUri { get; set; } = string.Format("https://{0}.azure.com/ressources{1}/{2}/", "tenantid", "subscription", "vaultname");
        public UriBuilder VaultBuilder { get; set; } = new UriBuilder();
        public bool GenerateRandomPassword { get; set; } = true;
        public string GeneratedPassword { get; set; } = string.Empty;  
        internal string GenerateRandom(int count, string basestr)
        {
            string encoding = Guid.NewGuid().ToString("n");
            string basestrdest = basestr + encoding;
            basestrdest = basestrdest.Substring(0, count);
            return basestrdest;
        }
        public IAMEntity()
        {
            this.GeneratedPassword = GenerateRandom(24, "cloud");

        }
    }
}
