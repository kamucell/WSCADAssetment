namespace App.DataStructure.Coordinate.Abstract
{
    public interface ILineCoordinate : ICoordinate
    {
        public IPoint SecondPoint { get; set; }
    }
}
