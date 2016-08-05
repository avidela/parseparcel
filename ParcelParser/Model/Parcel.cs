using System.Collections.Generic;
using ParcelParser.Extensions;

namespace ParcelParser.Model
{
    public class Parcel
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Parcel(List<double> dimensions, double weight)
        {
            dimensions.Sort();
            Breadth = dimensions.PopMax();
            Length = dimensions.PopMax();
            Height = dimensions.PopMax();
            Weight = weight;
        }
    }
}