using App.DataStructure.Interface;

namespace App.DataStructure.Coordinate
{
    public class CirleCoordinate : ICirleCoordinate
    {
        public IPoint FirstPoint { get; set; }
        public double Radious { get; set; }
    }
}
