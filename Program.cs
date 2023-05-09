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
            System.Console.WriteLine("---------------------------");
            
          }
          for(int i=0;i<=10;i++)
            {
                Console.WriteLine($"Num: {RandomNumber.RNum()}");
            }
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            SortString co=new SortString();
            co.order=SortOrder.DESC;
            string [] arr=co.Sorting("a","b","c");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Guid id=Identifiers.GetId();
            System.Console.WriteLine(id.ToString());
    }
}