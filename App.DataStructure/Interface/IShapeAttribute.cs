namespace App.DataStructure.Interface
{
    public interface IShapeAttribute
    {
        byte[] Color { get; set; }
        IBorderAttribute Border { get; set; }
        
    }
}
