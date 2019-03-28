using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public class CSMiddleDeveloper : DeveloperBuilder
    {
        public CSMiddleDeveloper()
        {
            dev = new Developer(DeveloperType.CS);
        }
        public override void BuildLevel()
        {
            dev["WorkerLevel"] = "Middle";
        }

        public override void BuildMathKnowleges()
        {
            dev["MathKnowleges"] = "High";
        }

        public override void BuildCoddingTime()
        {
            dev["CoddingTime"] = "Middle";
        }

        public override void BuildTaskComplexity()
        {
            dev["TaskComplexity"] = "High";
        }
    }
}