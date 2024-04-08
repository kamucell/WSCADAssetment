using System.Windows.Controls;
using App.DataStructure.Interface;

namespace AppShape.Interface
{
    public interface ICircleShape : IShape
    {
        void SetAttribute(ICirleAttribute attribute);
        void Draw(Canvas canvas);
    }
}
