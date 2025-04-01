using System;

namespace лаба4__1
{
     class Planet
     {
        public string Name { get; }
        public List<Continent> Continents { get; }
        public List<Ocean> Oceans { get; }

        public Planet()
        {
            Name = "Земля";

            Oceans = new List<Ocean>
            {
               new Ocean("Тихий"),
               new Ocean("Атлантичний"),
               new Ocean("Індійський"),
               new Ocean("Північний Льодовитий"),
               new Ocean("Південний Льодовитий")
            };

            Continents = new List<Continent>
            {
               new Continent("Африка", new List<Ocean> { Oceans[1], Oceans[2] }),
               new Continent("Північна Америка", new List<Ocean> { Oceans[0], Oceans[1], Oceans[3] }),
               new Continent("Південна Америка", new List<Ocean> { Oceans[0], Oceans[1] }),
               new Continent("Антарктида", new List<Ocean> { Oceans[4] }),
               new Continent("Австралія", new List<Ocean> { Oceans[0], Oceans[2] }),
               new Continent("Євразія", new List<Ocean> { Oceans[0], Oceans[1], Oceans[2], Oceans[3] })
            };
        }

        public void PrintPlanetName()
        {
            Console.WriteLine($"Планета: {Name}");
        }

        public void PrintContinentCount()
        {
            Console.WriteLine($"Кількість материків: {Continents.Count}");
            Console.Write("Mатерики: ");
            foreach (var continent in Continents)
            {
                Console.Write(continent.Name + "; ");
            }
            Console.WriteLine();
        }

        public bool ContinentExists(string continentName)
        {
            return Continents.Exists(c => string.Equals(c.Name, continentName));
        }

        public void PrintContinentInfo(string continentName)
        {
            var continent = Continents.Find(c => string.Equals(c.Name, continentName));
            if (continent != null)
            {
                Console.WriteLine($"Материк: {continent.Name}");
                Console.Write("Океани, які омивають: ");
                foreach (var ocean in continent.Oceans)
                {
                    Console.Write(ocean.Name + "; ");
                }
                Console.WriteLine($"\nКількість океанів: {continent.Oceans.Count}");
            }
        }

        public override string ToString()
        {
            var continentsStr = string.Join(", ", Continents);
            var oceansStr = string.Join(", ", Oceans);
            return Name;
        }

    }
}
