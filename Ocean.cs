using System;

namespace лаба4__1
{
     class Ocean
     {
        public string Name { get; }

        public Ocean(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
     }
}
