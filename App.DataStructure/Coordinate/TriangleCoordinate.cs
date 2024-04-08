using App.DataStructure.Interface;

namespace App.DataStructure.Coordinate
{
    public class TriangleCoordinate : ITriangleCoordinate
    {
        public IPoint FirstPoint { get; set; }
        public IPoint SecondPoint { get; set; }
        public IPoint ThirdPoint { get; set; }
    }
}
