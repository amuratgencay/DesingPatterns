﻿using System;
using DesignPattern.Entity.AbstractFactoryPattern.Fill;
using DesignPattern.Entity.AbstractFactoryPattern.Shape;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public class ShapeFactory : IAbstractFactory
    {
        public IShape CreateShape(ShapeType param)
        {
            switch (param)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(10, 15);
                case ShapeType.Sqaure:
                    return new Square(10);
                case ShapeType.Circle:
                    return new Circle(10);
                default:
                    throw new ArgumentOutOfRangeException(nameof(param), param, null);
            }
        }

        IFill IAbstractFactory.CreateFill(FillType param)
        {
            throw new NotImplementedException();
        }
    }
}