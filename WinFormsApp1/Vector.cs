using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    

    public class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector operator+(Vector a, Vector b)
        {
            var xResult = a.x + b.x;
            var yResult = a.y + b.y;
            var zResult= a.z + b.z;
            var resultVector = new Vector(xResult, yResult, zResult);
            return resultVector;
        }
        public static Vector operator-(Vector a, Vector b)
        {
            var xResult = a.x - b.x;
            var yResult = a.y - b.y;
            var zResult = a.z - b.z;
            var resultVector = new Vector(xResult, yResult, zResult);
            return resultVector;
        }
        public static double operator*(Vector a, Vector b)
        {
            var result= a.x*b.x+a.y*b.y+a.z*b.z;
            return result;
        }
        public static Vector operator&(Vector a, Vector b)
        {
            var xResult = ((a.y * b.z) - (a.z * b.y));
            var yResult = -1 * ((a.x * b.z) - (a.z * b.x));
            var zResult = ((a.x * b.y) - (a.y * b.x));
            var resultVector = new Vector(xResult, yResult, zResult);
            return resultVector;
        }
        public string OutputCoordinates()
        {
            return String.Format("[{0};{1};{2}]", this.x, this.y, this.z);
        }
        public double CalculateVectorLength()
        {
            var result = Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            return result;
        }
    }
}
