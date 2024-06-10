using System.Windows.Controls;
using AppDTO.Attribute.Abstract;

namespace AppShape.Interface
{
    public interface ILineShape:IShape
    {
        
        void Draw(Canvas canvas);
        void SetAttribute(ILineAttribute attribute);
    }
}
