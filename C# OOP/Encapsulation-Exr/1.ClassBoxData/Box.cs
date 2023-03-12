using System;
using System.Collections.Generic;
using System.Text;

namespace _1.ClassBoxData
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Length cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get => height; set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Height cannot be zero or negative.");
                }
            }
        }
        //2lw + 2lh + 2wh
        public double GetSurfaceArea()
        {
            return 2 * (Length * Width) + 2 * (Length * Height) + 2 * (Width * Height);
        }
        public double GetLateralSurface()
        {
            return 2 * (Length * Height) + 2 * (Width * Height);
        }
        public double GetVolume()
        {
            return Length * Width * Height;
        }
    }
}
