using App.DataStructure.Interface;
using AppShape.Interface;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AppShape
{
    public class LineShape : ILineShape
    {
        private ILineAttribute _attribute;

        public void Draw(Canvas canvas)
        {
            Line line = new Line();
            line.X1 = _attribute.Coordinate.FirstPoint.X;  
            line.Y1 = _attribute.Coordinate.FirstPoint.Y;  
            line.X2 = _attribute.Coordinate.SecondPoint.X;  
            line.Y2 = _attribute.Coordinate.SecondPoint.Y;
            line.Stroke = new SolidColorBrush(Color.FromArgb(_attribute.Color[0], _attribute.Color[1], _attribute.Color[2], _attribute.Color[3]));
            line.StrokeThickness = _attribute.Border.Size;      
            canvas.Children.Add(line);
        }

        public void SetAttribute(App.DataStructure.Interface.ILineAttribute attribute)
        {
            _attribute = attribute;
        }
    }
}
