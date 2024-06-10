using App.DataStructure.Coordinate.Abstract;

namespace App.DataStructure.Coordinate
{
    public class LineCoordinate : ILineCoordinate
    {
        public IPoint FirstPoint { get; set; }
        public IPoint SecondPoint { get; set; }
    }
}
