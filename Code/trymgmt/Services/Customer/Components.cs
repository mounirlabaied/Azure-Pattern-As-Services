using CloudCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trymgmt
{
    public interface ICustomerResource
    {
        string Name();
        string ID();
        string Type();
    }
    public class CustomerResource : ICustomerResource
    {
        private string id { get; set; }
        public string name { get { return name; } set { name = value; } }
        private string type { get; set; }
        public string ID() { return id; }

        public string Name() { return name; }

        public string Type() { return type; }
        public CustomerResource()
        {

        }
    }
    public interface ICustomer
    {
        string Project();
    }
    public class Customer : ICustomer
    {
        public Customer()
        {

        }
        public Infrastructure infrastructure { get; set; } = new Infrastructure();
        public InfrastructureNetwork infrastructurenetwork = new InfrastructureNetwork();
        public string Name { get; set; }
        public string Departement { get; set; } = "MyDepartement";
        public string JiraRequest { get; set; } = "https://jirarequest.domain/id";
        public string Owner { get; set; } = "MyOwner";
        private string project { get; set; } = "Project01";
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expire { get; set; } = DateTime.Now.AddDays(180);
        public DateTime Modified { get; set; } = DateTime.Now;
        public string Region { get; set; } = "NorthEurope";
        public string BaseResourceName { get; set; } = "sbx";
        public string ID { get; set; } = Guid.NewGuid().ToString("n").ToLower();
        public SandboxFeatures Components { get; set; } = new SandboxFeatures();


        public string Project()
        {
            return project;
        }
    }

}
