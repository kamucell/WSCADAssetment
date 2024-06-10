using App.DataStructure.Coordinate.Abstract;
using AppDTO.Attribute.Abstract;

namespace AppDTO.Attribute
{
    public class LineAttribute : ILineAttribute
    {
        public byte[] Color { get; set; }
        public IBorderAttribute Border { get; set; }
        public ILineCoordinate Coordinate { get; set; }

    }
}