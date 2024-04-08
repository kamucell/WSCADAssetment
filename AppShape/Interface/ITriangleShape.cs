using System.Windows.Controls;
using App.DataStructure.Interface;

namespace AppShape.Interface
{
    public interface ITriangleShape : IShape
    {
        void SetAttribute(ITriangleAttribute attribute);
        void Draw(Canvas canvas);
    }
}
