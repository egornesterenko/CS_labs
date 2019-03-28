using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public class RecrutmentDepatment
    {
        public void Build(DeveloperBuilder devBuilder)
        {
            devBuilder.BuildLevel();
            devBuilder.BuildCoddingTime();
            devBuilder.BuildMathKnowleges();
            devBuilder.BuildTaskComplexity();
        }
    }
}