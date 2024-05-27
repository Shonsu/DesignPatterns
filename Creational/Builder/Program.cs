namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new GuitarBuilder();
            var guitar = builder
                .SetNeck("Maple")
                .SetBody("Mahoganyu")
                .SetBridge("FloydRose")
                .SetFingerboard("Rosewood")
                .SetFrets("Stainless steel")
                .Build();
        }
    }
}
