public class Dog : Animal, IRunnable, IBarkable
{

    public void Bark()
    {
        System.Console.WriteLine("Dog barks...");
    }

    public void Run()
    {
        System.Console.WriteLine("Dog runs...");
    }
}