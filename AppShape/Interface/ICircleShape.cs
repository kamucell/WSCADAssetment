using System.Windows.Controls;
using AppDTO.Attribute.Abstract;


namespace AppShape.Interface
{
    public interface ICircleShape : IShape
    {
        void SetAttribute(ICirleAttribute attribute);
        void Draw(Canvas canvas);
    }
}
