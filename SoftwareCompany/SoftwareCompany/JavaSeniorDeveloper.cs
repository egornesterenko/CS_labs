
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public class JavaSeniorDeveloper : DeveloperBuilder
    {
        public JavaSeniorDeveloper()
        {
            dev = new Developer(DeveloperType.Java);
        }
        public override void BuildLevel()
        {
            dev["WorkerLevel"] = "Senior";
        }

        public override void BuildMathKnowleges()
        {
            dev["MathKnowleges"] = "The Highes";
        }

        public override void BuildCoddingTime()
        {
            dev["CoddingTime"] = "Minimal";
        }

        public override void BuildTaskComplexity()
        {
            dev["TaskComplexity"] = "The Highest";
        }
    }
}