using System;

namespace лаба4__1
{
    class Continent
    {
        public string Name { get; }
        public List<Ocean> Oceans { get; }

        public Continent(string name, List<Ocean> oceans)
        {
            Name = name;
            Oceans = oceans;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Continent other)
            {
                return string.Equals(Name, other.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.ToLower().GetHashCode();
        }
    }
}
