using System;
using System.Collections.Generic;
using System.Text;

namespace Raytracing
{
    class Ray
    {
        
    }

    abstract class Object
    {


        public abstract 
    }

    class Plane : Object
    {

    }

    class Sphere : Object
    {
        Vec
    }

    class Vector
    {
        public int Length => arr.Length;
        public double[] arr;

        public Vector(int length)
        {
            arr = new double[length];
        }

        public double this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public static Add(Vector a, Vector b)
        {
            if (a.Length != b.Length)
                throw new Exception();
            Vector c = new Vector(a.Length);
        }
    }
}
