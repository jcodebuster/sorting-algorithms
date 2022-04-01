namespace SelectionSort;

public class App
{
    public void Start()
    {
        var sort = new SelectionSort();
        var array = new[] {7, 5, 3, 5, 9, 51, 5};
        sort.Sort(ref array);
        Console.WriteLine(string.Join(" ", array));
    }
}
