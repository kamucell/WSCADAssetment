using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AppDataReader.JSONStrcuture
{
    public class JSONStructure : AppDataReader.Interface.IReaderStructure
    {
        public string border { get; set; }

        public string type { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string center { get; set; }
        public double radius { get; set; }
        public bool filled { get; set; }
        public string color { get; set; }
    }
}
