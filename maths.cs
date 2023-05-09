public class DateClass
{
    public string GetTime(){
       string str=DateTime.Now.ToShortDateString();
        return str;
    }

    public string GetDate(string format){
        string temp=DateTime.Now.ToString(format);
        return temp;
    }
    public int GetMonth
    {
        get=> DateTime.Now.Month;    
    }

}
