using System;
using System.Collections.Generic;
using System.Text;

namespace AustinProject2202020IT242
{
    class Building
    {

        private string Designer { get; set; }

        private DateTime DateConstructed { get; set; }

        public string Address { get; set; }

        private string Owner { get; set; }

        public int Stories;

        public double Width;

        public double Depth;

        public string Volume
        {
            get
            {
                var volume = Width * Depth * (Stories * 3);
                return volume;
            }
        }
        public class Constructor(Address customer)
        {
            public Constructor (s address)
            {
                Address = address
            }

        public Address Name { set; }
        }

        }
    }
