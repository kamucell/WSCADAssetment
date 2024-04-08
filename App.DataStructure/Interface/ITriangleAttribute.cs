namespace App.DataStructure.Interface
{
    public interface ITriangleAttribute : IAreaAttribute
    {
        public ITriangleCoordinate Coordinate { get; set; }
    }
}
