public class DateClass
{
    public string GetTime(){
       string str=DateTime.Now.ToShortDateString();
        return str;
    }

    public string GetDate(string format){
        return DateTime.Now.ToString(format);
    }
    public int GetMonth
    {
        get=> DateTime.Now.Month;    
    }

}
