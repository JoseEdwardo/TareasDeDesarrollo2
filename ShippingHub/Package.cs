using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHub
{
    public class Package
    {
        //Propiedad con encapsulacion 
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }  //Nombres de Estados
        public string Zip { get; set; }
        public int PackageNumber { get; private set; }

        private static int nextPackageNumber = 1;

        public Package()
        {
            PackageNumber = nextPackageNumber++;
        }

        public override string ToString()
        {
            return $"#{PackageNumber} - {City}, {State}";
        }
    }
}
