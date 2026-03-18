public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<double> oceny { get; set; }
    public int Wiek { get; set; }
}

class Program
{
    public static int CalculateAverage(int[] values)
    {
        return values.Sum();
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateAverage([10,20,30]));
        List<Student> studenci = new List<Student>();
        studenci.Add(new Student
        {
            Id=1,
            Name="John",
            Wiek= 18
        });
        studenci.Add(new Student
        {
            Id=2,
            Name="Annie",
            Wiek= 22
        });
        studenci.Add(new Student
        {
            Id=3,
            Name="Frank",
            Wiek=30
        });
        studenci.Add(new Student
        {
            Id=4,
            Name="Andrew",
            Wiek=27
        });
        IEnumerable<Student> rezultat3 = studenci.Where(s => s.Wiek > 25);
    }
}