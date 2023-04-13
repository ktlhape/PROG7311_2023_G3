using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class Course
    {
        public string Code { get; set; }
        public string Desc { get; set; }
        private double cost;

        public double Cost
        {
            get { return cost; }
            set
            {
                if (cost != value)
                {
                    cost = value;
                    Notify();
                }
            }
        }
        private List<Student> StList { get; set; } = new List<Student>();
        public Course(string theCode, string theDesc, double theCost)
        {
            this.Code = theCode;
            this.Desc = theDesc;
            this.Cost = theCost;
        }

        public void Attach(Student st)
        {
            StList.Add(st);
        }
        public void Detach(Student st)
        {
            StList.Remove(st);
        }
        //Notify all the observers
        public void Notify()
        {
            foreach (Student st in StList)
            {
                st.Update(this);
            }
        }
    }
}
