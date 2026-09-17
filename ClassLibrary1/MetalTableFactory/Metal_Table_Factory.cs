using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Metal_Table_Factory:ATableFactory
    {
        public ADining_tables createADining_tables()
        {
            return new Metal_Dining_Tables();
        }

        public ACoffee_tables createACoffee_tables()
        {
            return new Metal_Coffee_and_Side_Tables();
        }

        public AWriting_desks createAWriting_desks()
        {
            return new Metal_Writing_and_Computer_Desks();
        }
    }
}
