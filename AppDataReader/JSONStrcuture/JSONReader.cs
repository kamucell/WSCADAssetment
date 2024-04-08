using AppDataReader.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AppDataReader.JSONStrcuture
{
    public class JSONReader : IReader
    {
        public bool IsDataValid() => true;
        public bool IsSchema() => true;
        public bool IsValid() => IsSchema() && IsDataValid();

        public IEnumerable<IReaderStructure> Read(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<JSONStructure>>(jsonString);

        }


    }
}
