using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{

    public class Developer
    {
        private DeveloperType _devType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Developer(DeveloperType devType)
        {
            _devType = devType;
        }

        public string this[string key]
        {
            get
            {
                return _parts[key];
            }
            set
            {
                _parts[key] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("---Worker Creation---");

            Console.WriteLine("Lang Type: {0}", _devType);
            Console.WriteLine(" Worker level : {0}", _parts["WorkerLevel"]);
            Console.WriteLine(" Math Knowleges : {0}", _parts["MathKnowleges"]);
            Console.WriteLine(" Codding Time: {0}", _parts["CoddingTime"]);
            Console.WriteLine(" Task Complexity : {0}", _parts["TaskComplexity"]);
            Console.ReadLine();
        }
    }
}