public class Program
{
    static void Main(string[] args)
    {
        double root;
          if(args==null || args.Length==0){System.Console.WriteLine("Nothing to run"); return;}
          foreach(string num in args)
          {
            root=Math.Sqrt(Convert.ToInt32(num));
            System.Console.WriteLine($"Root of {num} is {root}");
          }
    }
}