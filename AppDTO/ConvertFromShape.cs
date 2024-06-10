using System;
using System.Collections.Generic;
using AppDataReader.JSONStrcuture;
using AppShape;
using AppShape.Interface;
using App.DataStructure.Coordinate;
using System.Windows.Media;
using App.DataStructure.Coordinate.Abstract;
using AppDTO.Attribute;

namespace AppDTO
{
    public class ConvertFromShape : IConvertor<AppDataReader.JSONStrcuture.JSONStructure>
    {

        protected IPoint ToPoint(string s) => new App.DataStructure.Coordinate.Point() {X = Convert.ToDouble(s.Split(';')[0]), Y = Convert.ToDouble(s.Split(';')[1])};
        protected byte[] ToColor(string s) => new  byte[] {Convert.ToByte(s.Split(';')[0]), Convert.ToByte(s.Split(';')[1]), Convert.ToByte(s.Split(';')[2]), Convert.ToByte(s.Split(';')[3])
        };

        public IEnumerable<IShape> ConvertTo(IEnumerable<JSONStructure> source)
        {
            List<IShape> lst = new List<IShape>();
            foreach (var item in source)
            {
                IShape lnShp = new AppShape.EmptyShape();
                switch (item.type)
                {
                    case "line":
                        lnShp = new LineShape();
                        ((ILineShape)lnShp).SetAttribute(new LineAttribute()
                        {
                            Color = ToColor(item.color),
                            Border = new BorderAttribute()
                            {
                                Size = Convert.ToInt32(item.border ?? "1")
                            },
                            Coordinate = new LineCoordinate
                            {
                                FirstPoint = ToPoint(item.a),
                                SecondPoint = ToPoint(item.b),
                            }
                        });
                        break;
                    case "circle":
                        lnShp = new CircleShape();
                        ((ICircleShape)lnShp).SetAttribute(new CirleAttribute()
                        {
                            Color = ToColor(item.color),
                            IsFilled = item.filled,
                            Border = new BorderAttribute()
                            {
                                Size = Convert.ToInt32(item.border ?? "1")
                            },
                            Coordinate = new CirleCoordinate()
                            {
                                FirstPoint = ToPoint(item.center),
                                Radious = item.radius,
                            }
                        });
                        break;
                    case "triangle":
                        lnShp = new TriangleShape();
                        ((ITriangleShape)lnShp).SetAttribute(new TriangleAttribute()
                        {
                            Border = new BorderAttribute()
                            {
                                Size = Convert.ToInt32(item.border ?? "1")
                            },
                            Color = ToColor(item.color),
                            IsFilled = item.filled,
                            Coordinate = new TriangleCoordinate()
                            {
                                FirstPoint = ToPoint(item.a),
                                SecondPoint = ToPoint(item.b),
                                ThirdPoint = ToPoint(item.c),
                            }
                        });
                        break;



                }
                lst.Add(lnShp);
            }

            return lst;
        }


    }
}
