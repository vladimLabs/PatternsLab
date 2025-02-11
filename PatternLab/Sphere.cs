using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    public class Sphere : ICloneable
    {
        public double Radius { get; set; }
        public Vector3 Position { get; set; }

        public Sphere(double radius, Vector3 position)
        {
            Radius = radius;
            Position = position;
        }

        public ICloneable Clone()
        {
            return new Sphere(Radius, new Vector3(Position.X, Position.Y, Position.Z));
        }
    }
}
