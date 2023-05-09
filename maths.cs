public class DateClass
{
    public string GetTime(){
       string str=DateTime.Now.ToShortDateString();
        return str;
    }

    public string GetDate(){
        Console.WriteLine("Enter format:");
        string? format=Console.ReadLine();
        return DateTime.Now.ToString(format);
    }
    public int GetMonth
    {
        get=> DateTime.Now.Month;    
    }

}
