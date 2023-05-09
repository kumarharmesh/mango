public enum SortOrder
{
    ASC,
    DESC
}
public class SortString{

    public SortOrder order{get;set;}
    public SortString()
    {
        order=SortOrder.ASC;
    }
    public string[] Sorting(params string[] ary)
    {
        string temp;
        for(int i=0;i<ary.Length;i++)
        {
            for(int j=i+1;j<ary.Length;j++)
            {
                if(order==SortOrder.DESC)
                {
                    if(ary[i].CompareTo(ary[j])==-1)
                    {
                        temp=ary[i];
                        ary[i]=ary[j];
                        ary[j]=temp;
                    }
                }
                else
                {
                    if(ary[i].CompareTo(ary[j])==1)
                    {
                        temp=ary[i];
                        ary[i]=ary[j];
                        ary[j]=temp;
                    }
                }
            }
        }
        return ary;
    }
}