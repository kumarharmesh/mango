public class DateClass
{
    public string GetTime(){
        return DateTime.Now.ToShortDateString();
    }

    public string GetDate(string format){
        string temp=DateTime.Now.ToString(format);
        return temp;
    }
}