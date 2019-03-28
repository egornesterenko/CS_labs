using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public class CSJuniorDeveloper : DeveloperBuilder
    {
        public CSJuniorDeveloper()
        {
            dev = new Developer(DeveloperType.CS);
        }
        public override void BuildLevel()
        {
            dev["WorkerLevel"] = "Junior";
        }

        public override void BuildMathKnowleges()
        {
            dev["MathKnowleges"] = "Middle";
        }

        public override void BuildCoddingTime()
        {
            dev["CoddingTime"] = "Maximum";
        }

        public override void BuildTaskComplexity()
        {
            dev["TaskComplexity"] = "Low";
        }
    }
}