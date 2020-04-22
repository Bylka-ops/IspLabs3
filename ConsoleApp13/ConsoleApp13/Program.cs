using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class People
    {
        private static int number = 0;
        private int id;
        private string _firstName;
        private string _lastName;

        public string _FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "FirstName": return _firstName;
                    case "LastName": return _lastName;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "FirstName":
                        _firstName = value;
                        break;
                    case "LastName":
                        _lastName = value;
                        break;

                }
            }
        }

        public string _LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public People(string FirstName, string LastName)
        {
            number++;
            id = number;
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void PrintPeople()
        {
            Console.Write(id.ToString() + " " + _FirstName + " " + _LastName);
        }

        public void SetPeople(string FirstName, string LastName)
        {
            _FirstName=FirstName;
            _LastName=LastName;
        }
    }
    class Sportsman : People
    {
        private string _nameSport;

        public string _NameSport
        {
            get
            {
                return _nameSport;
            }
            set
            {
                _nameSport = value;
            }
        }

        public Sportsman(string FirstName, string LastName, string NameSport) : base(FirstName, LastName)
        {
            _nameSport = NameSport;
        }

        public void PrintSportsmen()
        {
            PrintPeople();
            Console.Write(" " + _NameSport);
        }

        public void SetPeople(string FirstName, string LastName, string NameSport)
        {
            SetPeople(FirstName, LastName);
            _nameSport=NameSport;
        }
    }
    class SpecialistsInSelectedSports : Sportsman
    {
        private string _nameSelectedSports;

        public SpecialistsInSelectedSports(string FirstName, string LastName, string NameSport, string NameSelectedSports)
            : base(FirstName, LastName, NameSport)
        {
            _nameSelectedSports = NameSelectedSports;
        }

        public string _NameSelectedSports
        {
            get
            {
                return _nameSelectedSports;
            }
            set
            {
                _nameSelectedSports = value;
            }
        }

        public void PrintSpecialist()
        {
            PrintSportsmen();
            Console.Write(" " + _NameSelectedSports);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("Артем", "Ермаков");
            People people1 = new People("Виктория", "Панченко");
            people.PrintPeople();
            Console.WriteLine();
            people1.PrintPeople();
            Console.WriteLine();
            people1.SetPeople("Виктория", "Ермакова");
            people1.PrintPeople();
            Console.WriteLine();
            Sportsman sportsman = new Sportsman("Мария", "Кухарева", "Теннис");
            sportsman.PrintSportsmen();
            Console.WriteLine();
            SpecialistsInSelectedSports specialistsInSelectedSports = new SpecialistsInSelectedSports("Константин", "Тишкевич", "Футбол", "Игровые");
            specialistsInSelectedSports.PrintSpecialist();
            Console.WriteLine();
            sportsman.SetPeople("Тиханов", "Михаил");
            sportsman.PrintSportsmen();
            Console.WriteLine();
            sportsman.SetPeople("Мария", "Кухарева", "Шахматы");
            sportsman.PrintSportsmen();
            Console.ReadKey();
        }
    }
}
