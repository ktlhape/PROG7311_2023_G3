using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Company
    {
        public string Name { get; set; }
        private static Company company;
        public Company(){}
        private Company(string theName){
            this.Name = theName;
        }
        public static Company GetInstance(string name)
        {
            if (company == null)
            {
                company = new Company(name);
            }
            return company;
        }
        public static Company GetInstance()
        {
            if (company == null)
            {
                company = new Company();
            }

            return company;
        }

    }
}
