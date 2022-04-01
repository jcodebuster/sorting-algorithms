using MergeSort;
namespace MergeSort;

public class App
{
    public void Start()
    {
        var array = new[] {4,6,1,3,5 };
        var merge = new MergeSort();
        merge.Sort(array);
    }
}
