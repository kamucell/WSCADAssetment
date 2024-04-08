using AppShape.Interface;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using App.DataStructure.Interface;

namespace AppShape
{
    public class TriangleShape : ITriangleShape
    {
        private ITriangleAttribute _attribute;

        public void Draw(Canvas canvas)
        {
            Polygon triangle = new Polygon();

            PointCollection points = new PointCollection();
            points.Add(new System.Windows.Point(_attribute.Coordinate.FirstPoint.X, _attribute.Coordinate.FirstPoint.Y));
            points.Add(new System.Windows.Point(_attribute.Coordinate.SecondPoint.X, _attribute.Coordinate.SecondPoint.Y));
            points.Add(new System.Windows.Point(_attribute.Coordinate.ThirdPoint.X, _attribute.Coordinate.ThirdPoint.Y));


            triangle.Points = points;
            triangle.Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(_attribute.Color[0], _attribute.Color[1], _attribute.Color[2], _attribute.Color[3]));
            triangle.StrokeThickness = _attribute.Border.Size; 
            if(_attribute.IsFilled) triangle.Fill = triangle.Stroke;

            Canvas.SetLeft(triangle, 0);
            Canvas.SetTop(triangle, 0);

            canvas.Children.Add(triangle);
        }

        public void SetAttribute(ITriangleAttribute attribute)
        {
            _attribute = attribute;
        }
    }
}