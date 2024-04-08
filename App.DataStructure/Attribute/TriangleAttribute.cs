using App.DataStructure.Interface;

namespace App.DataStructure.Attribute
{
    public class TriangleAttribute : ITriangleAttribute
    {
        public byte[] Color { get; set; }
        public IBorderAttribute Border { get; set; }
        public ITriangleCoordinate Coordinate { get; set; }
        public bool IsFilled { get; set; }
     
    }
}
