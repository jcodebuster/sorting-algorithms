namespace InsertionSort;

public class App
{
    public void Run()
    {
        var array = new[] {2, 3, 5, 4, 8, 3, 2, 1, 5, 6};
        var sort = new InsertionSort();
        sort.Sort(array);
        
        Console.WriteLine(String.Join(" ", array));
    }
}
