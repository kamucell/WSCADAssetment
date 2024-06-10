namespace AppDTO.Attribute.Abstract
{
    public interface IShapeAttribute
    {
        byte[] Color { get; set; }
        IBorderAttribute Border { get; set; }

    }
}
