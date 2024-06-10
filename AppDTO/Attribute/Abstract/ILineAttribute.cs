using App.DataStructure.Coordinate.Abstract;

namespace AppDTO.Attribute.Abstract
{
    public interface ILineAttribute : IShapeAttribute
    {
        byte[] Color { get; set; }
        IBorderAttribute Border { get; set; }
        ILineCoordinate Coordinate { get; set; }
    }
}