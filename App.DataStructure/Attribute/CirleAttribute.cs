﻿using App.DataStructure.Interface;

namespace App.DataStructure.Attribute
{
    public class CirleAttribute:ICirleAttribute
    {
        public byte[] Color { get; set; }
        public IBorderAttribute Border { get; set; }
        public ICirleCoordinate Coordinate { get; set; }
        public bool IsFilled { get; set; }
        public double Radious { get; set; }
    }
}
