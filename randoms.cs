public class RandomNumber
{
     public static int RNum()
     {
        Random r=new Random();
        int res=r.Next(1,11);
        return res;
     }
}