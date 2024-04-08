using App.DataStructure.Interface;
using AppShape.Interface;
using System;
using System.Windows.Controls;

namespace AppShape
{
    public class EmptyShape : IShape
    {
        public void Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }

        public void SetAttribute(IAreaAttribute coordinate)
        {
            throw new NotImplementedException();
        }


    }
}
