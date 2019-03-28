using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public abstract class DeveloperBuilder
    {
        protected Developer dev;

        public Developer Developer
        {
            get { return dev; }
        }

        public abstract void BuildLevel();
        public abstract void BuildMathKnowleges();
        public abstract void BuildCoddingTime();
        public abstract void BuildTaskComplexity();
    }
}