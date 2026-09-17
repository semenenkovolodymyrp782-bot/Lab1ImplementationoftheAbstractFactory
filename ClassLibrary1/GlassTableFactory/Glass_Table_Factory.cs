
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class Glass_Table_Factory : ATableFactory
    {
        public ADining_tables createADining_tables()
        {
            return new Glass_Dining_Tables();
        }

        public ACoffee_tables createACoffee_tables()
        {
            return new Glass_Coffee_and_Side_Tables();
        }

        public AWriting_desks createAWriting_desks()
        {
            return new Glass_Writing_and_Computer_Desks();
        }
    }
}
