namespace App.DataStructure.Interface
{
    public interface ILineCoordinate : ICoordinate
    {
        public IPoint SecondPoint { get; set; }
    }
}
