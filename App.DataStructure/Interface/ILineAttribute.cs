namespace App.DataStructure.Interface
{
    public interface ILineAttribute : IShapeAttribute
    {
        byte[] Color { get; set; }
        IBorderAttribute Border { get; set; }
        ILineCoordinate Coordinate { get; set; }
    }
}