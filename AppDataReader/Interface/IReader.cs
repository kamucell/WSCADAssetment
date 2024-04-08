using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AppDataReader.Interface
{

    public interface IReader
    {
        bool IsDataValid();
        bool IsSchema();
        bool IsValid();
        IEnumerable<IReaderStructure> Read(string path);
    }
}

