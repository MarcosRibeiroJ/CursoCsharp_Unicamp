namespace Jewel_Collector
{
    public class JewelCollector {

        public static void Main() {
  
            Tree tree = new Tree(2,3);
            Console.Write(tree);
            Console.Write(tree.X);
            Console.WriteLine(tree.Y);

            Watter watter = new Watter(5,2);
            Console.Write(watter);
            Console.Write(watter.X);
            Console.Write(watter.Y);
            Console.Write(nameof(watter));
        }
    }
}
