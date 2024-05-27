namespace Strategy
{
    public class Coordinate
    {
        public double Long { get; set; }
        public double Lat { get; set; }

        public override string ToString()
        {
            return $"[Long: {Long}], [Lat: {Lat}]";
        }
    }
}
