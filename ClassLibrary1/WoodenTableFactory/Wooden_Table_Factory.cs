using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Wooden_Table_Factory: ATableFactory
    {
        public ADining_tables createADining_tables()
        {
            return new Wooden_dining_tables();
        }

        public ACoffee_tables createACoffee_tables()
        {
            return new Wooden_Coffee_Tables();
        }

        public AWriting_desks createAWriting_desks()
        {
            return new Wooden_Writing_and_Computer_Desks();
        }
    }
}
