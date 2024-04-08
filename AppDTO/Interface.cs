using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDTO
{
    public interface IConvertor<T>
    {
        IEnumerable<AppShape.Interface.IShape> ConvertTo(IEnumerable<T> source);
    }
}
