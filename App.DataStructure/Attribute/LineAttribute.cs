using App.DataStructure.Interface;

namespace App.DataStructure.Attribute
{
    public class LineAttribute : ILineAttribute
    {
        public byte[] Color { get; set; }
        public IBorderAttribute Border { get; set; }
        public ILineCoordinate Coordinate { get; set; }

    }
}