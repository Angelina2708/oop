using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Culture
    {
        private string name;
        public string Name

        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }

        private string type;
        public string Type

        {
            get
            {
                return type;
            }
            set
            {
                type = value;

            }
        }
        private int area;
        public int Area

        {
            get
            {
                return area;
            }
            set
            {
                area = value;

            }
        }
        private int harvest;
        public int Harvest

        {
            get
            {
                return harvest;
            }
            set
            {
                harvest = value;

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Culture myObj = new Culture();

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    myObj.Name = "Coя";
                    myObj.Type = "Б";
                    myObj.Area = 13000;
                    myObj.Harvest = 45;
                    Console.WriteLine(myObj.Name + "|" + " Тип " + myObj.Type + "|" + " Площа посiву (га) " + myObj.Area + "|" + " Врожайнiсть (ц/га) " + myObj.Harvest);
                }
                else if (i == 1)
                {
                    myObj.Name = "Чумиза";
                    myObj.Type = "З";
                    myObj.Area = 8000;
                    myObj.Harvest = 17;
                    Console.WriteLine(myObj.Name + "|" + " Тип " + myObj.Type + "|" + " Площа посiву (га) " + myObj.Area + "|" + " Врожайнiсть (ц/га) " + myObj.Harvest);
                }
                else
                {
                    myObj.Name = "Рис";
                    myObj.Type = "З";
                    myObj.Area = 25650;
                    myObj.Harvest = 24;
                    Console.WriteLine(myObj.Name + "|" + " Тип " + myObj.Type + "|" + " Площа посiву (га) " + myObj.Area + "|" + " Врожайнiсть (ц/га) " + myObj.Harvest);
                }
            }
        }
    }
}