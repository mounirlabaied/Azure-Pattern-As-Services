using CloudCenter;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    class Program
    {
        static void TestAndDev()
        {
            var subclasses =
            from assembly in AppDomain.CurrentDomain.GetAssemblies()
            from type in assembly.GetTypes()
            where type.IsSubclassOf(typeof(CustomerFeature))
            select type;
            foreach (var classfound in subclasses)
            {
                Console.WriteLine(classfound.AssemblyQualifiedName);
                Type ClassType = Type.GetType(classfound.FullName);
                dynamic o = Activator.CreateInstance(ClassType);
                o.Implement();

            }
            InfrastructureNetwork test = new InfrastructureNetwork();
            Customer Testv2 = new Customer();
            //List<Tuple<Customer, InfrastructureNetwork, Infrastructure>> Link = new List<Tuple<Customer, InfrastructureNetwork, Infrastructure>>();
            Testv2.Name = "MounirSandbox";

            //Sandbox CreatedObj = new Sandbox();
        }
        static void Main(string[] args)
        {   
            TestAndDev();
        }
    }
}
