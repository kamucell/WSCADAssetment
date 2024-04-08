﻿namespace App.DataStructure.Interface
{
    public interface ITriangleCoordinate : ICoordinate
    {
        public IPoint SecondPoint { get; set; }
        public IPoint ThirdPoint { get; set; }
    }
}
