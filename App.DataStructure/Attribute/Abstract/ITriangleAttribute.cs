using App.DataStructure.Coordinate.Abstract;

namespace AppDTO.Attribute.Abstract
{
    public interface ITriangleAttribute : IAreaAttribute
    {
        public ITriangleCoordinate Coordinate { get; set; }
    }
}
