using App.DataStructure.Coordinate.Abstract;
using AppDTO.Attribute.Abstract;

namespace AppDTO.Attribute
{
    public class TriangleAttribute : ITriangleAttribute
    {
        public byte[] Color { get; set; }
        public IBorderAttribute Border { get; set; }
        public ITriangleCoordinate Coordinate { get; set; }
        public bool IsFilled { get; set; }
     
    }
}
