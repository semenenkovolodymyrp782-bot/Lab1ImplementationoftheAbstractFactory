using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ATableFactory
    {
        ADining_tables createADining_tables();
        ACoffee_tables createACoffee_tables();
        AWriting_desks createAWriting_desks();

    }
}
