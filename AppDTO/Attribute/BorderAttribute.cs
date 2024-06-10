using AppDTO.Attribute.Abstract;

namespace AppDTO.Attribute
{
    public class BorderAttribute : IBorderAttribute
    {
        public int Size { get; set; }
        public int Type { get; set; }
    }
}
