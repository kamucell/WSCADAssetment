using AppShape.Interface;
using System;
using System.Windows.Controls;
using AppDTO.Attribute.Abstract;

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
