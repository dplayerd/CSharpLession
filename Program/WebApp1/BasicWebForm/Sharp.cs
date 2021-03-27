using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebForm
{
    public class Sharp
    {
        public double GetArea()
        {
            return 0;
        }
    }

    public class Circle : Sharp
    {
        #region Constructuror 
        public Circle() { }

        public Circle(double raduis)
        {
            this.Raduis = raduis;
        }
        #endregion

        #region Field
        public double P1;
        #endregion


        #region Property
        public double Raduis { get; set; }
        #endregion

        #region Methods
        public new double GetArea()
        {
            double result = Math.Pow(this.Raduis, 2) * Math.PI;
            return result;
        }
        #endregion
    }

    public class Square : Sharp
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area
        {
            get { return this.Height * this.Width; }
        }


        public new double GetArea()
        {
            return this.Height * this.Width;
        }
    }


    public class Main
    {
        public void Main1()
        {

        }
    }
}