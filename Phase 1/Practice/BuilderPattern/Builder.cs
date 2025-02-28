using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Builder
    {
        private Laptop _laptop = new Laptop();
        
        public Builder setProcessor(string processor)
        {
            _laptop.Processor = processor;
            return this;
        }
        public Builder setRAM(string ram)
        {
            _laptop.RAM = ram;
            return this;
        }

        public Laptop Build()
        {
            return _laptop;
        }
    }
}
