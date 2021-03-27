using System;

namespace BasicWebForm
{
    public class MyClass1
    {
        public MyClass1()
        {
            this.Field1 = 20;
        }
        public MyClass1(int field1)
        {
            this.Field1 = field1;
        }
        ~MyClass1()
        { }

        public int Field1;
        public int Property1 { get; set; }
        public void Method1()
        {
        }

        public double GetArea(double radius)
        {
            double result = Math.Pow(radius, 2) * Math.PI;
            return result;
        }
    }
}



