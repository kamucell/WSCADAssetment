using App.DataStructure.Interface;
using System.Windows.Controls;

namespace AppShape.Interface
{
    public interface ILineShape:IShape
    {
        
        void Draw(Canvas canvas);
        void SetAttribute(App.DataStructure.Interface.ILineAttribute attribute);
    }
}
