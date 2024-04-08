using AppDataReader.Interface;
using AppDataReader.JSONStrcuture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataReader
{
    public class DataReaderFactory
    {
        public enum DataReaderType
        {
            JSONReader
        }
        public static IReader CreateDataReader(DataReaderType dataReaderType)
        {
            switch (dataReaderType)
            {
                case DataReaderType.JSONReader:
                    return new JSONReader();
            }
            throw new NotSupportedException(" Driver Not Supported ");
            return null;

        }
    }
}
