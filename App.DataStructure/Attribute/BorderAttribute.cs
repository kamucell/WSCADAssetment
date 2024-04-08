using App.DataStructure.Interface;

namespace App.DataStructure.Attribute
{
    public class BorderAttribute : IBorderAttribute
    {
        public int Size { get; set; }
        public int Type { get; set; }
    }
}
