﻿using System;
using System.Collections.Generic;
using System.Reflection;

class Shape
{
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape {
    private int width;
    private int height;
    public int Width 
    {
        get
        {
            return width;
        } set
        {
            if (value < 0)
                throw new System.ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        } set
        {
            if (value < 0)
                throw new System.ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}