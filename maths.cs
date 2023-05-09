public class DateClass
{
    public string GetTime(){
        return DateTime.Now.ToShortDateString();
    }

    public string GetDate(string format){
        return DateTime.Now.ToString(format);
    }
}