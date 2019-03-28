using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompany
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeveloperBuilder builder = null;

            RecrutmentDepatment rd = new RecrutmentDepatment();


            Console.WriteLine("What level of specialist are you looking for?");
            System.Console.WriteLine("========================================================");
            System.Console.WriteLine("1. Junior, 2. Middle, 3. Senior");
            System.Console.WriteLine("========================================================");
            int lvlType = Convert.ToInt16(Console.ReadLine());

            if (lvlType == 1)
            {
                Console.WriteLine("What programming lang are you looking for?");
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("1. C#, 2. JavaScript");
                System.Console.WriteLine("========================================================");
                int langType = Convert.ToInt16(Console.ReadLine());
                if (langType == 1)
                {
                    builder = new CSJuniorDeveloper();
                }
                else if (langType == 2)
                {
                    builder = new JSJuniorDeveloper();
                }
            }
            else if (lvlType == 2)
            {
                Console.WriteLine("What programming lang are you looking for?");
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("1. C#, 2. JavaScript");
                System.Console.WriteLine("========================================================");
                int langType = Convert.ToInt16(Console.ReadLine());
                if (langType == 1)
                {
                    builder = new CSMiddleDeveloper();
                }
                else if (langType == 2)
                {
                    builder = new JSMiddleDeveloper();
                }
            }
            else if (lvlType == 3)
            {
                Console.WriteLine("What programming lang are you looking for?");
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("1. Java, 2. JavaScript");
                System.Console.WriteLine("========================================================");
                int langType = Convert.ToInt16(Console.ReadLine());
                if (langType == 1)
                {
                    builder = new JavaSeniorDeveloper();
                }
                else if (langType == 2)
                {
                    builder = new JSSeniorDeveloper();
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            rd.Build(builder);
            builder.Developer.Show();
        }
    }
}