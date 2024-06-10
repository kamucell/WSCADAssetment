using System.Windows.Controls;
using App.DataStructure.Attribute.Abstract;
using AppDTO.Attribute.Abstract;

namespace AppShape.Interface
{
    public interface ITriangleShape : IShape
    {
        void SetAttribute(ITriangleAttribute attribute);
        void Draw(Canvas canvas);
    }
}
