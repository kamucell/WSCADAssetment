using App.DataStructure.Interface;
using AppShape.Interface;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppShape
{
    public class CircleShape : ICircleShape
    {
        private ICirleAttribute _attribute;
        public void Draw(Canvas canvas)
        {
            var circle = new System.Windows.Shapes.Ellipse();

            circle.Height = circle.Width = 2 * _attribute.Radious;
            circle.Stroke = new SolidColorBrush(Color.FromArgb(_attribute.Color[0], _attribute.Color[1], _attribute.Color[2], _attribute.Color[3]));  
            circle.StrokeThickness  = _attribute.Border.Size;
            if (_attribute.IsFilled) circle.Fill = circle.Stroke;
            Canvas.SetLeft(circle, 50);
            Canvas.SetTop(circle, 50);
            canvas.Children.Add(circle);
        }
        public void SetAttribute(ICirleAttribute attribute)
        {
            _attribute = attribute;
        }
    }
}
