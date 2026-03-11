using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    

    public class OwnTypeTask
    {
        private double x;
        private double y;
        private double z;
        public OwnTypeTask(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double CalculateVectorLength(double x, double y, double z)
        {
            return Math.Sqrt( x * x + y * y + z * z);
        }
    }
}
